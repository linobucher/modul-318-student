using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Input;
using System.Windows.Forms;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        /// <summary>
        /// Intenet-Verbindungs Exception eingebaut
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Stations GetStations(string query)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message
                            , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    return stations;
                }
            }
            catch
            {
                MessageBox.Show("Keine Netzverbindung! Bitte verbinden Sie sich mit dem Internet.");
            }
            
            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }
            return null;
        }
        /// <summary>
        ///try catch pastet, because of Exceptionhandling
        /// </summary>
        
        /// <param name="fromStation"></param>
        /// <param name="toStattion"></param>
        /// <returns></returns>
        public Connections GetConnections(string fromStation, string toStattion)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                try
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections = JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }
                catch
                {
                    MessageBox.Show("Es gibt einen unbehandelten Fehler der API", "Fahrplan");
                }
                
            }
            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
