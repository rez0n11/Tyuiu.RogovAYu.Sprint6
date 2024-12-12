namespace Tyuiu.RogovAYu.Sprint6.Task2.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            GroupInput_RAYu = new GroupBox();
            HelpButton_RAYu = new Button();
            GoButton_RAYu = new Button();
            label2 = new Label();
            label1 = new Label();
            TextStop_RAYu = new TextBox();
            TextStart_RAYu = new TextBox();
            GroupTask_RAYu = new GroupBox();
            TaskPic_RAYu = new PictureBox();
            GroupOut_RAYu = new GroupBox();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            GroupInput_RAYu.SuspendLayout();
            GroupTask_RAYu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskPic_RAYu).BeginInit();
            GroupOut_RAYu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GroupInput_RAYu
            // 
            GroupInput_RAYu.Controls.Add(HelpButton_RAYu);
            GroupInput_RAYu.Controls.Add(GoButton_RAYu);
            GroupInput_RAYu.Controls.Add(label2);
            GroupInput_RAYu.Controls.Add(label1);
            GroupInput_RAYu.Controls.Add(TextStop_RAYu);
            GroupInput_RAYu.Controls.Add(TextStart_RAYu);
            GroupInput_RAYu.Location = new Point(12, 313);
            GroupInput_RAYu.Name = "GroupInput_RAYu";
            GroupInput_RAYu.Size = new Size(646, 125);
            GroupInput_RAYu.TabIndex = 0;
            GroupInput_RAYu.TabStop = false;
            GroupInput_RAYu.Text = "Ввод";
            // 
            // HelpButton_RAYu
            // 
            HelpButton_RAYu.Location = new Point(387, 57);
            HelpButton_RAYu.Name = "HelpButton_RAYu";
            HelpButton_RAYu.Size = new Size(41, 29);
            HelpButton_RAYu.TabIndex = 5;
            HelpButton_RAYu.Text = "?";
            HelpButton_RAYu.UseVisualStyleBackColor = true;
            HelpButton_RAYu.Click += HelpButton_RAYu_Click;
            // 
            // GoButton_RAYu
            // 
            GoButton_RAYu.Location = new Point(434, 57);
            GoButton_RAYu.Name = "GoButton_RAYu";
            GoButton_RAYu.Size = new Size(136, 29);
            GoButton_RAYu.TabIndex = 4;
            GoButton_RAYu.Text = "Выполнить";
            GoButton_RAYu.UseVisualStyleBackColor = true;
            GoButton_RAYu.Click += GoButton_RAYu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 92);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 48);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Начало";
            // 
            // TextStop_RAYu
            // 
            TextStop_RAYu.Location = new Point(140, 92);
            TextStop_RAYu.Name = "TextStop_RAYu";
            TextStop_RAYu.Size = new Size(125, 27);
            TextStop_RAYu.TabIndex = 1;
            TextStop_RAYu.TextAlign = HorizontalAlignment.Center;
            // 
            // TextStart_RAYu
            // 
            TextStart_RAYu.Location = new Point(140, 41);
            TextStart_RAYu.Name = "TextStart_RAYu";
            TextStart_RAYu.Size = new Size(125, 27);
            TextStart_RAYu.TabIndex = 0;
            TextStart_RAYu.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupTask_RAYu
            // 
            GroupTask_RAYu.Controls.Add(TaskPic_RAYu);
            GroupTask_RAYu.Location = new Point(13, 23);
            GroupTask_RAYu.Name = "GroupTask_RAYu";
            GroupTask_RAYu.Size = new Size(712, 271);
            GroupTask_RAYu.TabIndex = 1;
            GroupTask_RAYu.TabStop = false;
            GroupTask_RAYu.Text = "Условие";
            // 
            // TaskPic_RAYu
            // 
            TaskPic_RAYu.Image = (Image)resources.GetObject("TaskPic_RAYu.Image");
            TaskPic_RAYu.Location = new Point(12, 38);
            TaskPic_RAYu.Name = "TaskPic_RAYu";
            TaskPic_RAYu.Size = new Size(633, 228);
            TaskPic_RAYu.TabIndex = 0;
            TaskPic_RAYu.TabStop = false;
            // 
            // GroupOut_RAYu
            // 
            GroupOut_RAYu.Controls.Add(dataGridView1);
            GroupOut_RAYu.Location = new Point(725, 23);
            GroupOut_RAYu.Name = "GroupOut_RAYu";
            GroupOut_RAYu.Size = new Size(185, 415);
            GroupOut_RAYu.TabIndex = 2;
            GroupOut_RAYu.TabStop = false;
            GroupOut_RAYu.Text = "Вывод";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(185, 389);
            dataGridView1.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 75;
            // 
            // FX
            // 
            FX.HeaderText = "F(x)";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(GroupOut_RAYu);
            Controls.Add(GroupTask_RAYu);
            Controls.Add(GroupInput_RAYu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "6.2.10";
            GroupInput_RAYu.ResumeLayout(false);
            GroupInput_RAYu.PerformLayout();
            GroupTask_RAYu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TaskPic_RAYu).EndInit();
            GroupOut_RAYu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupInput_RAYu;
        private GroupBox GroupTask_RAYu;
        private GroupBox GroupOut_RAYu;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox TextStop_RAYu;
        private TextBox TextStart_RAYu;
        private PictureBox TaskPic_RAYu;
        private Button GoButton_RAYu;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private Button HelpButton_RAYu;
    }
}
