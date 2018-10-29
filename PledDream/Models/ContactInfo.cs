using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PledDream.Models
{
    [Serializable]
    public class ContactInfo
    {
        public string OrderEmail { get; set; }
        public string Phone { get; set; }
    }
}