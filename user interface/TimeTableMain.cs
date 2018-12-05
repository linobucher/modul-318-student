using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace user_interface
{
    public partial class FormMain : Form
    {
        Transport transportAPI = new Transport();
        private Stations departureAPI;
        private Stations arrivalAPI;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_searchconnection_Click(object sender, EventArgs e)
        {
            dgV_Connections.Rows.Clear();                   
            dgV_StationBoard.Visible = false;               //Stellt alle nötigen Elemente auf sichtbar
            dgV_Connections.Visible = true;
            lbl_ShowRoute.Visible = true;                   

            Connections connectionsAPI = new Connections();
            ConnectionPoint connectionPointAPI = new ConnectionPoint();

            connectionsAPI = transportAPI.GetConnections(cbo_From.Text, cbo_To.Text);
            try
            {
                foreach (var connection in connectionsAPI.ConnectionList)
                {
                    string departureTime = Convert.ToDateTime(connection.From.Departure).ToString().Substring(0, 16);
                    string duration = (connection.Duration).ToString().Substring(3, 5);
                    dgV_Connections.Rows.Add(departureTime, connection.From.Station.Name, connection.To.Station.Name, duration, "Gleis " + connection.From.Platform);
                }
            }
            catch
            {
                MessageBox.Show("Es gibt ein unbehandelter Fehler. " +
                    "Bitte geben Sie andere Stationen ein und versuchen es später nochmal");
            }
        }

        private void showStation(ComboBox comboBox)
        {
            try
            {
                Stations StationList(string input)
                {
                    Stations stations = transportAPI.GetStations(input);
                    return stations;
                }
                comboBox.DroppedDown = true;
                comboBox.DataSource = StationList(comboBox.Text).StationList;
                comboBox.DisplayMember = "name";
            }
            catch
            {
            }
        }

        private void btn_showstationfrom_Click(object sender, EventArgs e)
        {
            showStation(cbo_From);
        }

        private void btn_showstationto_Click(object sender, EventArgs e)
        {
            showStation(cbo_To);
        }

        private string GetStationID(string stationName)
        {
            return transportAPI.GetStations(stationName).StationList[0].Id;
        }
        
        private void btn_ShowStationTable_Click(object sender, EventArgs e)
        {
            dgV_StationBoard.Rows.Clear();
            dgV_Connections.Visible = false;
            dgV_StationBoard.Visible = true;
            lbl_ShowRoute.Visible = false;

            StationBoardRoot stationBoardAPI = new StationBoardRoot();
            Stations stations = new Stations();

            stationBoardAPI = transportAPI.GetStationBoard(cbo_From.Text, GetStationID(cbo_From.Text));

            foreach (var stationBoard in stationBoardAPI.Entries)
            {
                dgV_StationBoard.Rows.Add(stationBoard.Stop.Departure, cbo_From.Text, stationBoard.To, stationBoard.Name, stationBoard.Category);
            }
        }

        private void cbo_stations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SearchConnection.PerformClick();
            }
        }
        private void UInput(ComboBox Input, ref Stations stations)
        {
            if(Input.Text != String.Empty)
            {
                var text = Input.Text;
                var newStations = transportAPI.GetStations(Input.Text);
               if (newStations.StationList.Count > 0 && newStations.StationList[0].Name != String.Empty)
                {
                    stations = newStations;
                    Input.DataSource = newStations.StationList;
                    Input.DroppedDown = true;
                    Input.Text = text;
                    Input.SelectionStart = text.Length;
                }
            }
        }

        private void showAutocompletion(ComboBox combobox, Stations stations)
        {
            if (checkbox_AutoCompletionOnOff.Checked == true)
            {
                stations = new Stations();
                stations.StationList = new List<Station>();

                combobox.DataSource = stations.StationList;
                combobox.DisplayMember = "name";

                ComboBox Input = combobox;
                UInput(Input, ref stations);

                Cursor.Current = Cursors.Default;
            }
        }
        private void cbo_From_TextUpdate(object sender, EventArgs e)
        {
            showAutocompletion(cbo_From, departureAPI);
        }

        private void cbo_To_TextUpdate(object sender, EventArgs e)
        {
            showAutocompletion(cbo_To, arrivalAPI);
        }

        private void dgV_Connections_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string location = $"maps/dir/{cbo_From.Text}/{cbo_To.Text}";
            System.Diagnostics.Process.Start($"http://www.google.com/{location}");
        }
    }
}
