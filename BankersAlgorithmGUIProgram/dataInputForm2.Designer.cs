namespace BankersAlgorithmGUIProgram
{
    partial class dataInputForm2
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
            currentAllocationGridView = new DataGridView();
            dataEntryFormTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            maxNeedGridView = new DataGridView();
            label3 = new Label();
            totalResourcesGridView = new DataGridView();
            availableResourcesGridView = new DataGridView();
            label4 = new Label();
            enterButton = new Button();
            processesComboBox = new ComboBox();
            processPrompt = new Label();
            label6 = new Label();
            resourcesRequestedGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)currentAllocationGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxNeedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalResourcesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableResourcesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resourcesRequestedGridView).BeginInit();
            SuspendLayout();
            // 
            // currentAllocationGridView
            // 
            currentAllocationGridView.AllowUserToAddRows = false;
            currentAllocationGridView.AllowUserToDeleteRows = false;
            currentAllocationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            currentAllocationGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            currentAllocationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentAllocationGridView.Location = new Point(361, 131);
            currentAllocationGridView.Name = "currentAllocationGridView";
            currentAllocationGridView.Size = new Size(317, 196);
            currentAllocationGridView.TabIndex = 0;
            // 
            // dataEntryFormTitle
            // 
            dataEntryFormTitle.Dock = DockStyle.Top;
            dataEntryFormTitle.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            dataEntryFormTitle.Location = new Point(0, 0);
            dataEntryFormTitle.Name = "dataEntryFormTitle";
            dataEntryFormTitle.Size = new Size(1028, 81);
            dataEntryFormTitle.TabIndex = 2;
            dataEntryFormTitle.Text = "Processes and Resources Data Entry Form";
            dataEntryFormTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 103);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Maximum Need";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(444, 103);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 5;
            label2.Text = "Current Allocation";
            // 
            // maxNeedGridView
            // 
            maxNeedGridView.AllowUserToAddRows = false;
            maxNeedGridView.AllowUserToDeleteRows = false;
            maxNeedGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            maxNeedGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            maxNeedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            maxNeedGridView.Location = new Point(12, 131);
            maxNeedGridView.Name = "maxNeedGridView";
            maxNeedGridView.Size = new Size(317, 196);
            maxNeedGridView.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(767, 103);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 7;
            label3.Text = "Total Resources";
            // 
            // totalResourcesGridView
            // 
            totalResourcesGridView.AllowUserToAddRows = false;
            totalResourcesGridView.AllowUserToDeleteRows = false;
            totalResourcesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            totalResourcesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            totalResourcesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalResourcesGridView.Location = new Point(699, 131);
            totalResourcesGridView.Name = "totalResourcesGridView";
            totalResourcesGridView.Size = new Size(317, 196);
            totalResourcesGridView.TabIndex = 6;
            // 
            // availableResourcesGridView
            // 
            availableResourcesGridView.AllowUserToAddRows = false;
            availableResourcesGridView.AllowUserToDeleteRows = false;
            availableResourcesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            availableResourcesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            availableResourcesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableResourcesGridView.Location = new Point(12, 366);
            availableResourcesGridView.Name = "availableResourcesGridView";
            availableResourcesGridView.Size = new Size(317, 196);
            availableResourcesGridView.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(95, 338);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 8;
            label4.Text = "Available Resources";
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            enterButton.Location = new Point(794, 532);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(178, 91);
            enterButton.TabIndex = 10;
            enterButton.Text = "NEXT";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // processesComboBox
            // 
            processesComboBox.FormattingEnabled = true;
            processesComboBox.Location = new Point(789, 470);
            processesComboBox.Name = "processesComboBox";
            processesComboBox.Size = new Size(121, 23);
            processesComboBox.TabIndex = 11;
            // 
            // processPrompt
            // 
            processPrompt.AutoSize = true;
            processPrompt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            processPrompt.Location = new Point(730, 442);
            processPrompt.Name = "processPrompt";
            processPrompt.Size = new Size(258, 25);
            processPrompt.TabIndex = 12;
            processPrompt.Text = "Process requesting resources";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(380, 338);
            label6.Name = "label6";
            label6.Size = new Size(286, 25);
            label6.TabIndex = 14;
            label6.Text = "Resources Requested by Process";
            // 
            // resourcesRequestedGridView
            // 
            resourcesRequestedGridView.AllowUserToAddRows = false;
            resourcesRequestedGridView.AllowUserToDeleteRows = false;
            resourcesRequestedGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            resourcesRequestedGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resourcesRequestedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resourcesRequestedGridView.Location = new Point(361, 366);
            resourcesRequestedGridView.Name = "resourcesRequestedGridView";
            resourcesRequestedGridView.Size = new Size(317, 196);
            resourcesRequestedGridView.TabIndex = 15;
            // 
            // dataInputForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 659);
            Controls.Add(resourcesRequestedGridView);
            Controls.Add(label6);
            Controls.Add(processPrompt);
            Controls.Add(processesComboBox);
            Controls.Add(enterButton);
            Controls.Add(availableResourcesGridView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(totalResourcesGridView);
            Controls.Add(label2);
            Controls.Add(maxNeedGridView);
            Controls.Add(label1);
            Controls.Add(dataEntryFormTitle);
            Controls.Add(currentAllocationGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "dataInputForm2";
            Text = "Data Input Form 2";
            ((System.ComponentModel.ISupportInitialize)currentAllocationGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxNeedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalResourcesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableResourcesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)resourcesRequestedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView currentAllocationGridView;
        private Label dataEntryFormTitle;
        private Label label1;
        private Label label2;
        private DataGridView maxNeedGridView;
        private Label label3;
        private DataGridView totalResourcesGridView;
        private DataGridView availableResourcesGridView;
        private Label label4;
        private Button enterButton;
        private ComboBox processesComboBox;
        private Label processPrompt;
        private Label label6;
        private DataGridView resourcesRequestedGridView;
    }
}