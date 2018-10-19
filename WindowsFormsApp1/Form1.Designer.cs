namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pressureText = new System.Windows.Forms.TextBox();
            this.pressureBtn = new System.Windows.Forms.Button();
            this.serialData = new System.Windows.Forms.RichTextBox();
            this.readSerialButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-25, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Pressure Sensed";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Input Pressure";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(843, 317);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Pressure (Pa):";
            // 
            // pressureText
            // 
            this.pressureText.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureText.Location = new System.Drawing.Point(16, 371);
            this.pressureText.Name = "pressureText";
            this.pressureText.Size = new System.Drawing.Size(100, 26);
            this.pressureText.TabIndex = 2;
            this.pressureText.Text = "0.0";
            // 
            // pressureBtn
            // 
            this.pressureBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureBtn.Location = new System.Drawing.Point(16, 403);
            this.pressureBtn.Name = "pressureBtn";
            this.pressureBtn.Size = new System.Drawing.Size(75, 35);
            this.pressureBtn.TabIndex = 3;
            this.pressureBtn.Text = "Enter";
            this.pressureBtn.UseVisualStyleBackColor = true;
            this.pressureBtn.Click += new System.EventHandler(this.pressureBtn_Click);
            // 
            // serialData
            // 
            this.serialData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.serialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialData.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialData.Location = new System.Drawing.Point(169, 344);
            this.serialData.Name = "serialData";
            this.serialData.Size = new System.Drawing.Size(471, 94);
            this.serialData.TabIndex = 4;
            this.serialData.Text = "";
            this.serialData.TextChanged += new System.EventHandler(this.serialData_TextChanged);
            // 
            // readSerialButton
            // 
            this.readSerialButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readSerialButton.Location = new System.Drawing.Point(659, 403);
            this.readSerialButton.Name = "readSerialButton";
            this.readSerialButton.Size = new System.Drawing.Size(105, 35);
            this.readSerialButton.TabIndex = 5;
            this.readSerialButton.Text = "Read Serial";
            this.readSerialButton.UseVisualStyleBackColor = true;
            this.readSerialButton.Click += new System.EventHandler(this.readSerialButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Multimaterial Claw Controller";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readSerialButton);
            this.Controls.Add(this.serialData);
            this.Controls.Add(this.pressureBtn);
            this.Controls.Add(this.pressureText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pressureText;
        private System.Windows.Forms.Button pressureBtn;
        private System.Windows.Forms.RichTextBox serialData;
        private System.Windows.Forms.Button readSerialButton;
        private System.Windows.Forms.Label label2;
    }
}

