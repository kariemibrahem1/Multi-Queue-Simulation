namespace MultiQueueSimulation
{
	partial class TableOfData
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
			this.busyTimeButton = new System.Windows.Forms.Button();
			this.serverComboBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.utilizationTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.avgServiceTimeTextBox = new System.Windows.Forms.TextBox();
			this.idleProbabilityTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.maxQueueLengthTextBox = new System.Windows.Forms.TextBox();
			this.probabilityOfWaitTextBox = new System.Windows.Forms.TextBox();
			this.averageWaitingTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.outputDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// busyTimeButton
			// 
			this.busyTimeButton.Location = new System.Drawing.Point(1161, 535);
			this.busyTimeButton.Margin = new System.Windows.Forms.Padding(4);
			this.busyTimeButton.Name = "busyTimeButton";
			this.busyTimeButton.Size = new System.Drawing.Size(128, 47);
			this.busyTimeButton.TabIndex = 35;
			this.busyTimeButton.Text = "Busy Time Graph";
			this.busyTimeButton.UseVisualStyleBackColor = true;
			this.busyTimeButton.Click += new System.EventHandler(this.busyTimeButton_Click_1);
			// 
			// serverComboBox
			// 
			this.serverComboBox.FormattingEnabled = true;
			this.serverComboBox.Location = new System.Drawing.Point(972, 481);
			this.serverComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.serverComboBox.Name = "serverComboBox";
			this.serverComboBox.Size = new System.Drawing.Size(123, 24);
			this.serverComboBox.TabIndex = 34;
			this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged_1);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(911, 486);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 16);
			this.label9.TabIndex = 33;
			this.label9.Text = "Server";
			// 
			// utilizationTextBox
			// 
			this.utilizationTextBox.Location = new System.Drawing.Point(915, 566);
			this.utilizationTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.utilizationTextBox.Name = "utilizationTextBox";
			this.utilizationTextBox.ReadOnly = true;
			this.utilizationTextBox.Size = new System.Drawing.Size(99, 22);
			this.utilizationTextBox.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(911, 535);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "Utilization";
			// 
			// avgServiceTimeTextBox
			// 
			this.avgServiceTimeTextBox.Location = new System.Drawing.Point(761, 566);
			this.avgServiceTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.avgServiceTimeTextBox.Name = "avgServiceTimeTextBox";
			this.avgServiceTimeTextBox.ReadOnly = true;
			this.avgServiceTimeTextBox.Size = new System.Drawing.Size(107, 22);
			this.avgServiceTimeTextBox.TabIndex = 30;
			// 
			// idleProbabilityTextBox
			// 
			this.idleProbabilityTextBox.Location = new System.Drawing.Point(603, 566);
			this.idleProbabilityTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.idleProbabilityTextBox.Name = "idleProbabilityTextBox";
			this.idleProbabilityTextBox.ReadOnly = true;
			this.idleProbabilityTextBox.Size = new System.Drawing.Size(97, 22);
			this.idleProbabilityTextBox.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(757, 535);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(114, 16);
			this.label7.TabIndex = 28;
			this.label7.Text = "Avg Service Time";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(599, 535);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 27;
			this.label6.Text = "Idle Probability";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label5.Location = new System.Drawing.Point(597, 479);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(275, 24);
			this.label5.TabIndex = 26;
			this.label5.Text = "Server Performance Measures";
			// 
			// maxQueueLengthTextBox
			// 
			this.maxQueueLengthTextBox.Location = new System.Drawing.Point(373, 566);
			this.maxQueueLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.maxQueueLengthTextBox.Name = "maxQueueLengthTextBox";
			this.maxQueueLengthTextBox.ReadOnly = true;
			this.maxQueueLengthTextBox.Size = new System.Drawing.Size(119, 22);
			this.maxQueueLengthTextBox.TabIndex = 25;
			// 
			// probabilityOfWaitTextBox
			// 
			this.probabilityOfWaitTextBox.Location = new System.Drawing.Point(196, 566);
			this.probabilityOfWaitTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.probabilityOfWaitTextBox.Name = "probabilityOfWaitTextBox";
			this.probabilityOfWaitTextBox.ReadOnly = true;
			this.probabilityOfWaitTextBox.Size = new System.Drawing.Size(121, 22);
			this.probabilityOfWaitTextBox.TabIndex = 24;
			// 
			// averageWaitingTextBox
			// 
			this.averageWaitingTextBox.Location = new System.Drawing.Point(25, 566);
			this.averageWaitingTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.averageWaitingTextBox.Name = "averageWaitingTextBox";
			this.averageWaitingTextBox.ReadOnly = true;
			this.averageWaitingTextBox.Size = new System.Drawing.Size(132, 22);
			this.averageWaitingTextBox.TabIndex = 23;
			this.averageWaitingTextBox.TextChanged += new System.EventHandler(this.averageWaitingTextBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(369, 535);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Max Queue Length";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(192, 535);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Probability of Wait";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.label1.Location = new System.Drawing.Point(20, 479);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "System Performance Measures";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Time in Queue";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 125;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Server Index";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 125;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Time Service End";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 125;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Service Time";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 125;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Time Service Begins";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Random Digits for Service";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Arrival Time";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "InterArrival Time";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Random Digits for Arrival";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 80;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Customer No.";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 80;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 535);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Average Waiting Time";
			// 
			// outputDataGridView
			// 
			this.outputDataGridView.AllowUserToAddRows = false;
			this.outputDataGridView.AllowUserToDeleteRows = false;
			this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.outputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.outputDataGridView.Location = new System.Drawing.Point(20, 36);
			this.outputDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.outputDataGridView.Name = "outputDataGridView";
			this.outputDataGridView.ReadOnly = true;
			this.outputDataGridView.RowHeadersWidth = 51;
			this.outputDataGridView.Size = new System.Drawing.Size(1359, 423);
			this.outputDataGridView.TabIndex = 18;
			this.outputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputDataGridView_CellContentClick);
			// 
			// TableOfData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1398, 624);
			this.Controls.Add(this.busyTimeButton);
			this.Controls.Add(this.serverComboBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.utilizationTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.avgServiceTimeTextBox);
			this.Controls.Add(this.idleProbabilityTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.maxQueueLengthTextBox);
			this.Controls.Add(this.probabilityOfWaitTextBox);
			this.Controls.Add(this.averageWaitingTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.outputDataGridView);
			this.Name = "TableOfData";
			this.Text = "TableOfData";
			this.Load += new System.EventHandler(this.TableOfData_Load);
			((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button busyTimeButton;
		private System.Windows.Forms.ComboBox serverComboBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox utilizationTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox avgServiceTimeTextBox;
		private System.Windows.Forms.TextBox idleProbabilityTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox maxQueueLengthTextBox;
		private System.Windows.Forms.TextBox probabilityOfWaitTextBox;
		private System.Windows.Forms.TextBox averageWaitingTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView outputDataGridView;
	}
}