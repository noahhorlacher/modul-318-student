namespace TripPlanner
{
    partial class MainForm
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
            this.connectionTitleLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.connectionResultListBox = new System.Windows.Forms.ListBox();
            this.stationSearchButton = new System.Windows.Forms.Button();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionTitleLabel
            // 
            this.connectionTitleLabel.AutoSize = true;
            this.connectionTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionTitleLabel.Location = new System.Drawing.Point(848, 9);
            this.connectionTitleLabel.Name = "connectionTitleLabel";
            this.connectionTitleLabel.Size = new System.Drawing.Size(308, 41);
            this.connectionTitleLabel.TabIndex = 0;
            this.connectionTitleLabel.Text = "Verbindungen suchen";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(848, 64);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(34, 20);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Von";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(848, 87);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.PlaceholderText = "Startstation";
            this.fromTextBox.Size = new System.Drawing.Size(389, 27);
            this.fromTextBox.TabIndex = 5;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(848, 150);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.PlaceholderText = "Zielstation";
            this.toTextBox.Size = new System.Drawing.Size(389, 27);
            this.toTextBox.TabIndex = 6;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(848, 127);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(43, 20);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "Nach";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1143, 183);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 31);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // connectionResultListBox
            // 
            this.connectionResultListBox.FormattingEnabled = true;
            this.connectionResultListBox.ItemHeight = 20;
            this.connectionResultListBox.Location = new System.Drawing.Point(848, 231);
            this.connectionResultListBox.Name = "connectionResultListBox";
            this.connectionResultListBox.Size = new System.Drawing.Size(389, 284);
            this.connectionResultListBox.TabIndex = 8;
            // 
            // stationSearchButton
            // 
            this.stationSearchButton.Location = new System.Drawing.Point(307, 120);
            this.stationSearchButton.Name = "stationSearchButton";
            this.stationSearchButton.Size = new System.Drawing.Size(94, 31);
            this.stationSearchButton.TabIndex = 2;
            this.stationSearchButton.Text = "Suchen";
            this.stationSearchButton.UseVisualStyleBackColor = true;
            this.stationSearchButton.Click += new System.EventHandler(this.stationSearchButton_Click);
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(12, 87);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.PlaceholderText = "Stationsname";
            this.stationTextBox.Size = new System.Drawing.Size(389, 27);
            this.stationTextBox.TabIndex = 1;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(12, 64);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(56, 20);
            this.stationLabel.TabIndex = 8;
            this.stationLabel.Text = "Station";
            // 
            // stationTitleLabel
            // 
            this.stationTitleLabel.AutoSize = true;
            this.stationTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stationTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.stationTitleLabel.Name = "stationTitleLabel";
            this.stationTitleLabel.Size = new System.Drawing.Size(245, 41);
            this.stationTitleLabel.TabIndex = 7;
            this.stationTitleLabel.Text = "Stationen suchen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Abfahrtstafel";
            // 
            // stationsDataGridView
            // 
            this.stationsDataGridView.AllowUserToAddRows = false;
            this.stationsDataGridView.AllowUserToDeleteRows = false;
            this.stationsDataGridView.AllowUserToResizeRows = false;
            this.stationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Station});
            this.stationsDataGridView.Location = new System.Drawing.Point(12, 157);
            this.stationsDataGridView.MultiSelect = false;
            this.stationsDataGridView.Name = "stationsDataGridView";
            this.stationsDataGridView.ReadOnly = true;
            this.stationsDataGridView.RowHeadersWidth = 51;
            this.stationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stationsDataGridView.RowTemplate.Height = 29;
            this.stationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stationsDataGridView.Size = new System.Drawing.Size(389, 358);
            this.stationsDataGridView.TabIndex = 16;
            this.stationsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stationsDataGridView_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Station
            // 
            this.Station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Station.HeaderText = "Station";
            this.Station.MinimumWidth = 6;
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.AllowUserToAddRows = false;
            this.timetableDataGridView.AllowUserToDeleteRows = false;
            this.timetableDataGridView.AllowUserToResizeRows = false;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operator,
            this.Richtung,
            this.Number,
            this.Category,
            this.Von});
            this.timetableDataGridView.Location = new System.Drawing.Point(431, 87);
            this.timetableDataGridView.MultiSelect = false;
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.ReadOnly = true;
            this.timetableDataGridView.RowHeadersWidth = 51;
            this.timetableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timetableDataGridView.RowTemplate.Height = 29;
            this.timetableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timetableDataGridView.Size = new System.Drawing.Size(389, 428);
            this.timetableDataGridView.TabIndex = 17;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.MinimumWidth = 6;
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            this.Operator.Visible = false;
            this.Operator.Width = 125;
            // 
            // Richtung
            // 
            this.Richtung.HeaderText = "Richtung";
            this.Richtung.MinimumWidth = 6;
            this.Richtung.Name = "Richtung";
            this.Richtung.ReadOnly = true;
            this.Richtung.Width = 125;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Von
            // 
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            this.Von.ReadOnly = true;
            this.Von.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 527);
            this.Controls.Add(this.timetableDataGridView);
            this.Controls.Add(this.stationsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stationSearchButton);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.stationTitleLabel);
            this.Controls.Add(this.connectionResultListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.connectionTitleLabel);
            this.Name = "MainForm";
            this.Text = "Trip Planner";
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label connectionTitleLabel;
        private Label fromLabel;
        private TextBox fromTextBox;
        private TextBox toTextBox;
        private Label toLabel;
        private Button searchButton;
        private ListBox connectionResultListBox;
        private Button stationSearchButton;
        private TextBox stationTextBox;
        private Label stationLabel;
        private Label stationTitleLabel;
        private Label label1;
        private DataGridView stationsDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Station;
        private DataGridView timetableDataGridView;
        private DataGridViewTextBoxColumn Operator;
        private DataGridViewTextBoxColumn Richtung;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Von;
    }
}