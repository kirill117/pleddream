using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PledDream.Models
{
    [Serializable]
    public class MainViewModel
    {
        public ContactInfo ContactInfo { get; set; }
        public List<Color> Colors { get; set; }
    }
}