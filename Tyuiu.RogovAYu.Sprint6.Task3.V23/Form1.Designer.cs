namespace Tyuiu.RogovAYu.Sprint6.Task3.V23
{
    partial class FormMain
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
            GridRes_RAYu = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            d = new DataGridViewTextBoxColumn();
            e = new DataGridViewTextBoxColumn();
            Task = new Label();
            Matrix = new TextBox();
            GoButton_RAYu = new Button();
            HelpButton_RAYu = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)GridRes_RAYu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GridRes_RAYu
            // 
            GridRes_RAYu.AllowUserToAddRows = false;
            GridRes_RAYu.AllowUserToDeleteRows = false;
            GridRes_RAYu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridRes_RAYu.Columns.AddRange(new DataGridViewColumn[] { a, b, c, d, e });
            GridRes_RAYu.Location = new Point(-50, 26);
            GridRes_RAYu.Name = "GridRes_RAYu";
            GridRes_RAYu.ReadOnly = true;
            GridRes_RAYu.RowHeadersWidth = 51;
            GridRes_RAYu.Size = new Size(324, 228);
            GridRes_RAYu.TabIndex = 0;
            // 
            // a
            // 
            a.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            a.HeaderText = "";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Width = 23;
            // 
            // b
            // 
            b.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            b.HeaderText = "";
            b.MinimumWidth = 6;
            b.Name = "b";
            b.ReadOnly = true;
            b.Width = 23;
            // 
            // c
            // 
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            c.HeaderText = "";
            c.MinimumWidth = 6;
            c.Name = "c";
            c.ReadOnly = true;
            c.Width = 23;
            // 
            // d
            // 
            d.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.HeaderText = "";
            d.MinimumWidth = 6;
            d.Name = "d";
            d.ReadOnly = true;
            d.Width = 23;
            // 
            // e
            // 
            e.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            e.HeaderText = "";
            e.MinimumWidth = 6;
            e.Name = "e";
            e.ReadOnly = true;
            e.Width = 23;
            // 
            // Task
            // 
            Task.AutoSize = true;
            Task.FlatStyle = FlatStyle.Flat;
            Task.Location = new Point(22, 24);
            Task.Name = "Task";
            Task.RightToLeft = RightToLeft.No;
            Task.Size = new Size(640, 20);
            Task.TabIndex = 1;
            Task.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию во втором столбце.";
            // 
            // Matrix
            // 
            Matrix.BorderStyle = BorderStyle.None;
            Matrix.Location = new Point(95, 89);
            Matrix.Multiline = true;
            Matrix.Name = "Matrix";
            Matrix.ReadOnly = true;
            Matrix.Size = new Size(127, 112);
            Matrix.TabIndex = 2;
            Matrix.Text = "  0  -19  25  34   0\r\n-19 -16   1  -5  34\r\n  1   13  -5 -17  -5\r\n  3   -9 -15  -1   0\r\n  1   20  15  -5  31";
            // 
            // GoButton_RAYu
            // 
            GoButton_RAYu.Location = new Point(95, 207);
            GoButton_RAYu.Name = "GoButton_RAYu";
            GoButton_RAYu.Size = new Size(127, 60);
            GoButton_RAYu.TabIndex = 3;
            GoButton_RAYu.Text = "Выполнить";
            GoButton_RAYu.UseVisualStyleBackColor = true;
            GoButton_RAYu.Click += GoButton_RAYu_Click;
            // 
            // HelpButton_RAYu
            // 
            HelpButton_RAYu.Location = new Point(140, 289);
            HelpButton_RAYu.Name = "HelpButton_RAYu";
            HelpButton_RAYu.Size = new Size(31, 26);
            HelpButton_RAYu.TabIndex = 4;
            HelpButton_RAYu.Text = "?";
            HelpButton_RAYu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GridRes_RAYu);
            groupBox1.Location = new Point(376, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 200);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 347);
            Controls.Add(groupBox1);
            Controls.Add(HelpButton_RAYu);
            Controls.Add(GoButton_RAYu);
            Controls.Add(Matrix);
            Controls.Add(Task);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "6.3.23 | Рогов";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridRes_RAYu).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridRes_RAYu;
        private Label Task;
        private TextBox Matrix;
        private Button GoButton_RAYu;
        private Button HelpButton_RAYu;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn d;
        private DataGridViewTextBoxColumn e;
    }
}
