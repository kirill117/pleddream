using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PledDream.Models
{
    [Serializable]
    public class Color
    {
        public int index { get; set; }
        public string name { get; set; }
        public string file { get; set; }
        public int amount { get; set; }
        public bool isnew { get; set; }
    }
}