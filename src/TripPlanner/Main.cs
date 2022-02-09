using System.Diagnostics;
using SwissTransport.Core;
using SwissTransport.Models;

namespace TripPlanner {
    public partial class Main : Form {
        private ITransport _transport = new Transport();
        private AutoCompleteStringCollection _fromAutoCompleteSource = new();
        private AutoCompleteStringCollection _toAutoCompleteSource = new();

        public Main() {
            InitializeComponent();
            fromComboBox.AutoCompleteCustomSource = _fromAutoCompleteSource;
            toComboBox.AutoCompleteCustomSource = _toAutoCompleteSource;
        }

        /// <summary>
        /// Searches for stations based on stationTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stationSearchButton_Click(object sender, EventArgs e) {
            if (stationTextBox.Text.Trim().Length > 0) {
                // Search for station
                // Clear results
                stationsDataGridView.Rows.Clear();

                try {
                    // Get the stations
                    Stations result = _transport.GetStations(stationTextBox.Text);

                    // Display in listbox (maximum count to display defined by "MaxStationSuggestions")
                    foreach (Station station in result.StationList.Where(station => station.Id != null)) {
                        stationsDataGridView.Rows.Add(station.Id, station.Name);
                    }
                } catch (Exception ex) {
                    // Show error
                    MessageBox.Show(ex.Message);
                }
            } else {
                // Empty search field
                MessageBox.Show("Bitte geben Sie eine Station ein.");
            }
        }

        /// <summary>
        /// Displays timetable of stationsDataGridView selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stationsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Load timetable for currently selected station
            if (stationsDataGridView.SelectedCells.Count > 0) {
                // Clear timetable
                timetableDataGridView.Rows.Clear();

                // Get timetable
                int rowIndex = stationsDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = stationsDataGridView.Rows[rowIndex];

                string id = row.Cells["Id"].Value.ToString();
                string name = row.Cells["Station"].Value.ToString();

                StationBoardRoot stationBoards = _transport.GetStationBoard(name, id);

                if (stationBoards.Entries.Count > 0) {
                    // Display in listbox
                    foreach (StationBoard stationBoard in stationBoards.Entries)
                        timetableDataGridView.Rows.Add(stationBoard.Stop.Departure, stationBoard.To, stationBoard.Number);
                } else {
                    // No results
                    MessageBox.Show("Für diese Verbindung wurde keine Abfahrtstafel gefunden.");
                }
            } else {
                // No station selected
                MessageBox.Show("Bitte wählen Sie eine Station aus der Stationssuche.");
            }
        }

        /// <summary>
        /// Searches for connections based on fromTextBox.Text and toTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e) {
            if (fromComboBox.Text.Trim().Length > 0 && toComboBox.Text.Trim().Length > 0) {
                // Clear contents
                connectionResultDataGridView.Rows.Clear();

                // Get connections
                Connections connections =
                    _transport.GetConnections(fromComboBox.Text, toComboBox.Text, connectionDatePicker.Value);

                // Add connections to dataGridView
                foreach (Connection connection in connections.ConnectionList) {
                    string fromPlatform = string.IsNullOrEmpty(connection.From.Platform) ? "" : $" - Gleis {connection.From.Platform}";
                    string toPlatform = string.IsNullOrEmpty(connection.To.Platform) ? "" : $" - Gleis {connection.To.Platform}";
                    connectionResultDataGridView.Rows.Add(
                        connection.From.Station.Name,
                        $"{connection.From.Departure}{fromPlatform}",
                        connection.To.Station.Name,
                        $"{connection.To.Arrival}{toPlatform}",
                        connection.Duration);
                }
            }
            else {
                MessageBox.Show("Bitte geben Sie eine Start- und Zielstation ein.");
            }
        }


        /// <summary>
        /// Update from-connection combobox suggestions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromComboBox_TextUpdate(object sender, EventArgs e) {
            // Clear autocomplete list with for loop (.Clear is buggy)
            // for (int i = 0; i < _fromAutoCompleteSource.Count; i++) _fromAutoCompleteSource.RemoveAt(i);

            // If search string not empty
            if (fromComboBox.Text.Length > 3) {
                // Get stations
                string[] stations = _transport.GetStationsAutoComplete(fromComboBox.Text, 4)
                    .StationList
                    .Where(station => station.Id != null)
                    .Select(x => x.Name).Take(5).ToArray();

                // Add new suggestions, if there are any
                _fromAutoCompleteSource.AddRange(stations);
            }
        }

        /// <summary>
        /// Update to-connection combobox suggestions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toComboBox_TextUpdate(object sender, EventArgs e) {
            // Clear autocomplete list with for loop (.Clear is buggy)
            // for (int i = 0; i < _fromAutoCompleteSource.Count; i++) _fromAutoCompleteSource.RemoveAt(i);

            // If search string not empty
            if (toComboBox.Text.Length > 3) {
                // Get stations
                string[] stations = _transport.GetStationsAutoComplete(toComboBox.Text, 4)
                    .StationList
                    .Where(station => station.Id != null)
                    .Select(x => x.Name).Take(5).ToArray();

                // Add new suggestions, if there are any
                _toAutoCompleteSource.AddRange(stations);
            }
        }

        /// <summary>
        /// Open default mail app
        /// </summary>
        /// <param name="recipient">Email adress of recipient</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email message/content</param>
        private void openMail(string recipient="", string subject = "", string body = "") {
            string finalString = $"mailto:{recipient}?";
            if (!string.IsNullOrEmpty(subject)) finalString += $"subject={Uri.EscapeDataString(subject)}";
            if (!string.IsNullOrEmpty(body)) finalString += $"{(string.IsNullOrEmpty(subject) ? "" : "&")}body={Uri.EscapeDataString(body)}";
            Process.Start("cmd",$"/c start \"\" \"{finalString} \"");
        }

        /// <summary>
        /// Sends email of the connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailButton_Click(object sender, EventArgs e) {
            if (connectionResultDataGridView.SelectedRows.Count == 1) {
                int rowIndex = connectionResultDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow row = connectionResultDataGridView.Rows[rowIndex];

                string from = row.Cells["fromStation"].Value.ToString();
                string departure = row.Cells["connectionDeparture"].Value.ToString();
                string to = row.Cells["toStation"].Value.ToString();
                string arrival = row.Cells["connectionArrival"].Value.ToString();
                string duration = row.Cells["duration"].Value.ToString();

                openMail(
                    "empfaenger@email.com",
                    $"Verbindung {from} - {to}",
                    $"Startstation: {from}\nAbfahrt: {departure}\nZielstation: {to}\nAnkunft: {arrival}\nDauer: {duration}"
                        );
            } else {
                // No connection selected
                MessageBox.Show("Bitte wählen Sie eine Verbindung aus.");
            }
        }
    }
}