namespace John_Høeg_opgave_4._1.Models
{
    public class Class005
    {
        public Class005(string s)
        {
            this.type = s.Substring(0, 3);
            this.kommuneCode = s.Substring(3, 4);
            this.roadCode = s.Substring(7, 4);
            this.populationRegisterNote = s.Substring(11, 2);
            this.populationRegisterLine = s.Substring(13, 40);
            this.timestamp = s.Substring(53, 12);
            this.startDate = s.Substring(65, 12);

        }

        public string type { get; set; }
        public string kommuneCode { get; set; }
        public string roadCode { get; set; }
        public string populationRegisterNote { get; set; }
        public string populationRegisterLine { get; set; }
        public string timestamp { get; set; }
        public string startDate { get; set; }

    }
}
