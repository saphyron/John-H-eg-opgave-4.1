namespace John_Høeg_opgave_4._1.Models
{
    public class Class002
    {
        public Class002(string s)
        {
            this.type = s.Substring(0, 3);
            this.kommuneCode = s.Substring(3, 4);
            this.roadCode = s.Substring(7, 4);
            this.houseNumber = s.Substring(11, 4);
            this.floornumber = s.Substring(15, 2);
            this.doorNumber = s.Substring(17, 4);
            this.timestamp = s.Substring(21, 12);
            this.filler1A = s.Substring(33, 1);
            this.startDate = s.Substring(34, 12);
            this.filler12N = s.Substring(46, 12);
            this.locale = s.Substring(58, 34);
        }

        public string type { get; set; }
        public string kommuneCode { get; set; }
        public string roadCode { get; set; }
        public string houseNumber { get; set; }
        public string floornumber { get; set; }
        public string doorNumber { get; set; }
        public string timestamp { get; set; }
        public string filler1A { get; set; }
        public string startDate { get; set; }
        public string filler12N { get; set; }
        public string locale { get; set; }


    }
}
