namespace MultiQueueSimulation
{
    partial class Form1
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
			this.stoppingCriteriaLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serverProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serviceTimeDistributionDataTable = new System.Windows.Forms.DataGridView();
			this.simulateButton = new System.Windows.Forms.Button();
			this.stoppingNumberTextBox = new System.Windows.Forms.TextBox();
			this.numberOfServersTextBox = new System.Windows.Forms.TextBox();
			this.serverServiceTimeDistributionLabel = new System.Windows.Forms.Label();
			this.selectionMethodLabel = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.serversLabel = new System.Windows.Forms.Label();
			this.selectionMethodTextBox = new System.Windows.Forms.TextBox();
			this.stoppingCriteriaTextBox = new System.Windows.Forms.TextBox();
			this.numberOfServersLabel = new System.Windows.Forms.Label();
			this.serverComboBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.stoppingNumberLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.serviceTimeDistributionDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// stoppingCriteriaLabel
			// 
			this.stoppingCriteriaLabel.AutoSize = true;
			this.stoppingCriteriaLabel.Location = new System.Drawing.Point(376, 269);
			this.stoppingCriteriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stoppingCriteriaLabel.Name = "stoppingCriteriaLabel";
			this.stoppingCriteriaLabel.Size = new System.Drawing.Size(106, 16);
			this.stoppingCriteriaLabel.TabIndex = 11;
			this.stoppingCriteriaLabel.Text = "Stopping Criteria";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1375, 30);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "MaxRange";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "MinRange";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Comulitave Probablity";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// serverProbabilityColumn
			// 
			this.serverProbabilityColumn.HeaderText = "Probability";
			this.serverProbabilityColumn.MinimumWidth = 6;
			this.serverProbabilityColumn.Name = "serverProbabilityColumn";
			this.serverProbabilityColumn.ReadOnly = true;
			this.serverProbabilityColumn.Width = 125;
			// 
			// serviceTimeColumn
			// 
			this.serviceTimeColumn.HeaderText = "Service Time";
			this.serviceTimeColumn.MinimumWidth = 6;
			this.serviceTimeColumn.Name = "serviceTimeColumn";
			this.serviceTimeColumn.ReadOnly = true;
			this.serviceTimeColumn.Width = 125;
			// 
			// serviceTimeDistributionDataTable
			// 
			this.serviceTimeDistributionDataTable.AllowUserToAddRows = false;
			this.serviceTimeDistributionDataTable.AllowUserToDeleteRows = false;
			this.serviceTimeDistributionDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.serviceTimeDistributionDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTimeColumn,
            this.serverProbabilityColumn,
            this.Column1,
            this.Column2,
            this.Column3});
			this.serviceTimeDistributionDataTable.Location = new System.Drawing.Point(601, 72);
			this.serviceTimeDistributionDataTable.Margin = new System.Windows.Forms.Padding(4);
			this.serviceTimeDistributionDataTable.Name = "serviceTimeDistributionDataTable";
			this.serviceTimeDistributionDataTable.ReadOnly = true;
			this.serviceTimeDistributionDataTable.RowHeadersWidth = 51;
			this.serviceTimeDistributionDataTable.Size = new System.Drawing.Size(689, 310);
			this.serviceTimeDistributionDataTable.TabIndex = 17;
			this.serviceTimeDistributionDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceTimeDistributionDataTable_CellContentClick);
			// 
			// simulateButton
			// 
			this.simulateButton.Location = new System.Drawing.Point(159, 344);
			this.simulateButton.Margin = new System.Windows.Forms.Padding(4);
			this.simulateButton.Name = "simulateButton";
			this.simulateButton.Size = new System.Drawing.Size(100, 52);
			this.simulateButton.TabIndex = 21;
			this.simulateButton.Text = "Simulate";
			this.simulateButton.UseVisualStyleBackColor = true;
			this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
			// 
			// stoppingNumberTextBox
			// 
			this.stoppingNumberTextBox.Location = new System.Drawing.Point(361, 208);
			this.stoppingNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.stoppingNumberTextBox.Name = "stoppingNumberTextBox";
			this.stoppingNumberTextBox.ReadOnly = true;
			this.stoppingNumberTextBox.Size = new System.Drawing.Size(144, 22);
			this.stoppingNumberTextBox.TabIndex = 14;
			// 
			// numberOfServersTextBox
			// 
			this.numberOfServersTextBox.Location = new System.Drawing.Point(361, 100);
			this.numberOfServersTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.numberOfServersTextBox.Name = "numberOfServersTextBox";
			this.numberOfServersTextBox.ReadOnly = true;
			this.numberOfServersTextBox.Size = new System.Drawing.Size(144, 22);
			this.numberOfServersTextBox.TabIndex = 13;
			// 
			// serverServiceTimeDistributionLabel
			// 
			this.serverServiceTimeDistributionLabel.AutoSize = true;
			this.serverServiceTimeDistributionLabel.Location = new System.Drawing.Point(679, 46);
			this.serverServiceTimeDistributionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.serverServiceTimeDistributionLabel.Name = "serverServiceTimeDistributionLabel";
			this.serverServiceTimeDistributionLabel.Size = new System.Drawing.Size(199, 16);
			this.serverServiceTimeDistributionLabel.TabIndex = 19;
			this.serverServiceTimeDistributionLabel.Text = "Server Service Time Distribution";
			// 
			// selectionMethodLabel
			// 
			this.selectionMethodLabel.AutoSize = true;
			this.selectionMethodLabel.Location = new System.Drawing.Point(380, 363);
			this.selectionMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.selectionMethodLabel.Name = "selectionMethodLabel";
			this.selectionMethodLabel.Size = new System.Drawing.Size(111, 16);
			this.selectionMethodLabel.TabIndex = 12;
			this.selectionMethodLabel.Text = "Selection Method";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(34, 27);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(260, 292);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// serversLabel
			// 
			this.serversLabel.AutoSize = true;
			this.serversLabel.Location = new System.Drawing.Point(940, 397);
			this.serversLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.serversLabel.Name = "serversLabel";
			this.serversLabel.Size = new System.Drawing.Size(47, 16);
			this.serversLabel.TabIndex = 18;
			this.serversLabel.Text = "Server";
			// 
			// selectionMethodTextBox
			// 
			this.selectionMethodTextBox.Location = new System.Drawing.Point(361, 391);
			this.selectionMethodTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.selectionMethodTextBox.Name = "selectionMethodTextBox";
			this.selectionMethodTextBox.ReadOnly = true;
			this.selectionMethodTextBox.Size = new System.Drawing.Size(144, 22);
			this.selectionMethodTextBox.TabIndex = 16;
			// 
			// stoppingCriteriaTextBox
			// 
			this.stoppingCriteriaTextBox.Location = new System.Drawing.Point(361, 297);
			this.stoppingCriteriaTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.stoppingCriteriaTextBox.Name = "stoppingCriteriaTextBox";
			this.stoppingCriteriaTextBox.ReadOnly = true;
			this.stoppingCriteriaTextBox.Size = new System.Drawing.Size(144, 22);
			this.stoppingCriteriaTextBox.TabIndex = 15;
			// 
			// numberOfServersLabel
			// 
			this.numberOfServersLabel.AutoSize = true;
			this.numberOfServersLabel.Location = new System.Drawing.Point(380, 72);
			this.numberOfServersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.numberOfServersLabel.Name = "numberOfServersLabel";
			this.numberOfServersLabel.Size = new System.Drawing.Size(121, 16);
			this.numberOfServersLabel.TabIndex = 9;
			this.numberOfServersLabel.Text = "Number Of Servers";
			// 
			// serverComboBox
			// 
			this.serverComboBox.FormattingEnabled = true;
			this.serverComboBox.Location = new System.Drawing.Point(888, 417);
			this.serverComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.serverComboBox.Name = "serverComboBox";
			this.serverComboBox.Size = new System.Drawing.Size(160, 24);
			this.serverComboBox.TabIndex = 20;
			this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 344);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 52);
			this.button1.TabIndex = 0;
			this.button1.Text = "Read File";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(888, 457);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "Interval Distrepution";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// stoppingNumberLabel
			// 
			this.stoppingNumberLabel.AutoSize = true;
			this.stoppingNumberLabel.Location = new System.Drawing.Point(388, 180);
			this.stoppingNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.stoppingNumberLabel.Name = "stoppingNumberLabel";
			this.stoppingNumberLabel.Size = new System.Drawing.Size(112, 16);
			this.stoppingNumberLabel.TabIndex = 10;
			this.stoppingNumberLabel.Text = "Stopping Number";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1375, 489);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.simulateButton);
			this.Controls.Add(this.serverComboBox);
			this.Controls.Add(this.serverServiceTimeDistributionLabel);
			this.Controls.Add(this.serversLabel);
			this.Controls.Add(this.serviceTimeDistributionDataTable);
			this.Controls.Add(this.selectionMethodTextBox);
			this.Controls.Add(this.stoppingCriteriaTextBox);
			this.Controls.Add(this.stoppingNumberTextBox);
			this.Controls.Add(this.numberOfServersTextBox);
			this.Controls.Add(this.selectionMethodLabel);
			this.Controls.Add(this.stoppingCriteriaLabel);
			this.Controls.Add(this.stoppingNumberLabel);
			this.Controls.Add(this.numberOfServersLabel);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.serviceTimeDistributionDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label stoppingCriteriaLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn serverProbabilityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceTimeColumn;
		private System.Windows.Forms.DataGridView serviceTimeDistributionDataTable;
		private System.Windows.Forms.Button simulateButton;
		private System.Windows.Forms.TextBox stoppingNumberTextBox;
		private System.Windows.Forms.TextBox numberOfServersTextBox;
		private System.Windows.Forms.Label serverServiceTimeDistributionLabel;
		private System.Windows.Forms.Label selectionMethodLabel;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label serversLabel;
		private System.Windows.Forms.TextBox selectionMethodTextBox;
		private System.Windows.Forms.TextBox stoppingCriteriaTextBox;
		private System.Windows.Forms.Label numberOfServersLabel;
		private System.Windows.Forms.ComboBox serverComboBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label stoppingNumberLabel;
	}
}

