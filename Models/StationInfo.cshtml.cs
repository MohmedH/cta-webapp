using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class StationInfoModel : PageModel  
    {  
				public List<Models.Station> StationList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  StationList = new List<Models.Station>();
					
					// make input available to web page:
					Input = input;
					
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If not, there's nothing to do:
						//
						if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
						else  
						{
							// 
							// Lookup movie(s) based on input, which could be id or a partial name:
							// 
							string sql;

						  // lookup station(s) by partial name match:
							input = input.Replace("'", "''");

							sql = string.Format(@"
                            SELECT Stations.StationID, Stations.Name, AVG(DailyTotal) AS AvgDailyRidership
                            FROM Stations
                            LEFT JOIN Riderships ON Stations.StationID = Riderships.StationID
                            WHERE Stations.Name LIKE '%{0}%'
                            GROUP BY Stations.StationID, Stations.Name
                            ORDER BY Stations.Name ASC;", input);

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                            
                            sql = string.Format(@"
                            SELECT COUNT(Stops.StationID) as numStops, ISNULL(SUM(Convert(int,Stops.ADA)),0) as ADA, Stations.Name
                            FROM Stops
                            RIGHT JOIN Stations on Stations.StationID = Stops.StationID
                            WHERE Stations.Name LIKE '%{0}%'
                            GROUP BY Stations.StationID, Stations.Name, Stops.ADA
                            ORDER BY Stations.Name ASC", input);
                            
                            DataSet dsMore = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.Station s = new Models.Station();

								s.StationID = Convert.ToInt32(row["StationID"]);
								s.StationName = Convert.ToString(row["Name"]);

								// avg could be null if there is no ridership data:
								if (row["AvgDailyRidership"] == System.DBNull.Value)
									s.AvgDailyRidership = 0;
								else
									s.AvgDailyRidership = Convert.ToInt32(row["AvgDailyRidership"]);
                                    
                                foreach (DataRow rowM in dsMore.Tables[0].Rows)
                                {
                                    if(s.StationName == Convert.ToString(rowM["Name"]))
                                    {
                                        s.numStop = Convert.ToInt32(rowM["numStops"]);
                                        
                                        if(Convert.ToInt32(rowM["ADA"]) == s.numStop)
                                        {
                                            s.ada = "All";
                                        }
                                        else if(Convert.ToInt32(rowM["ADA"]) > 0)
                                        {
                                            s.ada = "Some";
                                        }
                                        else if(s.numStop == 0)
                                        {
                                            s.ada = "All";
                                        }
                                        else
                                        {
                                            s.ada = "None";
                                        }

                                    }
   
                                }
                                

								StationList.Add(s);
							}
                            
                            
						}//else
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
					  // nothing at the moment
				  }
				}
			
    }//class  
}//namespace