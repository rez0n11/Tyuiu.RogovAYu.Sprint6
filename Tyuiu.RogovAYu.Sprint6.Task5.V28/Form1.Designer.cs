namespace Tyuiu.RogovAYu.Sprint6.Task5.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            labelTask = new Label();
            buttonGo = new Button();
            buttonHelp = new Button();
            buttonSave = new Button();
            panel2 = new Panel();
            GridBox = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTask);
            panel1.Controls.Add(buttonGo);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(530, 20);
            label1.TabIndex = 1;
            label1.Text = "Вывести все числа, меньше 10. Построить диаграмму по этим значениям. ";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(12, 21);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(525, 20);
            labelTask.TabIndex = 1;
            labelTask.Text = "Прочитать данные из файла InPutFileTask5V28.txt. Вывести в dataGridView. ";
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(718, 12);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(111, 29);
            buttonGo.TabIndex = 0;
            buttonGo.Text = "Выполнить";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(756, 82);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(37, 29);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(718, 47);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(111, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(GridBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 427);
            panel2.TabIndex = 0;
            // 
            // GridBox
            // 
            GridBox.AllowUserToAddRows = false;
            GridBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBox.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            GridBox.Dock = DockStyle.Left;
            GridBox.Location = new Point(0, 0);
            GridBox.Name = "GridBox";
            GridBox.RowHeadersVisible = false;
            GridBox.RowHeadersWidth = 51;
            GridBox.Size = new Size(229, 427);
            GridBox.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = " ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = " ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // panel3
            // 
            panel3.Controls.Add(chart);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(229, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(658, 427);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(658, 427);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            chart.Click += chart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 552);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridBox).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView GridBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label labelTask;
        private Button buttonGo;
        private Button buttonHelp;
        private Button buttonSave;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
