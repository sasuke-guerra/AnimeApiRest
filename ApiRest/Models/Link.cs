using System;
namespace ApiRest.Models {

    public class Link
    {
        public string LinkID { get; set; }
        public string URL { get; set; }
        public int Number { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }
        public string Container { get; set; }
        public string Date { get; set; }

        public Anime Anime { get; set; }

    }
}
