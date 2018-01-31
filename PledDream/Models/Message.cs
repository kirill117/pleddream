using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PledDream.Models
{
    public class Message
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}