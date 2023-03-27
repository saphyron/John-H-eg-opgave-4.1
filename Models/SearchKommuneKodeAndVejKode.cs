namespace John_Høeg_opgave_4._1.Models
{
    public class SearchKommuneKodeAndVejKode
    {
        public SearchKommuneKodeAndVejKode()
        {
            
        }

        public string type { get; set; }
        public string kommuneCode { get; set; }
        public string roadCode { get; set; }
        public string timestamp { get; set; }
        public string roadToNextKommuneCode { get; set; }
        public string roadToNextRoadCode { get; set; }
        public string roadToPreviousKommuneCode { get; set; }
        public string roadToPreviousRoadCode { get; set; }
        public string startDate { get; set; }
        public string roadName { get; set; }
        public string ExpandedRoadName { get; set; }

        
    }
}
