namespace NeuralQLearningFinal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_Simulation = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_visualizeLearning = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_currenAverageError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CurrentIteration = new System.Windows.Forms.TextBox();
            this.errorChart = new AForge.Controls.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_SamplesAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tb_iters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ConnectLRtoIt = new System.Windows.Forms.CheckBox();
            this.tb_SigmoidValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_momentum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_learningRate = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_unit2minus = new System.Windows.Forms.Button();
            this.btn_unit2plus = new System.Windows.Forms.Button();
            this.btn_unit1minus = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_unit1plus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Set = new System.Windows.Forms.Button();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Simulation
            // 
            this.pb_Simulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Simulation.Location = new System.Drawing.Point(12, 19);
            this.pb_Simulation.Name = "pb_Simulation";
            this.pb_Simulation.Size = new System.Drawing.Size(230, 230);
            this.pb_Simulation.TabIndex = 0;
            this.pb_Simulation.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_visualizeLearning);
            this.groupBox1.Controls.Add(this.pb_Simulation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation";
            // 
            // cb_visualizeLearning
            // 
            this.cb_visualizeLearning.AutoSize = true;
            this.cb_visualizeLearning.Location = new System.Drawing.Point(12, 255);
            this.cb_visualizeLearning.Name = "cb_visualizeLearning";
            this.cb_visualizeLearning.Size = new System.Drawing.Size(133, 17);
            this.cb_visualizeLearning.TabIndex = 1;
            this.cb_visualizeLearning.Text = "Simulate while learning";
            this.cb_visualizeLearning.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_currenAverageError);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_CurrentIteration);
            this.groupBox2.Controls.Add(this.errorChart);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error\'s dynamics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current summary error:";
            // 
            // tb_currenAverageError
            // 
            this.tb_currenAverageError.Location = new System.Drawing.Point(179, 94);
            this.tb_currenAverageError.Name = "tb_currenAverageError";
            this.tb_currenAverageError.ReadOnly = true;
            this.tb_currenAverageError.Size = new System.Drawing.Size(100, 20);
            this.tb_currenAverageError.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current iteration:";
            // 
            // tb_CurrentIteration
            // 
            this.tb_CurrentIteration.Location = new System.Drawing.Point(182, 42);
            this.tb_CurrentIteration.Name = "tb_CurrentIteration";
            this.tb_CurrentIteration.ReadOnly = true;
            this.tb_CurrentIteration.Size = new System.Drawing.Size(100, 20);
            this.tb_CurrentIteration.TabIndex = 4;
            // 
            // errorChart
            // 
            this.errorChart.Location = new System.Drawing.Point(12, 19);
            this.errorChart.Name = "errorChart";
            this.errorChart.RangeX = ((AForge.Range)(resources.GetObject("errorChart.RangeX")));
            this.errorChart.RangeY = ((AForge.Range)(resources.GetObject("errorChart.RangeY")));
            this.errorChart.Size = new System.Drawing.Size(161, 143);
            this.errorChart.TabIndex = 3;
            this.errorChart.Text = "chart1";
            this.errorChart.Click += new System.EventHandler(this.errorChart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_stop);
            this.groupBox3.Controls.Add(this.tb_SamplesAmount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_Test);
            this.groupBox3.Controls.Add(this.btn_Start);
            this.groupBox3.Controls.Add(this.tb_iters);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_ConnectLRtoIt);
            this.groupBox3.Controls.Add(this.tb_SigmoidValue);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_momentum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_learningRate);
            this.groupBox3.Location = new System.Drawing.Point(273, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 290);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neural network parameters";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(73, 248);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 14;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_SamplesAmount
            // 
            this.tb_SamplesAmount.Location = new System.Drawing.Point(132, 133);
            this.tb_SamplesAmount.Name = "tb_SamplesAmount";
            this.tb_SamplesAmount.Size = new System.Drawing.Size(100, 20);
            this.tb_SamplesAmount.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Samples ammount:";
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(154, 218);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 11;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(73, 219);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tb_iters
            // 
            this.tb_iters.Location = new System.Drawing.Point(132, 107);
            this.tb_iters.Name = "tb_iters";
            this.tb_iters.Size = new System.Drawing.Size(100, 20);
            this.tb_iters.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Iterations ammount:";
            // 
            // cb_ConnectLRtoIt
            // 
            this.cb_ConnectLRtoIt.AutoSize = true;
            this.cb_ConnectLRtoIt.Location = new System.Drawing.Point(73, 195);
            this.cb_ConnectLRtoIt.Name = "cb_ConnectLRtoIt";
            this.cb_ConnectLRtoIt.Size = new System.Drawing.Size(181, 17);
            this.cb_ConnectLRtoIt.TabIndex = 6;
            this.cb_ConnectLRtoIt.Text = "Connect learnig rate to itterations";
            this.cb_ConnectLRtoIt.UseVisualStyleBackColor = true;
            // 
            // tb_SigmoidValue
            // 
            this.tb_SigmoidValue.Location = new System.Drawing.Point(132, 81);
            this.tb_SigmoidValue.Name = "tb_SigmoidValue";
            this.tb_SigmoidValue.Size = new System.Drawing.Size(100, 20);
            this.tb_SigmoidValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sigmoid\'s alpha value:";
            // 
            // tb_momentum
            // 
            this.tb_momentum.Location = new System.Drawing.Point(132, 55);
            this.tb_momentum.Name = "tb_momentum";
            this.tb_momentum.Size = new System.Drawing.Size(100, 20);
            this.tb_momentum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Momentum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learning rate:";
            // 
            // tb_learningRate
            // 
            this.tb_learningRate.Location = new System.Drawing.Point(132, 29);
            this.tb_learningRate.Name = "tb_learningRate";
            this.tb_learningRate.Size = new System.Drawing.Size(100, 20);
            this.tb_learningRate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_unit2minus);
            this.groupBox4.Controls.Add(this.btn_unit2plus);
            this.groupBox4.Controls.Add(this.btn_unit1minus);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btn_unit1plus);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_Set);
            this.groupBox4.Controls.Add(this.tb_y);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tb_x);
            this.groupBox4.Location = new System.Drawing.Point(317, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 176);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manipulator";
            // 
            // btn_unit2minus
            // 
            this.btn_unit2minus.Location = new System.Drawing.Point(179, 78);
            this.btn_unit2minus.Name = "btn_unit2minus";
            this.btn_unit2minus.Size = new System.Drawing.Size(33, 29);
            this.btn_unit2minus.TabIndex = 20;
            this.btn_unit2minus.Text = "-";
            this.btn_unit2minus.UseVisualStyleBackColor = true;
            this.btn_unit2minus.Click += new System.EventHandler(this.btn_unit2minus_Click);
            // 
            // btn_unit2plus
            // 
            this.btn_unit2plus.Location = new System.Drawing.Point(179, 41);
            this.btn_unit2plus.Name = "btn_unit2plus";
            this.btn_unit2plus.Size = new System.Drawing.Size(33, 30);
            this.btn_unit2plus.TabIndex = 19;
            this.btn_unit2plus.Text = "+";
            this.btn_unit2plus.UseVisualStyleBackColor = true;
            this.btn_unit2plus.Click += new System.EventHandler(this.btn_unit2plus_Click);
            // 
            // btn_unit1minus
            // 
            this.btn_unit1minus.Location = new System.Drawing.Point(130, 78);
            this.btn_unit1minus.Name = "btn_unit1minus";
            this.btn_unit1minus.Size = new System.Drawing.Size(33, 29);
            this.btn_unit1minus.TabIndex = 18;
            this.btn_unit1minus.Text = "-";
            this.btn_unit1minus.UseVisualStyleBackColor = true;
            this.btn_unit1minus.Click += new System.EventHandler(this.btn_unit1minus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Unit B:";
            // 
            // btn_unit1plus
            // 
            this.btn_unit1plus.Location = new System.Drawing.Point(130, 41);
            this.btn_unit1plus.Name = "btn_unit1plus";
            this.btn_unit1plus.Size = new System.Drawing.Size(33, 30);
            this.btn_unit1plus.TabIndex = 16;
            this.btn_unit1plus.Text = "+";
            this.btn_unit1plus.UseVisualStyleBackColor = true;
            this.btn_unit1plus.Click += new System.EventHandler(this.btn_unit1plus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Unit A:";
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(9, 94);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(64, 29);
            this.btn_Set.TabIndex = 14;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(29, 67);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(44, 20);
            this.tb_y.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Target:";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(29, 41);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(44, 20);
            this.tb_x.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Advanced";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 499);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Deep Q-Learning demonstration";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Simulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_visualizeLearning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_currenAverageError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CurrentIteration;
        private AForge.Controls.Chart errorChart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_iters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_ConnectLRtoIt;
        private System.Windows.Forms.TextBox tb_SigmoidValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_momentum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_learningRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_unit2minus;
        private System.Windows.Forms.Button btn_unit2plus;
        private System.Windows.Forms.Button btn_unit1minus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_unit1plus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_SamplesAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button button1;
    }
}

