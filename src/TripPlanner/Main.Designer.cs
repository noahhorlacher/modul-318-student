namespace TripPlanner
{
    partial class Main
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.stationSearchTimetableTabPage = new System.Windows.Forms.TabPage();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationSearchButton = new System.Windows.Forms.Button();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.connectionsTabPage = new System.Windows.Forms.TabPage();
            this.emailButton = new System.Windows.Forms.Button();
            this.connectionDatePickerLabel = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.connectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.connectionResultDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.stationSearchTimetableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).BeginInit();
            this.connectionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionTitleLabel
            // 
            this.connectionTitleLabel.AutoSize = true;
            this.connectionTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.connectionTitleLabel.Name = "connectionTitleLabel";
            this.connectionTitleLabel.Size = new System.Drawing.Size(308, 41);
            this.connectionTitleLabel.TabIndex = 0;
            this.connectionTitleLabel.Text = "Verbindungen suchen";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.stationSearchTimetableTabPage);
            this.mainTabControl.Controls.Add(this.connectionsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 11);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1089, 610);
            this.mainTabControl.TabIndex = 16;
            // 
            // stationSearchTimetableTabPage
            // 
            this.stationSearchTimetableTabPage.Controls.Add(this.timetableDataGridView);
            this.stationSearchTimetableTabPage.Controls.Add(this.stationsDataGridView);
            this.stationSearchTimetableTabPage.Controls.Add(this.stationTitleLabel);
            this.stationSearchTimetableTabPage.Controls.Add(this.label1);
            this.stationSearchTimetableTabPage.Controls.Add(this.stationLabel);
            this.stationSearchTimetableTabPage.Controls.Add(this.stationSearchButton);
            this.stationSearchTimetableTabPage.Controls.Add(this.stationTextBox);
            this.stationSearchTimetableTabPage.Location = new System.Drawing.Point(4, 29);
            this.stationSearchTimetableTabPage.Name = "stationSearchTimetableTabPage";
            this.stationSearchTimetableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stationSearchTimetableTabPage.Size = new System.Drawing.Size(1081, 577);
            this.stationSearchTimetableTabPage.TabIndex = 1;
            this.stationSearchTimetableTabPage.Text = "Stationen & Abfahrtspläne";
            this.stationSearchTimetableTabPage.UseVisualStyleBackColor = true;
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.AllowUserToAddRows = false;
            this.timetableDataGridView.AllowUserToDeleteRows = false;
            this.timetableDataGridView.AllowUserToResizeRows = false;
            this.timetableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Richtung,
            this.Nummer});
            this.timetableDataGridView.Location = new System.Drawing.Point(442, 60);
            this.timetableDataGridView.MultiSelect = false;
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.ReadOnly = true;
            this.timetableDataGridView.RowHeadersWidth = 51;
            this.timetableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timetableDataGridView.RowTemplate.Height = 29;
            this.timetableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timetableDataGridView.Size = new System.Drawing.Size(633, 511);
            this.timetableDataGridView.TabIndex = 25;
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
            this.stationsDataGridView.Location = new System.Drawing.Point(6, 153);
            this.stationsDataGridView.MultiSelect = false;
            this.stationsDataGridView.Name = "stationsDataGridView";
            this.stationsDataGridView.ReadOnly = true;
            this.stationsDataGridView.RowHeadersWidth = 51;
            this.stationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stationsDataGridView.RowTemplate.Height = 29;
            this.stationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stationsDataGridView.Size = new System.Drawing.Size(389, 418);
            this.stationsDataGridView.TabIndex = 24;
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
            // stationTitleLabel
            // 
            this.stationTitleLabel.AutoSize = true;
            this.stationTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stationTitleLabel.Location = new System.Drawing.Point(6, 5);
            this.stationTitleLabel.Name = "stationTitleLabel";
            this.stationTitleLabel.Size = new System.Drawing.Size(245, 41);
            this.stationTitleLabel.TabIndex = 26;
            this.stationTitleLabel.Text = "Stationen suchen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(442, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Abfahrtstafel";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(6, 60);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(56, 20);
            this.stationLabel.TabIndex = 27;
            this.stationLabel.Text = "Station";
            // 
            // stationSearchButton
            // 
            this.stationSearchButton.Location = new System.Drawing.Point(301, 116);
            this.stationSearchButton.Name = "stationSearchButton";
            this.stationSearchButton.Size = new System.Drawing.Size(94, 31);
            this.stationSearchButton.TabIndex = 23;
            this.stationSearchButton.Text = "Suchen";
            this.stationSearchButton.UseVisualStyleBackColor = true;
            this.stationSearchButton.Click += new System.EventHandler(this.stationSearchButton_Click);
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(6, 83);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.PlaceholderText = "Stationsname";
            this.stationTextBox.Size = new System.Drawing.Size(389, 27);
            this.stationTextBox.TabIndex = 22;
            // 
            // connectionsTabPage
            // 
            this.connectionsTabPage.Controls.Add(this.emailButton);
            this.connectionsTabPage.Controls.Add(this.connectionDatePickerLabel);
            this.connectionsTabPage.Controls.Add(this.connectionTitleLabel);
            this.connectionsTabPage.Controls.Add(this.toComboBox);
            this.connectionsTabPage.Controls.Add(this.connectionDatePicker);
            this.connectionsTabPage.Controls.Add(this.fromComboBox);
            this.connectionsTabPage.Controls.Add(this.connectionResultDataGridView);
            this.connectionsTabPage.Controls.Add(this.searchButton);
            this.connectionsTabPage.Controls.Add(this.toLabel);
            this.connectionsTabPage.Controls.Add(this.fromLabel);
            this.connectionsTabPage.Location = new System.Drawing.Point(4, 29);
            this.connectionsTabPage.Name = "connectionsTabPage";
            this.connectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTabPage.Size = new System.Drawing.Size(1081, 577);
            this.connectionsTabPage.TabIndex = 0;
            this.connectionsTabPage.Text = "Verbindungen";
            this.connectionsTabPage.UseVisualStyleBackColor = true;
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(932, 199);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(143, 29);
            this.emailButton.TabIndex = 16;
            this.emailButton.Text = "per Email senden";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // connectionDatePickerLabel
            // 
            this.connectionDatePickerLabel.AutoSize = true;
            this.connectionDatePickerLabel.Location = new System.Drawing.Point(6, 180);
            this.connectionDatePickerLabel.Name = "connectionDatePickerLabel";
            this.connectionDatePickerLabel.Size = new System.Drawing.Size(87, 20);
            this.connectionDatePickerLabel.TabIndex = 15;
            this.connectionDatePickerLabel.Text = "Reisedatum";
            // 
            // toComboBox
            // 
            this.toComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(6, 137);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(467, 28);
            this.toComboBox.TabIndex = 6;
            this.toComboBox.TextUpdate += new System.EventHandler(this.toComboBox_TextUpdate);
            // 
            // connectionDatePicker
            // 
            this.connectionDatePicker.Location = new System.Drawing.Point(6, 203);
            this.connectionDatePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.connectionDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.connectionDatePicker.Name = "connectionDatePicker";
            this.connectionDatePicker.Size = new System.Drawing.Size(282, 27);
            this.connectionDatePicker.TabIndex = 7;
            // 
            // fromComboBox
            // 
            this.fromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(6, 75);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(467, 28);
            this.fromComboBox.TabIndex = 5;
            this.fromComboBox.TextUpdate += new System.EventHandler(this.fromComboBox_TextUpdate);
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
            this.fromStation,
            this.connectionDeparture,
            this.toStation,
            this.connectionArrival,
            this.duration});
            this.connectionResultDataGridView.Location = new System.Drawing.Point(6, 258);
            this.connectionResultDataGridView.MultiSelect = false;
            this.connectionResultDataGridView.Name = "connectionResultDataGridView";
            this.connectionResultDataGridView.ReadOnly = true;
            this.connectionResultDataGridView.RowHeadersWidth = 51;
            this.connectionResultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.connectionResultDataGridView.RowTemplate.Height = 29;
            this.connectionResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connectionResultDataGridView.Size = new System.Drawing.Size(1069, 313);
            this.connectionResultDataGridView.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(379, 199);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 31);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(6, 115);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(43, 20);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "Nach";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(6, 52);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(34, 20);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Von";
            // 
            // fromStation
            // 
            this.fromStation.HeaderText = "Startstation";
            this.fromStation.MinimumWidth = 6;
            this.fromStation.Name = "fromStation";
            this.fromStation.ReadOnly = true;
            this.fromStation.Width = 114;
            // 
            // connectionDeparture
            // 
            this.connectionDeparture.HeaderText = "Abfahrt";
            this.connectionDeparture.MinimumWidth = 6;
            this.connectionDeparture.Name = "connectionDeparture";
            this.connectionDeparture.ReadOnly = true;
            this.connectionDeparture.Width = 88;
            // 
            // toStation
            // 
            this.toStation.HeaderText = "Zielstation";
            this.toStation.MinimumWidth = 6;
            this.toStation.Name = "toStation";
            this.toStation.ReadOnly = true;
            this.toStation.Width = 108;
            // 
            // connectionArrival
            // 
            this.connectionArrival.HeaderText = "Ankunft";
            this.connectionArrival.MinimumWidth = 6;
            this.connectionArrival.Name = "connectionArrival";
            this.connectionArrival.ReadOnly = true;
            this.connectionArrival.Width = 89;
            // 
            // duration
            // 
            this.duration.HeaderText = "Dauer";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 78;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 633);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Main";
            this.Text = "Trip Planner";
            this.mainTabControl.ResumeLayout(false);
            this.stationSearchTimetableTabPage.ResumeLayout(false);
            this.stationSearchTimetableTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsDataGridView)).EndInit();
            this.connectionsTabPage.ResumeLayout(false);
            this.connectionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label connectionTitleLabel;
        private TabControl mainTabControl;
        private TabPage connectionsTabPage;
        private TabPage stationSearchTimetableTabPage;
        private Label connectionDatePickerLabel;
        private ComboBox toComboBox;
        private DateTimePicker connectionDatePicker;
        private ComboBox fromComboBox;
        private DataGridView connectionResultDataGridView;
        private Button searchButton;
        private Label toLabel;
        private Label fromLabel;
        private DataGridView timetableDataGridView;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Richtung;
        private DataGridViewTextBoxColumn Nummer;
        private DataGridView stationsDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Station;
        private Label stationTitleLabel;
        private Label label1;
        private Label stationLabel;
        private Button stationSearchButton;
        private TextBox stationTextBox;
        private Button emailButton;
        private DataGridViewTextBoxColumn fromStation;
        private DataGridViewTextBoxColumn connectionDeparture;
        private DataGridViewTextBoxColumn toStation;
        private DataGridViewTextBoxColumn connectionArrival;
        private DataGridViewTextBoxColumn duration;
    }
}