namespace Tyuiu.RogovAYu.Sprint6.Task6.V14
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
            panel1 = new Panel();
            HelpButton = new Button();
            FIleButton = new Button();
            panel2 = new Panel();
            textBoxInput = new TextBox();
            panel3 = new Panel();
            textBoxOutput = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            buttonGo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGo);
            panel1.Controls.Add(HelpButton);
            panel1.Controls.Add(FIleButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1469, 125);
            panel1.TabIndex = 0;
            // 
            // HelpButton
            // 
            HelpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HelpButton.Image = (Image)resources.GetObject("HelpButton.Image");
            HelpButton.Location = new Point(1362, 23);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(72, 72);
            HelpButton.TabIndex = 1;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // FIleButton
            // 
            FIleButton.Image = (Image)resources.GetObject("FIleButton.Image");
            FIleButton.Location = new Point(21, 14);
            FIleButton.Name = "FIleButton";
            FIleButton.Size = new Size(90, 90);
            FIleButton.TabIndex = 0;
            FIleButton.UseVisualStyleBackColor = true;
            FIleButton.Click += FIleButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxInput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 589);
            panel2.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.ActiveCaption;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.Size = new Size(734, 589);
            textBoxInput.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxOutput);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(734, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(735, 589);
            panel3.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.ActiveCaption;
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(0, 0);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(735, 589);
            textBoxOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialog1_FileOk;
            // 
            // buttonGo
            // 
            buttonGo.Image = (Image)resources.GetObject("buttonGo.Image");
            buttonGo.Location = new Point(117, 14);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(86, 88);
            buttonGo.TabIndex = 2;
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 714);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6.7.27";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button HelpButton;
        private Button FIleButton;
        private Panel panel2;
        private TextBox textBoxInput;
        private Panel panel3;
        private TextBox textBoxOutput;
        private OpenFileDialog openFileDialogTask;
        private Button buttonGo;
    }
}
