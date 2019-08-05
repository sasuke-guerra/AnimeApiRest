using System;
using System.Collections;
using System.Collections.Generic;

namespace ApiRest.Models
{
    public class Anime
    {

        public string AnimeID { get; set; }
        public string Name { get; set; }
        public int CountEpisodes { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Creator { get; set; }
        public string Dateupload { get; set; }
        public DateTime ? Datebegin { get; set; }
        public DateTime ? Dateend { get; set; }

        public ICollection<Link> Link { get;  set; }
    }
}