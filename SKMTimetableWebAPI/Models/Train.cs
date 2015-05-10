using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKMTimetableWebAPI.Models
{
    public class Train
    {
        public string Id { get; set; }
        public string IdStart { get; set; }
        public string IdEnd { get; set; }
        public string TimetableDate { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Tip { get; set; }
    }
}