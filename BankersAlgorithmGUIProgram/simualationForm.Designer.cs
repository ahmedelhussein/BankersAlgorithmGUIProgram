namespace BankersAlgorithmGUIProgram
{
    partial class simualationForm
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
            remainingNeedGridView = new DataGridView();
            remainingNeedLabel = new Label();
            simulatorFormTitle = new Label();
            availableResourcesGridView = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            currentAllocationGridView = new DataGridView();
            enterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)remainingNeedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableResourcesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentAllocationGridView).BeginInit();
            SuspendLayout();
            // 
            // remainingNeedGridView
            // 
            remainingNeedGridView.AllowUserToAddRows = false;
            remainingNeedGridView.AllowUserToDeleteRows = false;
            remainingNeedGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            remainingNeedGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            remainingNeedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            remainingNeedGridView.Location = new Point(292, 364);
            remainingNeedGridView.Name = "remainingNeedGridView";
            remainingNeedGridView.ReadOnly = true;
            remainingNeedGridView.Size = new Size(399, 196);
            remainingNeedGridView.TabIndex = 7;
            // 
            // remainingNeedLabel
            // 
            remainingNeedLabel.AutoSize = true;
            remainingNeedLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            remainingNeedLabel.Location = new Point(417, 336);
            remainingNeedLabel.Name = "remainingNeedLabel";
            remainingNeedLabel.Size = new Size(154, 25);
            remainingNeedLabel.TabIndex = 6;
            remainingNeedLabel.Text = "Remaining Need";
            // 
            // simulatorFormTitle
            // 
            simulatorFormTitle.Dock = DockStyle.Top;
            simulatorFormTitle.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            simulatorFormTitle.Location = new Point(0, 0);
            simulatorFormTitle.Name = "simulatorFormTitle";
            simulatorFormTitle.Size = new Size(984, 81);
            simulatorFormTitle.TabIndex = 5;
            simulatorFormTitle.Text = "Banker's Algorithm Simulation";
            simulatorFormTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // availableResourcesGridView
            // 
            availableResourcesGridView.AllowUserToAddRows = false;
            availableResourcesGridView.AllowUserToDeleteRows = false;
            availableResourcesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            availableResourcesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            availableResourcesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableResourcesGridView.Location = new Point(38, 120);
            availableResourcesGridView.Name = "availableResourcesGridView";
            availableResourcesGridView.ReadOnly = true;
            availableResourcesGridView.Size = new Size(399, 196);
            availableResourcesGridView.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(127, 92);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 10;
            label4.Text = "Available Resources";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(653, 92);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 13;
            label2.Text = "Current Allocation";
            // 
            // currentAllocationGridView
            // 
            currentAllocationGridView.AllowUserToAddRows = false;
            currentAllocationGridView.AllowUserToDeleteRows = false;
            currentAllocationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            currentAllocationGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            currentAllocationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentAllocationGridView.Location = new Point(542, 120);
            currentAllocationGridView.Name = "currentAllocationGridView";
            currentAllocationGridView.ReadOnly = true;
            currentAllocationGridView.Size = new Size(399, 196);
            currentAllocationGridView.TabIndex = 12;
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            enterButton.Location = new Point(738, 469);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(178, 91);
            enterButton.TabIndex = 14;
            enterButton.Text = "START SIMULATION";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // simualationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 624);
            Controls.Add(enterButton);
            Controls.Add(label2);
            Controls.Add(currentAllocationGridView);
            Controls.Add(availableResourcesGridView);
            Controls.Add(label4);
            Controls.Add(remainingNeedGridView);
            Controls.Add(remainingNeedLabel);
            Controls.Add(simulatorFormTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "simualationForm";
            Text = "Banker's Algorithm Simulator";
            ((System.ComponentModel.ISupportInitialize)remainingNeedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableResourcesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentAllocationGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView remainingNeedGridView;
        private Label remainingNeedLabel;
        private Label simulatorFormTitle;
        private DataGridView availableResourcesGridView;
        private Label label4;
        private Label label2;
        private DataGridView currentAllocationGridView;
        private Button enterButton;
    }
}