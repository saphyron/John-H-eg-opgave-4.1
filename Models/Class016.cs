namespace John_Høeg_opgave_4._1.Models
{
    public class Class016
    {
        public Class016(string s)
        {
            this.type = s.Substring(0, 3);
            this.counter = s.Substring(3, 8);

        }

        public string type { get; set; }
        public string counter { get; set; }

    }
}
