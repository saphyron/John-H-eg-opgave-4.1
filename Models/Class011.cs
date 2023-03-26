namespace John_Høeg_opgave_4._1.Models
{
    public class Class011
    {
        public Class011(string s)
        {
            this.type = s.Substring(0, 3);
            this.kommuneCode = s.Substring(3, 4);
            this.roadCode = s.Substring(7, 4);
            this.houseNumberFrom = s.Substring(11, 4);
            this.houseNumberTo = s.Substring(15, 4);
            this.evenUneven = s.Substring(19, 1);
            this.timestamp = s.Substring(20, 12);
            this.populationCode = s.Substring(32, 4);
            this.districtText = s.Substring(36, 30);

        }

        public string type { get; set; }
        public string kommuneCode { get; set; }
        public string roadCode { get; set; }
        public string houseNumberFrom { get; set; }
        public string houseNumberTo { get; set; }
        public string evenUneven { get; set; }
        public string timestamp { get; set; }
        public string populationCode { get; set; }
        public string districtText { get; set; }

    }
}
