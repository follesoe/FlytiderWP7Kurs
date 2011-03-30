using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace Flytider
{
    public class FlygningService
    {        
        public void HentFlygninger(Flyplass flyplass, Action<List<Flygning>> callback)
        {
            string url = "http://flydata.avinor.no/XmlFeed.asp?TimeFrom=1&TimeTo=7&airport=" + flyplass.Kode;

            var webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.BeginGetResponse(responseResult =>
            {
                try
                {
                    var response = webRequest.EndGetResponse(responseResult);
                    if (response != null)
                    {
                        var result = ParseXml(response);
                        response.Close();
                        Deployment.Current.Dispatcher.BeginInvoke(() => callback(result));
                    }
                }
                catch (Exception)
                {
                    
                }
            }, webRequest);
        }

        private static List<Flygning> ParseXml(WebResponse response)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            using (var sr = new StreamReader(response.GetResponseStream(), encoding))
            using (var xmlReader = XmlReader.Create(sr))
            {
                var xml = XDocument.Load(xmlReader);

                var flygninger = 
                        from airport in xml.Elements("airport")
                        from flights in airport.Elements("flights")
                        from flight in flights.Elements("flight")
                        select new Flygning
                        {
                            Nummer = VerdiEllerTom(flight.Element("flight_id")),
                            Flyplass = VerdiEllerTom(flight.Element("airport")),
                            AnnkomstAvgang = VerdiEllerTom(flight.Element("arr_dep")),
                            Tidspunkt = Convert.ToDateTime(VerdiEllerTom(flight.Element("schedule_time")))
                        };

                return flygninger.ToList();
            }
        }
        
        private static string VerdiEllerTom(XElement element)
        {
            return element == null ? string.Empty : element.Value;
        }
    }
}
