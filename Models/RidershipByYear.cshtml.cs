using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class RidershipByYearModel : PageModel  
    {  
        public List<int> Years { get; set; }
        public List<int> NumRiders { get; set; }
        public Exception EX { get; set; }
  
        public void OnGet()  
        {
          Years = new List<int>();
          NumRiders = new List<int>();
          
          EX = null;
          
          try
          {
            string sql = string.Format(@"
            SELECT YEAR(TheDate) AS TheYear, Sum(DailyTotal) AS NumRiders
            FROM Riderships
            GROUP BY YEAR(TheDate)
            ORDER BY YEAR(TheDate);
            ");
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
              int numriders = Convert.ToInt32(row["NumRiders"]);
              int yearNum = Convert.ToInt32(row["TheYear"]);

              NumRiders.Add(numriders);
              Years.Add(yearNum);
            }
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