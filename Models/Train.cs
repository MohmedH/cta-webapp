using System;

namespace program.Models
{

  public class Train
	{
	
		// data members with auto-generated getters and setters:
        public int stationID { get; set; }
        public string stationName { get; set; }
        public string stopDestination { get; set; }

        public int routeNum { get; set; }

        public DateTime arrivalT { get; set; }
        public DateTime predictionT { get; set; }
        public string routeColor { get; set; }

        public TimeSpan difference { get; set; }
        
	
		// default constructor:
		public Train()
		{ }
		
		
	}//class

}//namespace