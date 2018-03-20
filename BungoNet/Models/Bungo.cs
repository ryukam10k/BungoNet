using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BungoNet.Models
{
    public class Bungo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string HowToRead { get; set; }

        public string Meaning { get; set; }

        public string Language { get; set; }

        public string Tags { get; set; }

        public string Source { get; set; }

        public string Memo { get; set; }

        public DateTime RegistTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}