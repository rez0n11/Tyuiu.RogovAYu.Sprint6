namespace Tyuiu.RogovAYu.Sprint6.Task1.V30
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
            GroupTask = new GroupBox();
            TaskPic = new PictureBox();
            LabelTask = new Label();
            GroupInput_RAYu = new GroupBox();
            LabelStop_RAYu = new Label();
            LabelStart_RaYu = new Label();
            TextStop_RAYu = new TextBox();
            TextStart_RAYu = new TextBox();
            GroupOut_RAYu = new GroupBox();
            HelpButton_RAYu = new Button();
            GoButton_RAYu = new Button();
            TextOut_RAYu = new TextBox();
            GroupTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskPic).BeginInit();
            GroupInput_RAYu.SuspendLayout();
            GroupOut_RAYu.SuspendLayout();
            SuspendLayout();
            // 
            // GroupTask
            // 
            GroupTask.Controls.Add(TaskPic);
            GroupTask.Controls.Add(LabelTask);
            GroupTask.Location = new Point(11, 2);
            GroupTask.Name = "GroupTask";
            GroupTask.Size = new Size(449, 194);
            GroupTask.TabIndex = 0;
            GroupTask.TabStop = false;
            GroupTask.Text = "groupBox1";
            // 
            // TaskPic
            // 
            TaskPic.Image = (Image)resources.GetObject("TaskPic.Image");
            TaskPic.Location = new Point(15, 87);
            TaskPic.Name = "TaskPic";
            TaskPic.Size = new Size(391, 62);
            TaskPic.TabIndex = 1;
            TaskPic.TabStop = false;
            // 
            // LabelTask
            // 
            LabelTask.AutoSize = true;
            LabelTask.Location = new Point(15, 24);
            LabelTask.Name = "LabelTask";
            LabelTask.Size = new Size(262, 20);
            LabelTask.TabIndex = 0;
            LabelTask.Text = "Вывести таблицу значений функции";
            // 
            // GroupInput_RAYu
            // 
            GroupInput_RAYu.Controls.Add(LabelStop_RAYu);
            GroupInput_RAYu.Controls.Add(LabelStart_RaYu);
            GroupInput_RAYu.Controls.Add(TextStop_RAYu);
            GroupInput_RAYu.Controls.Add(TextStart_RAYu);
            GroupInput_RAYu.Location = new Point(11, 244);
            GroupInput_RAYu.Name = "GroupInput_RAYu";
            GroupInput_RAYu.Size = new Size(449, 194);
            GroupInput_RAYu.TabIndex = 1;
            GroupInput_RAYu.TabStop = false;
            GroupInput_RAYu.Text = "groupBox1";
            // 
            // LabelStop_RAYu
            // 
            LabelStop_RAYu.AutoSize = true;
            LabelStop_RAYu.Location = new Point(196, 137);
            LabelStop_RAYu.Name = "LabelStop_RAYu";
            LabelStop_RAYu.Size = new Size(28, 20);
            LabelStop_RAYu.TabIndex = 4;
            LabelStop_RAYu.Text = "До";
            // 
            // LabelStart_RaYu
            // 
            LabelStart_RaYu.AutoSize = true;
            LabelStart_RaYu.Location = new Point(198, 65);
            LabelStart_RaYu.Name = "LabelStart_RaYu";
            LabelStart_RaYu.Size = new Size(26, 20);
            LabelStart_RaYu.TabIndex = 3;
            LabelStart_RaYu.Text = "От";
            LabelStart_RaYu.Click += LabelStart_RaYu_Click;
            // 
            // TextStop_RAYu
            // 
            TextStop_RAYu.Location = new Point(249, 134);
            TextStop_RAYu.Name = "TextStop_RAYu";
            TextStop_RAYu.ScrollBars = ScrollBars.Both;
            TextStop_RAYu.Size = new Size(125, 27);
            TextStop_RAYu.TabIndex = 2;
            // 
            // TextStart_RAYu
            // 
            TextStart_RAYu.Location = new Point(249, 62);
            TextStart_RAYu.Name = "TextStart_RAYu";
            TextStart_RAYu.ScrollBars = ScrollBars.Both;
            TextStart_RAYu.Size = new Size(125, 27);
            TextStart_RAYu.TabIndex = 1;
            // 
            // GroupOut_RAYu
            // 
            GroupOut_RAYu.Controls.Add(HelpButton_RAYu);
            GroupOut_RAYu.Controls.Add(GoButton_RAYu);
            GroupOut_RAYu.Controls.Add(TextOut_RAYu);
            GroupOut_RAYu.Location = new Point(524, 12);
            GroupOut_RAYu.Name = "GroupOut_RAYu";
            GroupOut_RAYu.Size = new Size(250, 426);
            GroupOut_RAYu.TabIndex = 2;
            GroupOut_RAYu.TabStop = false;
            GroupOut_RAYu.Text = "groupBox1";
            // 
            // HelpButton_RAYu
            // 
            HelpButton_RAYu.Location = new Point(0, 366);
            HelpButton_RAYu.Name = "HelpButton_RAYu";
            HelpButton_RAYu.Size = new Size(44, 60);
            HelpButton_RAYu.TabIndex = 2;
            HelpButton_RAYu.Text = "?";
            HelpButton_RAYu.UseVisualStyleBackColor = true;
            // 
            // GoButton_RAYu
            // 
            GoButton_RAYu.Location = new Point(50, 366);
            GoButton_RAYu.Name = "GoButton_RAYu";
            GoButton_RAYu.Size = new Size(194, 60);
            GoButton_RAYu.TabIndex = 1;
            GoButton_RAYu.Text = "Выполнить!";
            GoButton_RAYu.UseVisualStyleBackColor = true;
            GoButton_RAYu.Click += GoButton_RAYu_Click;
            // 
            // TextOut_RAYu
            // 
            TextOut_RAYu.Location = new Point(0, 26);
            TextOut_RAYu.Multiline = true;
            TextOut_RAYu.Name = "TextOut_RAYu";
            TextOut_RAYu.ReadOnly = true;
            TextOut_RAYu.Size = new Size(244, 343);
            TextOut_RAYu.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GroupOut_RAYu);
            Controls.Add(GroupInput_RAYu);
            Controls.Add(GroupTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "6.1.30";
            GroupTask.ResumeLayout(false);
            GroupTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaskPic).EndInit();
            GroupInput_RAYu.ResumeLayout(false);
            GroupInput_RAYu.PerformLayout();
            GroupOut_RAYu.ResumeLayout(false);
            GroupOut_RAYu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupTask;
        private Label LabelTask;
        private GroupBox GroupInput_RAYu;
        private TextBox TextStop_RAYu;
        private TextBox TextStart_RAYu;
        private GroupBox GroupOut_RAYu;
        private Label LabelStop_RAYu;
        private Label LabelStart_RaYu;
        private TextBox TextOut_RAYu;
        private PictureBox TaskPic;
        private Button HelpButton_RAYu;
        private Button GoButton_RAYu;
    }
}
