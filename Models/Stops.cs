namespace program.Models
{

  public class Stops
	{
	
		// data members with auto-generated getters and setters:
        public int StopID { get; set; }
		public string StationName { get; set; }
		public string direction { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string ada { get; set; }
        public string color { get; set; }
        
	
		// default constructor:
		public Stops()
		{ }
		
		// constructor:
		public Stops(int id, string name)
		{
			StopID = id;
			StationName = name;
			
		}
		
	}//class

}//namespace