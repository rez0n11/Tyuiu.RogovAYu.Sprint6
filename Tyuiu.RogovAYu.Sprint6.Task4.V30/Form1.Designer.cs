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
            panelTop = new Panel();
            panelLeft = new Panel();
            panelFIll = new Panel();
            GoButton = new Button();
            Helpbutton = new Button();
            SaveButton = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            LabelStart = new Label();
            LabelStop = new Label();
            pictureBox1 = new PictureBox();
            LabelTask = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelTop.Size = new Size(1129, 168);
            panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 168);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 594);
            panelLeft.TabIndex = 1;
            // 
            // panelFIll
            // 
            panelFIll.Dock = DockStyle.Fill;
            panelFIll.Location = new Point(250, 168);
            panelFIll.Name = "panelFIll";
            panelFIll.Size = new Size(879, 594);
            panelFIll.TabIndex = 2;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(942, 51);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 0;
            GoButton.Text = "Выполнить";
            GoButton.UseVisualStyleBackColor = true;
            // 
            // Helpbutton
            // 
            Helpbutton.Location = new Point(934, 88);
            Helpbutton.Name = "Helpbutton";
            Helpbutton.Size = new Size(94, 29);
            Helpbutton.TabIndex = 1;
            Helpbutton.Text = "?";
            Helpbutton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(950, 126);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(573, 45);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(573, 88);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 4;
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
            // LabelTask
            // 
            LabelTask.AutoSize = true;
            LabelTask.Location = new Point(36, 28);
            LabelTask.Name = "LabelTask";
            LabelTask.Size = new Size(50, 20);
            LabelTask.TabIndex = 8;
            LabelTask.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 762);
            Controls.Add(panelFIll);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
