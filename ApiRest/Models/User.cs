using System.Collections;
using System;

namespace ApiRest.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string Nick { get; set; }
        public string Clef { get; set; }
        public string Picture { get; set; }
        public DateTime DateInit { get; set; }
        public int Exp { get; set; }

    }
}