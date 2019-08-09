using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralQLearningFinal
{
    public partial class ANSettings : Form
    {
        public ANSettings()
        {
            InitializeComponent();
        }

        Form1 form1;

        public ANSettings(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
    }
}
