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
        public FormMain()
        {
            InitializeComponent();
        }

        Transport transportAPI = new Transport();

        public void btn_searchconnection_Click(object sender, EventArgs e)
        {
            dgV_Connections.Rows.Clear();
            dgV_Connections.Visible = true;
            
            Connections connectionsAPI = new Connections();
            ConnectionPoint connectionPointAPI = new ConnectionPoint();

            connectionsAPI = transportAPI.GetConnections(cbo_From.Text, cbo_To.Text);
            foreach(var connection in connectionsAPI.ConnectionList)
            {
                string departureTime = Convert.ToDateTime(connection.From.Departure).ToString().Substring(0,16);
                string duration = (connection.Duration).ToString().Substring(3, 5);
                dgV_Connections.Rows.Add(departureTime, connection.From.Station.Name, connection.To.Station.Name, duration, "Gleis " + connection.From.Platform);
            }
        }

        //private void cbo_from_TextChanged(object sender, EventArgs e)
        //{
        //    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        //    Transport transportAPI = new Transport();
        //    Stations stationsAPI = new Stations();

        //    collection.Clear();
        //    cbo_from.DroppedDown = true;
        //    stationsAPI = transportAPI.GetStations(cbo_from.Text);

        //    foreach (var station in stationsAPI.StationList)
        //    {
        //        collection.Add(station.Name);
        //    }

        //    Cursor.Current = Cursors.WaitCursor;
        //    Application.DoEvents();

        //    cbo_from.AutoCompleteCustomSource = collection;
        //}

        //public Stations StationList(string input)
        //{

        //    Stations stations = transportAPI.GetStations(input);
        //    return stations;
        //}

        private void showStation(ComboBox comboBox)
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

        private void btn_showstationfrom_Click(object sender, EventArgs e)
        {
            showStation(cbo_From);
        }

        private void btn_showstationto_Click(object sender, EventArgs e)
        {
            showStation(cbo_To);
        }

        private void btn_ShowStationTable_Click(object sender, EventArgs e)
        {
            //dgV_Connections.Rows.Clear();
            //dgV_Connections.Visible = true;

            //StationBoardRoot stationBoardAPI = new StationBoardRoot();
            //Stations stations = new Stations();

            //stationBoardAPI = transportAPI.GetStationBoard(cbo_From.Text, cbo_From);
            //foreach (var stationBoard in stationBoardAPI.Entries)
            //{
            //    dgV_Connections.Rows.Add(stationBoard.Name ,stationBoard.To);
            //}
        }
    }
}
