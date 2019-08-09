using AForge;
using AForge.Neuro;
using AForge.Neuro.Learning;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NeuralQLearningFinal
{
    public partial class Form1 : Form
    {
        Manipulator man;
        Random rnd;
        ActivationNetwork AN;
        BackPropagationLearning teacher;

        private double learningRate = 1;
        private double momentum = 0.3;
        private double sigmoidAlphaValue = 1;
        private double iterationsAmount = 100;
        private bool ConnectLRtoIt = false;
        private int samplesAmount = 3000;
        private System.Drawing.Point targetPoint = new System.Drawing.Point(30, 30);

        private bool needToStop = false;

        public Form1()
        {
            InitializeComponent();

            // update controls
            UpdateSettings();

            // initialize charts
            errorChart.AddDataSeries("error", Color.Red, AForge.Controls.Chart.SeriesType.Line, 1);
        }

        public double[,] errors;
        int inputLayer;
        int[] layers = new int[] { 10, 5, 1 };

        void Learn()
        {
            //перенести в обработчик кнопки c try/catch
            inputLayer = man.AngleDiscretization * 2 + 4;
            if (layers == null)
                layers = new int[] { 10, 5, 1 };
            //if (layers[layers.Length-1] != 1)


            AN = new ActivationNetwork(new BipolarSigmoidFunction(sigmoidAlphaValue), inputLayer, layers);
            teacher = new BackPropagationLearning(AN);
            teacher.Momentum = momentum;
            teacher.LearningRate = learningRate;

            string dir = Application.StartupPath + "samples.txt";
            //GenerateSamples(@"C:\samples.txt", samplesAmount);
            //Sample[] samples = GetSamples(@"C:\samples.txt");
            GenerateSamples(dir, samplesAmount);
            Sample[] samples = GetSamples(dir);

            double summaryError = 0;
            ArrayList errorsList = new ArrayList();

            for (int i = 0; i < iterationsAmount; i++)
            {
                if (cb_ConnectLRtoIt.Checked)
                    teacher.LearningRate = learningRate / (1 + i * 10f / iterationsAmount);

                double error = 0;
                for (int j = 0; j < samples.Length; j++)
                {
                    double[] input = samples[j].GetInput();
                    double[] output = new double[1] { samples[j].reward };

                    error = teacher.Run(input, output);
                }

                errorsList.Add(error);
                summaryError += error;
                if (needToStop) break;
                tb_CurrentIteration.Text = i.ToString();
                tb_currenAverageError.Text = (summaryError / i).ToString();
                Application.DoEvents();
                Simulation();
            }

            // show error's dynamics
            errors = new double[errorsList.Count, 2];

            for (int i = 0, n = errorsList.Count; i < n; i++)
            {
                errors[i, 0] = i;
                errors[i, 1] = (double)errorsList[i];
            }

            errorChart.RangeX = new Range(0, errorsList.Count - 1);
            errorChart.UpdateDataSeries("error", errors);

            EnableControls(true);

        }

        private Sample[] GetSamples(string MyPath)
        {
            string[] data = File.ReadAllLines(MyPath);
            var sampleList = new List<Sample>();

            for (int i = 0; i < data.Length; i++)
            {
                sampleList.Add(JsonConvert.DeserializeObject<Sample>(data[i]));
            }

            return sampleList.ToArray();
        }

        void GenerateSamples(string MyPath, int samplesAmount)
        {
            File.Delete(MyPath);

            double currentDistance;
            double lastDistance;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < samplesAmount; i++)
            {
                // переводим манипулятор в случайное положение
                man.RandomState();
                lastDistance = man.GetDistance();

                if (cb_visualizeLearning.Checked)
                    Simulation();

                //выбираем и делаем случайное действие
                int action = rnd.Next(4);
                int[] actionArray = new int[4];
                actionArray[action] = 1;
                man.DoAction(action);
                currentDistance = man.GetDistance();

                if (cb_visualizeLearning.Checked)
                    Simulation();

                //формируем эталонное вознаграждение
                double reward = -(currentDistance - lastDistance) / 20;

                Sample smpl = new Sample(man.AngleA, man.AngleB, actionArray, reward);

                var str = JsonConvert.SerializeObject(smpl);
                sb.AppendLine(str);
            }
            File.WriteAllText(MyPath, sb.ToString());
        }

        private void UpdateSettings()
        {
            tb_learningRate.Text = learningRate.ToString();
            tb_momentum.Text = momentum.ToString();
            tb_SigmoidValue.Text = sigmoidAlphaValue.ToString();
            tb_iters.Text = iterationsAmount.ToString();
            cb_ConnectLRtoIt.Checked = ConnectLRtoIt;
            tb_x.Text = targetPoint.X.ToString();
            tb_y.Text = targetPoint.Y.ToString();
            tb_SamplesAmount.Text = samplesAmount.ToString();
        }

        private void EnableControls(bool enable)
        {
            tb_learningRate.Enabled = enable;
            tb_momentum.Enabled = enable;
            tb_SigmoidValue.Enabled = enable;
            tb_iters.Enabled = enable;
            cb_ConnectLRtoIt.Enabled = enable;
            tb_SamplesAmount.Enabled = enable;

            btn_Start.Enabled = enable;
            btn_Test.Enabled = enable;
        }

        void Simulation()
        {
            System.Drawing.Point baseP = new System.Drawing.Point(pb_Simulation.Size.Width / 2, pb_Simulation.Size.Height / 2);
            Graphics g = pb_Simulation.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 3);
            Pen pen2 = new Pen(Color.Blue, 3);
            Pen pen3 = new Pen(Color.Black, 1);

            pb_Simulation.Refresh();

            g.DrawLine(pen1, baseP.X, baseP.Y, man.GetPointA.X + baseP.X, baseP.Y - man.GetPointA.Y);
            g.DrawLine(pen2, man.GetPointA.X + baseP.X, baseP.Y - man.GetPointA.Y, man.GetPointB.X + baseP.X, baseP.Y - man.GetPointB.Y);
            g.DrawEllipse(pen3, man.GetTargetPoint.X + baseP.X, baseP.Y - man.GetTargetPoint.Y, 3, 3);
        }

        private int FindBestAction()
        {
            double maxValue = double.MinValue;
            int maxIndex = 0;
            int len = 4;

            for (int i = 0; i < len; i++)
            {
                Sample smpl = new Sample(man.AngleA, man.AngleB, GetActionArray(len, i), 0);

                var output = AN.Compute(smpl.GetInput());

                if (output[0] > maxValue)
                {
                    maxValue = output[0];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        int[] GetActionArray(int len, int ind)
        {
            var arr = new int[len];
            arr[ind] = 1;
            return arr;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            man = new Manipulator(targetPoint.X, targetPoint.Y);
            rnd = new Random();
            Simulation();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                learningRate = Math.Max(0.00001, Math.Min(1, double.Parse(tb_learningRate.Text)));
            }
            catch
            {
                learningRate = 1;
            }

            try
            {
                momentum = Math.Max(0, Math.Min(0.5, double.Parse(tb_momentum.Text)));
            }
            catch
            {
                momentum = 0.3;
            }

            try
            {
                sigmoidAlphaValue = Math.Max(0.01, Math.Min(100, double.Parse(tb_SigmoidValue.Text)));
            }
            catch
            {
                sigmoidAlphaValue = 1;
            }

            try
            {
                iterationsAmount = Math.Max(1, double.Parse(tb_iters.Text));
            }
            catch
            {
                iterationsAmount = 100;
            }

            try
            {
                samplesAmount = Math.Max(1, int.Parse(tb_SamplesAmount.Text));
            }
            catch
            {
                samplesAmount = 3000;
            }

            ConnectLRtoIt = cb_ConnectLRtoIt.Checked;

            UpdateSettings();
            EnableControls(false);

            needToStop = false;

            try
            {
                Learn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            man.DoAction(FindBestAction());
            Simulation();
        }

        private void btn_unit1plus_Click(object sender, EventArgs e)
        {
            man.DoAction(0);
            Simulation();
        }

        private void btn_unit1minus_Click(object sender, EventArgs e)
        {
            man.DoAction(1);
            Simulation();
        }

        private void btn_unit2plus_Click(object sender, EventArgs e)
        {
            man.DoAction(2);
            Simulation();
        }

        private void btn_unit2minus_Click(object sender, EventArgs e)
        {
            man.DoAction(3);
            Simulation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            targetPoint.X = int.Parse(tb_x.Text);
            targetPoint.Y = int.Parse(tb_y.Text);
            man.Target = targetPoint;
            Simulation();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            needToStop = true;
        }

        private void errorChart_Click(object sender, EventArgs e)
        {
            Chart chrtfrm = new Chart(this, errors);
            chrtfrm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ANSettings aNSettings = new ANSettings(this);
            aNSettings.Show();
        }
    }
}
