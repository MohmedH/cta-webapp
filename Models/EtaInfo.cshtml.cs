using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace program.Pages
{
    public class EtaInfoModel : PageModel
    {
        public List<Models.Train> TrainList { get; set; }
        public string Input { get; set; }
        public Exception EX { get; set; }

        static string APIKEY = String.Format("4c22a9bcff214bebbaa36d6e024c9d8f");

        public void OnGet(string input)
        {

            TrainList = new List<Models.Train>();

            // make input available to web page:
            Input = input;

            // clear exception:
            EX = null;

            if (input == null)
            {
                //
                // there's no page argument, perhaps user surfed to the page directly?  
                // In this case, nothing to do.
                //
            }
            else
            {
                string sql;

                input = input.Replace("'", "''");

                sql = string.Format(@"
                SELECT StationID, Name FROM Stations
                WHERE Name LIKE '%{0}%'
                GROUP BY Name,StationID;", input);

                DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    string StationID = Convert.ToString(row["StationID"]);

                    string strurl = String.Format("http://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?key={0}&mapid={1}&outputType=JSON", APIKEY, StationID);
                    WebRequest request = WebRequest.Create(strurl);
                    request.Method = "GET";
                    HttpWebResponse response = null;

                    response = (HttpWebResponse)request.GetResponse();

                    string result = null;

                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader sr = new StreamReader(stream);
                        result = sr.ReadToEnd();
                        sr.Close();
                    }

                    try
                    {
                        var token = JObject.Parse(result);

                        var times = token["ctatt"]["eta"];

                        foreach (var time in times)
                        {
                            Models.Train t = new Models.Train();

                            t.stationID = (int)time["staId"];
                            t.stationName = (string)time["staNm"];
                            t.stopDestination = (string)time["stpDe"];
                            t.routeNum = (int)time["rn"];
                            t.routeColor = (string)time["rt"];
                            t.arrivalT = (DateTime)time["arrT"];
                            t.predictionT = (DateTime)time["prdt"];

                            System.TimeSpan diff = t.arrivalT.Subtract(t.predictionT);
                            t.difference = diff;

                            TrainList.Add(t);
                        }

                    }
                    catch (Exception ex)
                    {
                        EX = ex;
                    }
                    finally
                    {
                        // nothing at the moment
                    }

                }

            }

        }

    }//class  
}//namespace