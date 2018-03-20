using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BungoNet.Models
{
    public class Bungo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string HowToRead { get; set; }

        [DataType(DataType.MultilineText)]
        public string Meaning { get; set; }

        public string Language { get; set; }

        public string Tags { get; set; }

        [DataType(DataType.MultilineText)]
        public string Source { get; set; }

        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime RegistTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime UpdateTime { get; set; }
    }
}