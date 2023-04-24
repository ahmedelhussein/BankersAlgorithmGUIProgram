namespace BankersAlgorithmGUIProgram
{
    partial class dataInputForm
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
            programTitle = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            nextButton = new Button();
            SuspendLayout();
            // 
            // programTitle
            // 
            programTitle.Dock = DockStyle.Top;
            programTitle.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            programTitle.Location = new Point(0, 0);
            programTitle.Name = "programTitle";
            programTitle.Size = new Size(944, 81);
            programTitle.TabIndex = 1;
            programTitle.Text = "Data Input Form";
            programTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 137);
            label1.Name = "label1";
            label1.Size = new Size(363, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter the number of processes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(115, 218);
            label2.Name = "label2";
            label2.Size = new Size(362, 32);
            label2.TabIndex = 4;
            label2.Text = "Enter the number of resources";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(537, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 5;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.Location = new Point(593, 288);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(113, 57);
            nextButton.TabIndex = 6;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // dataInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 405);
            Controls.Add(nextButton);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(programTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "dataInputForm";
            Text = "Data Input Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label programTitle;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button nextButton;
    }
}