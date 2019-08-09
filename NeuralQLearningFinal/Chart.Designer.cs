namespace NeuralQLearningFinal
{
    partial class Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.errorChart = new AForge.Controls.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ymax = new System.Windows.Forms.Label();
            this.lbl_ymin = new System.Windows.Forms.Label();
            this.lbl_xmin = new System.Windows.Forms.Label();
            this.lbl_xmax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorChart
            // 
            this.errorChart.Location = new System.Drawing.Point(74, 31);
            this.errorChart.Name = "errorChart";
            this.errorChart.RangeX = ((AForge.Range)(resources.GetObject("errorChart.RangeX")));
            this.errorChart.RangeY = ((AForge.Range)(resources.GetObject("errorChart.RangeY")));
            this.errorChart.Size = new System.Drawing.Size(627, 257);
            this.errorChart.TabIndex = 4;
            this.errorChart.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(344, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Error chart";
            // 
            // lbl_ymax
            // 
            this.lbl_ymax.Location = new System.Drawing.Point(12, 31);
            this.lbl_ymax.Name = "lbl_ymax";
            this.lbl_ymax.Size = new System.Drawing.Size(56, 13);
            this.lbl_ymax.TabIndex = 6;
            this.lbl_ymax.Text = "Error chart";
            this.lbl_ymax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_ymin
            // 
            this.lbl_ymin.Location = new System.Drawing.Point(12, 275);
            this.lbl_ymin.Name = "lbl_ymin";
            this.lbl_ymin.Size = new System.Drawing.Size(56, 13);
            this.lbl_ymin.TabIndex = 7;
            this.lbl_ymin.Text = "Error chart";
            this.lbl_ymin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_xmin
            // 
            this.lbl_xmin.Location = new System.Drawing.Point(71, 291);
            this.lbl_xmin.Name = "lbl_xmin";
            this.lbl_xmin.Size = new System.Drawing.Size(56, 13);
            this.lbl_xmin.TabIndex = 8;
            this.lbl_xmin.Text = "Error chart";
            // 
            // lbl_xmax
            // 
            this.lbl_xmax.Location = new System.Drawing.Point(645, 291);
            this.lbl_xmax.Name = "lbl_xmax";
            this.lbl_xmax.Size = new System.Drawing.Size(56, 13);
            this.lbl_xmax.TabIndex = 9;
            this.lbl_xmax.Text = "Error chart";
            this.lbl_xmax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 315);
            this.Controls.Add(this.lbl_xmax);
            this.Controls.Add(this.lbl_xmin);
            this.Controls.Add(this.lbl_ymin);
            this.Controls.Add(this.lbl_ymax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chart";
            this.Text = "Chart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.Chart errorChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ymax;
        private System.Windows.Forms.Label lbl_ymin;
        private System.Windows.Forms.Label lbl_xmin;
        private System.Windows.Forms.Label lbl_xmax;
    }
}