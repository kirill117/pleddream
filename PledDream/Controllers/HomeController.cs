using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PledDream.Helpers;
using PledDream.Models;
using System.Text;

namespace PledDream.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Pleds()
        {
            var model = XMLHelper.Get<MainViewModel>();
            return View(model);
        }

        public ActionResult Caps()
        {
            var model = XMLHelper.Get<MainViewModel>();
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accessories()
        {          
            return View();
        }

        [HttpPost]
        public JsonResult SendOrder(string email, string name, string phone, string message)
        {
            var model = XMLHelper.Get<MainViewModel>();
            var result = 0;
            var sb = new StringBuilder();
            sb.AppendLine("Заказчик: "+ name);
            sb.AppendLine("Тел.: " + phone);
            sb.AppendLine("E-mail: " + email);
            sb.AppendLine(message);

            var recipient = model.ContactInfo.OrderEmail;

            if (EmailHelper.SendMail(recipient, sb.ToString(), "Новый заказ с сайта PledDream.ru"))
            {
                var orders = XMLHelper.Get<MessagesModel>();
                if (orders.Messages == null)
                    orders.Messages = new List<Message>();
                orders.Messages.Add(new Message() { Date = DateTime.Now, Text = sb.ToString() });
                XMLHelper.Save(orders);
                result = 1;
            }
            return Json(new { Result = result });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}