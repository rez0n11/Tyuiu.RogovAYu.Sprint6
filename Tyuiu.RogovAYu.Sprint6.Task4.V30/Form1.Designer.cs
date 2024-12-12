namespace Tyuiu.RogovAYu.Sprint6.Task4.V30
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop = new Panel();
            LabelTask = new Label();
            pictureBox1 = new PictureBox();
            LabelStop = new Label();
            LabelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            SaveButton = new Button();
            Helpbutton = new Button();
            GoButton = new Button();
            panelLeft = new Panel();
            textRes = new TextBox();
            panelFIll = new Panel();
            chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLeft.SuspendLayout();
            panelFIll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFx).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(LabelTask);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(LabelStop);
            panelTop.Controls.Add(LabelStart);
            panelTop.Controls.Add(textBoxStop);
            panelTop.Controls.Add(textBoxStart);
            panelTop.Controls.Add(SaveButton);
            panelTop.Controls.Add(Helpbutton);
            panelTop.Controls.Add(GoButton);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(997, 168);
            panelTop.TabIndex = 0;
            // 
            // LabelTask
            // 
            LabelTask.AutoSize = true;
            LabelTask.Location = new Point(36, 28);
            LabelTask.Name = "LabelTask";
            LabelTask.Size = new Size(421, 20);
            LabelTask.TabIndex = 8;
            LabelTask.Text = "Протабулировать функцию на отрезке и построить график";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LabelStop
            // 
            LabelStop.AutoSize = true;
            LabelStop.CausesValidation = false;
            LabelStop.Location = new Point(493, 91);
            LabelStop.Name = "LabelStop";
            LabelStop.Size = new Size(53, 20);
            LabelStop.TabIndex = 6;
            LabelStop.Text = "Конец";
            // 
            // LabelStart
            // 
            LabelStart.AutoSize = true;
            LabelStart.Location = new Point(493, 51);
            LabelStart.Name = "LabelStart";
            LabelStart.Size = new Size(61, 20);
            LabelStart.TabIndex = 5;
            LabelStart.Text = "Начало";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(573, 88);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(573, 45);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(797, 122);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Helpbutton
            // 
            Helpbutton.Location = new Point(797, 74);
            Helpbutton.Name = "Helpbutton";
            Helpbutton.Size = new Size(94, 29);
            Helpbutton.TabIndex = 1;
            Helpbutton.Text = "?";
            Helpbutton.UseVisualStyleBackColor = true;
            Helpbutton.Click += Helpbutton_Click;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(797, 28);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 0;
            GoButton.Text = "Выполнить";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(textRes);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 168);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 594);
            panelLeft.TabIndex = 1;
            // 
            // textRes
            // 
            textRes.Dock = DockStyle.Left;
            textRes.Location = new Point(0, 0);
            textRes.Multiline = true;
            textRes.Name = "textRes";
            textRes.Size = new Size(250, 594);
            textRes.TabIndex = 0;
            textRes.TabStop = false;
            textRes.UseSystemPasswordChar = true;
            // 
            // panelFIll
            // 
            panelFIll.Controls.Add(chartFx);
            panelFIll.Dock = DockStyle.Fill;
            panelFIll.Location = new Point(250, 168);
            panelFIll.Name = "panelFIll";
            panelFIll.Size = new Size(747, 594);
            panelFIll.TabIndex = 2;
            // 
            // chartFx
            // 
            chartArea2.Name = "ChartArea1";
            chartFx.ChartAreas.Add(chartArea2);
            chartFx.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFx.Legends.Add(legend2);
            chartFx.Location = new Point(0, 0);
            chartFx.Name = "chartFx";
            chartFx.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFx.Series.Add(series2);
            chartFx.Size = new Size(747, 594);
            chartFx.TabIndex = 0;
            chartFx.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 762);
            Controls.Add(panelFIll);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "6.4.30";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelFIll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label LabelTask;
        private PictureBox pictureBox1;
        private Label LabelStop;
        private Label LabelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button SaveButton;
        private Button Helpbutton;
        private Button GoButton;
        private Panel panelLeft;
        private Panel panelFIll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private TextBox textRes;
    }
}
