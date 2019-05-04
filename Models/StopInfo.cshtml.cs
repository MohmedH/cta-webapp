using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class StopInfoModel : PageModel  
    {  
				public List<Models.Stops> StopList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
                    StopList = new List<Models.Stops>();
					
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
                            SELECT *
                            FROM Stops
                            RIGHT JOIN StopDetails 
                            ON Stops.StopID = StopDetails.StopID
                            LEFT JOIN Lines
                            ON Lines.LineID = StopDetails.LineID
                            WHERE StationID = '{0}'
                            GROUP BY Name, Stops.StopID, Stops.StationID, Stops.Direction, Stops.Direction, Stops.ADA, Stops.Latitude, Stops.Longitude, Stops.StopID, StopDetails.StopID, Lines.LineID, StopDetails.LineID, Lines.Color
                            ORDER BY Lines.Color ASC;", input);

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);
                            
							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.Stops s = new Models.Stops();

                                int iD = Convert.ToInt32(row["StopID"]);
                                
                                var myItem = StopList.Find(item => item.StopID == iD);
                                
                                if(myItem == null)
                                {
                                    s.StopID = iD;
                                    s.StationName = Convert.ToString(row["Name"]);
                                    s.direction = Convert.ToString(row["Direction"]);
                                    if(Convert.ToInt32(row["ADA"]) > 0)
                                        s.ada = "yes";
                                    else
                                        s.ada = "no";
                                    
                                    s.lat = Convert.ToString(row["Latitude"]);
                                    s.lon = Convert.ToString(row["Longitude"]);
                                    s.color = Convert.ToString(row["Color"]);
                                    
                                    StopList.Add(s);
                                }
                                else
                                {
                                   
                                    myItem.color += (";" + Convert.ToString(row["Color"]));
                                }
								
                                
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