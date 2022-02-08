using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace TripPlanner {
    public partial class MainForm : Form {
        private ITransport _transport = new Transport();

        public MainForm() {
            InitializeComponent();
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
        /// Searches for connections based on fromTextBox.Text and toTextBox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e) {
            if (fromTextBox.Text.Trim().Length > 0 && toTextBox.Text.Trim().Length > 0) {
                connectionResultListBox.Items.Clear();

                // Get connections
                Connections connections = _transport.GetConnections(fromTextBox.Text, toTextBox.Text);
                foreach (Connection connection in connections.ConnectionList) {
                    connectionResultListBox.Items.Add($"{connection.From.Departure} Gleis {connection.From.Platform} {connection.From.Station.Name} > {connection.To.Departure} Gleis {connection.To.Platform} {connection.To.Station.Name} — Dauer: {connection.Duration}");
                }
            } else {
                MessageBox.Show("Bitte geben Sie eine Start- und Zielstation ein.");
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

                // Display in listbox
                foreach (StationBoard stationBoard in stationBoards.Entries) {
                    timetableDataGridView.Rows.Add(stationBoard.Operator, stationBoard.Number, stationBoard.Category, stationBoard.Name, stationBoard.To);
                }
            } else {
                // No station selected
                MessageBox.Show("Bitte wählen Sie eine Station aus der Stationssuche.");
            }
        }
    }
}