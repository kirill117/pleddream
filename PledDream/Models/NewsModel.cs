using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PledDream.Models
{
    [Serializable]
    public class NewsModel
    {
        public List<News> NewsList { get; set; }
    }
}