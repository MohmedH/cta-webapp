//
// One CTA Station
//

namespace program.Models
{

  public class Station
	{
	
		// data members with auto-generated getters and setters:
        public int StationID { get; set; }
		public string StationName { get; set; }
		public int AvgDailyRidership { get; set; }
        public int numStop { get; set; }
        public string ada { get; set; }
	
		// default constructor:
		public Station()
		{ }
		
		// constructor:
		public Station(int id, string name, int avgDailyRidership)
		{
			StationID = id;
			StationName = name;
			AvgDailyRidership = avgDailyRidership;
		}
		
	}//class

}//namespace