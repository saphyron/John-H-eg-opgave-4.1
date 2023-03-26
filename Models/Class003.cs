namespace John_Høeg_opgave_4._1.Models
{
    public class Class003
    {
        public Class003(string s)
        {
            this.type = s.Substring(0, 3);
            this.kommuneCode = s.Substring(3, 4);
            this.roadCode = s.Substring(7, 4);
            this.houseNumberFrom = s.Substring(11, 4);
            this.HouseNumberTo = s.Substring(15, 4);
            this.evenUneven = s.Substring(19, 1);
            this.timestamp = s.Substring(20, 12);
            this.townName = s.Substring(32, 34);

        }

        public string type { get; set; }
        public string kommuneCode { get; set; }
        public string roadCode { get; set; }
        public string houseNumberFrom { get; set; }
        public string HouseNumberTo { get; set; }
        public string evenUneven { get; set; }
        public string timestamp { get; set; }
        public string townName { get; set; }

    }
}
