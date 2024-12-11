namespace Tyuiu.RogovAYu.Sprint6.Task0.V6
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
            GroupTask_RAYu = new GroupBox();
            pictureBox1 = new PictureBox();
            LabelTask_RAYu = new Label();
            GroupInput_RAYu = new GroupBox();
            LabelInput_RAYu = new Label();
            TextIn_RAYu = new TextBox();
            GroupOutput_RAYu = new GroupBox();
            TextOut_RAYu = new TextBox();
            LabelOutput_RAYu = new Label();
            ButtonDo_RAYu = new Button();
            ButtonHelp_RAYu = new Button();
            GroupTask_RAYu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GroupInput_RAYu.SuspendLayout();
            GroupOutput_RAYu.SuspendLayout();
            SuspendLayout();
            // 
            // GroupTask_RAYu
            // 
            GroupTask_RAYu.Controls.Add(pictureBox1);
            GroupTask_RAYu.Controls.Add(LabelTask_RAYu);
            GroupTask_RAYu.Location = new Point(23, 12);
            GroupTask_RAYu.Name = "GroupTask_RAYu";
            GroupTask_RAYu.Size = new Size(720, 217);
            GroupTask_RAYu.TabIndex = 0;
            GroupTask_RAYu.TabStop = false;
            GroupTask_RAYu.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(576, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 63);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LabelTask_RAYu
            // 
            LabelTask_RAYu.AutoSize = true;
            LabelTask_RAYu.Location = new Point(6, 26);
            LabelTask_RAYu.Name = "LabelTask_RAYu";
            LabelTask_RAYu.Size = new Size(242, 20);
            LabelTask_RAYu.TabIndex = 0;
            LabelTask_RAYu.Text = "Вычислить значение по формуле";
            // 
            // GroupInput_RAYu
            // 
            GroupInput_RAYu.Controls.Add(LabelInput_RAYu);
            GroupInput_RAYu.Controls.Add(TextIn_RAYu);
            GroupInput_RAYu.Location = new Point(23, 273);
            GroupInput_RAYu.Name = "GroupInput_RAYu";
            GroupInput_RAYu.Size = new Size(380, 90);
            GroupInput_RAYu.TabIndex = 1;
            GroupInput_RAYu.TabStop = false;
            GroupInput_RAYu.Text = "Ввод";
            // 
            // LabelInput_RAYu
            // 
            LabelInput_RAYu.AutoSize = true;
            LabelInput_RAYu.Font = new Font("Segoe UI", 12F);
            LabelInput_RAYu.Location = new Point(105, 31);
            LabelInput_RAYu.Name = "LabelInput_RAYu";
            LabelInput_RAYu.Size = new Size(48, 28);
            LabelInput_RAYu.TabIndex = 1;
            LabelInput_RAYu.Text = "X = ";
            // 
            // TextIn_RAYu
            // 
            TextIn_RAYu.Location = new Point(146, 35);
            TextIn_RAYu.Name = "TextIn_RAYu";
            TextIn_RAYu.Size = new Size(125, 27);
            TextIn_RAYu.TabIndex = 0;
            TextIn_RAYu.Text = "123";
            TextIn_RAYu.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupOutput_RAYu
            // 
            GroupOutput_RAYu.Controls.Add(TextOut_RAYu);
            GroupOutput_RAYu.Controls.Add(LabelOutput_RAYu);
            GroupOutput_RAYu.Location = new Point(409, 273);
            GroupOutput_RAYu.Name = "GroupOutput_RAYu";
            GroupOutput_RAYu.Size = new Size(334, 90);
            GroupOutput_RAYu.TabIndex = 2;
            GroupOutput_RAYu.TabStop = false;
            GroupOutput_RAYu.Text = "Вывод";
            // 
            // TextOut_RAYu
            // 
            TextOut_RAYu.Location = new Point(106, 35);
            TextOut_RAYu.Name = "TextOut_RAYu";
            TextOut_RAYu.ReadOnly = true;
            TextOut_RAYu.Size = new Size(125, 27);
            TextOut_RAYu.TabIndex = 1;
            TextOut_RAYu.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelOutput_RAYu
            // 
            LabelOutput_RAYu.AutoSize = true;
            LabelOutput_RAYu.Location = new Point(120, 12);
            LabelOutput_RAYu.Name = "LabelOutput_RAYu";
            LabelOutput_RAYu.Size = new Size(78, 20);
            LabelOutput_RAYu.TabIndex = 0;
            LabelOutput_RAYu.Text = "Результат:";
            // 
            // ButtonDo_RAYu
            // 
            ButtonDo_RAYu.Location = new Point(623, 392);
            ButtonDo_RAYu.Name = "ButtonDo_RAYu";
            ButtonDo_RAYu.Size = new Size(108, 29);
            ButtonDo_RAYu.TabIndex = 0;
            ButtonDo_RAYu.Text = "Выполнить";
            ButtonDo_RAYu.UseVisualStyleBackColor = true;
            ButtonDo_RAYu.Click += ButtonDo_RAYu_Click;
            // 
            // ButtonHelp_RAYu
            // 
            ButtonHelp_RAYu.FlatStyle = FlatStyle.Flat;
            ButtonHelp_RAYu.Location = new Point(599, 392);
            ButtonHelp_RAYu.Name = "ButtonHelp_RAYu";
            ButtonHelp_RAYu.Size = new Size(30, 29);
            ButtonHelp_RAYu.TabIndex = 3;
            ButtonHelp_RAYu.Text = "?";
            ButtonHelp_RAYu.UseVisualStyleBackColor = true;
            ButtonHelp_RAYu.Click += ButtonHelp_RAYu_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonHelp_RAYu);
            Controls.Add(ButtonDo_RAYu);
            Controls.Add(GroupOutput_RAYu);
            Controls.Add(GroupInput_RAYu);
            Controls.Add(GroupTask_RAYu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6.0.6 | Рогов А.Ю";
            GroupTask_RAYu.ResumeLayout(false);
            GroupTask_RAYu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GroupInput_RAYu.ResumeLayout(false);
            GroupInput_RAYu.PerformLayout();
            GroupOutput_RAYu.ResumeLayout(false);
            GroupOutput_RAYu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupTask_RAYu;
        private GroupBox GroupInput_RAYu;
        private TextBox TextIn_RAYu;
        private GroupBox GroupOutput_RAYu;
        private Button ButtonDo_RAYu;
        private Button ButtonHelp_RAYu;
        private Label LabelInput_RAYu;
        private PictureBox pictureBox1;
        private Label LabelTask_RAYu;
        private Label LabelOutput_RAYu;
        private TextBox TextOut_RAYu;
    }
}
