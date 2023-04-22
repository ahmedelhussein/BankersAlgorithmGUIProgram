namespace BankersAlgorithmGUIProgram
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
            programTitle = new Label();
            startButton = new Button();
            SuspendLayout();
            // 
            // programTitle
            // 
            programTitle.Dock = DockStyle.Top;
            programTitle.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            programTitle.Location = new Point(0, 0);
            programTitle.Name = "programTitle";
            programTitle.Size = new Size(799, 81);
            programTitle.TabIndex = 0;
            programTitle.Text = "Banker's Algorithm Simulator";
            programTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.None;
            startButton.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(229, 203);
            startButton.Name = "startButton";
            startButton.Size = new Size(326, 77);
            startButton.TabIndex = 1;
            startButton.Text = "CLICK HERE TO START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(799, 450);
            Controls.Add(startButton);
            Controls.Add(programTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Banker's Algorithm Simulator";
            ResumeLayout(false);
        }

        #endregion

        private Label programTitle;
        private Button startButton;
    }
}