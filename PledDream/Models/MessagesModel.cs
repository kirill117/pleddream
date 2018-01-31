using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PledDream.Models
{
    [Serializable]
    public class MessagesModel
    {
        public List<Message> Messages { get; set; }
    }
}