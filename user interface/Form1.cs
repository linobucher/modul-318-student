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
        Connections connectionsAPI = new Connections();

        public FormMain()
        {
            InitializeComponent();
        }

        public Stations StationList(string input)
        {
            Stations stations = transportAPI.GetStations(input);
            return stations;
        }

        //public Connections ConnectionList(string )
        //{
        //    Connection connectins = connectionsAPI.
        //}

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

        private void btn_showconnection_Click(object sender, EventArgs e)
        {
            lbo_connections.Visible = true;
            //lbo_connections
        }
    }
}
