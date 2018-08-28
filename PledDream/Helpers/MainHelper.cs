using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PledDream.Models;

namespace PledDream.Helpers
{
    public static class MainHelper
    {
        public static List<News> GetNews()
        {
            var list = new List<News>();
            try
            {
                var model = XMLHelper.Get<NewsModel>();
                list = model.NewsList.OrderByDescending(o => o.DateNews).ToList();
            }
            catch { }
            return list;
        }
    }
}