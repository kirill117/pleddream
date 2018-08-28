using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PledDream.Models
{
    public class News
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        [XmlIgnore]
        public DateTime DateNews
        {
            get
            {
                return DateTime.ParseExact(Date, "dd.MM.yyyy", null);
            }
        }
    }
}