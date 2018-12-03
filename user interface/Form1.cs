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
            dgV_connections.Rows.Clear();
            dgV_connections.Visible = true;
            
            Connections connectionsAPI = new Connections();
            ConnectionPoint connectionPointAPI = new ConnectionPoint();

            connectionsAPI = transportAPI.GetConnections(cbo_from.Text, cbo_to.Text);
            foreach(var connection in connectionsAPI.ConnectionList)
            {
                dgV_connections.Rows.Add(connection.From.Departure, connection.From.Station.Name, connection.To.Station.Name, connection.Duration, connection.From.Platform);
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

        public Stations StationList(string input)
        {

            Stations stations = transportAPI.GetStations(input);
            return stations;
        }

        private void btn_showstationfrom_Click(object sender, EventArgs e)
        {
            cbo_from.DroppedDown = true;
            cbo_from.DataSource = StationList(cbo_from.Text).StationList;
            cbo_from.DisplayMember = "name";
        }

        private void btn_showstationto_Click(object sender, EventArgs e)
        {
            cbo_to.DroppedDown = true;
            cbo_to.DataSource = StationList(cbo_to.Text).StationList;
            cbo_to.DisplayMember = "name";
        }
    }
}
