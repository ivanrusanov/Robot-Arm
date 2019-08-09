using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;

namespace NeuralQLearningFinal
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        Form1 form1;

        public Chart(Form1 form1, double[,] errors)
        {
            InitializeComponent();
            this.form1 = form1;

            errorChart.AddDataSeries("error", Color.Red, AForge.Controls.Chart.SeriesType.Line, 1);

            errorChart.RangeX = new Range(0, errors.Length / 2 - 1);
            errorChart.UpdateDataSeries("error", errors);

            lbl_ymax.Text = Math.Round((errorChart.RangeY.Max), 4).ToString();
            lbl_ymin.Text = Math.Round((errorChart.RangeY.Min), 4).ToString();
            lbl_xmax.Text = Math.Round((errorChart.RangeX.Max), 4).ToString();
            lbl_xmin.Text = Math.Round((errorChart.RangeX.Min), 4).ToString();
        }
    }
}
