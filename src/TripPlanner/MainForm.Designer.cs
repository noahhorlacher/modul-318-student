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
            this.toLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.stationSearchButton = new System.Windows.Forms.Button();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.connectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.connectionDatePickerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionResultDataGridView)).BeginInit();
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
            this.searchButton.Location = new System.Drawing.Point(1221, 211);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 31);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.stationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.stationsDataGridView.Size = new System.Drawing.Size(389, 464);
            this.stationsDataGridView.TabIndex = 3;
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
            this.timetableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Richtung,
            this.Nummer});
            this.timetableDataGridView.Location = new System.Drawing.Point(431, 87);
            this.timetableDataGridView.MultiSelect = false;
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.ReadOnly = true;
            this.timetableDataGridView.RowHeadersWidth = 51;
            this.timetableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timetableDataGridView.RowTemplate.Height = 29;
            this.timetableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timetableDataGridView.Size = new System.Drawing.Size(387, 534);
            this.timetableDataGridView.TabIndex = 4;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.MinimumWidth = 6;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 88;
            // 
            // Richtung
            // 
            this.Richtung.HeaderText = "Richtung";
            this.Richtung.MinimumWidth = 6;
            this.Richtung.Name = "Richtung";
            this.Richtung.ReadOnly = true;
            this.Richtung.Width = 96;
            // 
            // Nummer
            // 
            this.Nummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.MinimumWidth = 6;
            this.Nummer.Name = "Nummer";
            this.Nummer.ReadOnly = true;
            // 
            // connectionResultDataGridView
            // 
            this.connectionResultDataGridView.AllowUserToAddRows = false;
            this.connectionResultDataGridView.AllowUserToDeleteRows = false;
            this.connectionResultDataGridView.AllowUserToResizeRows = false;
            this.connectionResultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.connectionResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Dauer});
            this.connectionResultDataGridView.Location = new System.Drawing.Point(848, 248);
            this.connectionResultDataGridView.MultiSelect = false;
            this.connectionResultDataGridView.Name = "connectionResultDataGridView";
            this.connectionResultDataGridView.ReadOnly = true;
            this.connectionResultDataGridView.RowHeadersWidth = 51;
            this.connectionResultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.connectionResultDataGridView.RowTemplate.Height = 29;
            this.connectionResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connectionResultDataGridView.Size = new System.Drawing.Size(467, 373);
            this.connectionResultDataGridView.TabIndex = 9;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.ReadOnly = true;
            this.Abfahrt.Width = 88;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 6;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            this.Ankunft.Width = 89;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 6;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            this.Dauer.Width = 78;
            // 
            // fromComboBox
            // 
            this.fromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(848, 87);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(467, 28);
            this.fromComboBox.TabIndex = 5;
            this.fromComboBox.TextUpdate += new System.EventHandler(this.fromComboBox_TextUpdate);
            // 
            // toComboBox
            // 
            this.toComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(848, 149);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(467, 28);
            this.toComboBox.TabIndex = 6;
            this.toComboBox.TextUpdate += new System.EventHandler(this.toComboBox_TextUpdate);
            // 
            // connectionDatePicker
            // 
            this.connectionDatePicker.Location = new System.Drawing.Point(848, 215);
            this.connectionDatePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.connectionDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.connectionDatePicker.Name = "connectionDatePicker";
            this.connectionDatePicker.Size = new System.Drawing.Size(367, 27);
            this.connectionDatePicker.TabIndex = 7;
            // 
            // connectionDatePickerLabel
            // 
            this.connectionDatePickerLabel.AutoSize = true;
            this.connectionDatePickerLabel.Location = new System.Drawing.Point(848, 192);
            this.connectionDatePickerLabel.Name = "connectionDatePickerLabel";
            this.connectionDatePickerLabel.Size = new System.Drawing.Size(87, 20);
            this.connectionDatePickerLabel.TabIndex = 15;
            this.connectionDatePickerLabel.Text = "Reisedatum";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 633);
            this.Controls.Add(this.connectionDatePickerLabel);
            this.Controls.Add(this.connectionDatePicker);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.connectionResultDataGridView);
            this.Controls.Add(this.timetableDataGridView);
            this.Controls.Add(this.stationsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stationSearchButton);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.stationTitleLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.connectionTitleLabel);
            this.Name = "MainForm";
            this.Text = "Trip Planner";
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label connectionTitleLabel;
        private Label fromLabel;
        private Label toLabel;
        private Button searchButton;
        private Button stationSearchButton;
        private TextBox stationTextBox;
        private Label stationLabel;
        private Label stationTitleLabel;
        private Label label1;
        private DataGridView stationsDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Station;
        private DataGridView timetableDataGridView;
        private DataGridView connectionResultDataGridView;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Dauer;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Richtung;
        private DataGridViewTextBoxColumn Nummer;
        private DateTimePicker connectionDatePicker;
        private Label connectionDatePickerLabel;
    }
}