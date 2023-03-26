namespace John_Høeg_opgave_4._1.Models
{
    public class Class001
    {
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


        public Class001(string s)
        {
            this.type = s.Substring(0, 3);
            this.kommuneCode = s.Substring(3, 4);
            this.roadCode = s.Substring(7, 4);
            this.timestamp = s.Substring(11, 12);
            this.roadToNextKommuneCode = s.Substring(23, 4);
            this.roadToNextRoadCode = s.Substring(27, 4);
            this.roadToPreviousKommuneCode = s.Substring(31, 4);
            this.roadToPreviousRoadCode = s.Substring(35, 4);
            this.startDate = s.Substring(39, 12);
            this.roadName = s.Substring(51, 20);
            this.ExpandedRoadName = s.Substring(71, 40);
        }
    }
}
