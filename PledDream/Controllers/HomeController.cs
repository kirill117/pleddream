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
        public ActionResult Index()
        {
            var model = XMLHelper.Get<MainViewModel>();
            //model.ContactInfo = new ContactInfo();
            //model.Colors = new List<Color>();
            //model.Colors.Add(new Color() { index = 1, amount = 1, file = "natur.jpg", name = "Натуральный" });
            //model.Colors.Add(new Color() { index = 2, amount = 1, file = "cream.jpg", name = "Крем" });
            //model.Colors.Add(new Color() { index = 3, amount = 1, file = "sand.jpg", name = "Песочный" });
            //model.Colors.Add(new Color() { index = 4, amount = 1, file = "pudra.jpg", name = "Пудра" });
            //model.Colors.Add(new Color() { index = 5, amount = 1, file = "buble_gum_pink.jpg", name = "Розовый" });
            //model.Colors.Add(new Color() { index = 6, amount = 1, file = "dirt_rose.jpg", name = "Пыльная роза" });
            //model.Colors.Add(new Color() { index = 7, amount = 0, file = "hot_pink.jpg", name = "Теплый розовый" });
            //model.Colors.Add(new Color() { index = 8, amount = 1, file = "coral.jpg", name = "Коралл" });
            //model.Colors.Add(new Color() { index = 9, amount = 0, file = "brusnica.jpg", name = "Брусника" });
            //model.Colors.Add(new Color() { index = 10, amount = 0, file = "bordo.jpg", name = "Бордо" });
            //model.Colors.Add(new Color() { index = 11, amount = 1, file = "lemon.jpg", name = "Лимон" });
            //model.Colors.Add(new Color() { index = 12, amount = 1, file = "mustard.jpg", name = "Горчица" });
            //model.Colors.Add(new Color() { index = 13, amount = 1, file = "carrot.jpg", name = "Морковь" });
            //model.Colors.Add(new Color() { index = 14, amount = 1, file = "lilac.jpg", name = "Сирень" });
            //model.Colors.Add(new Color() { index = 15, amount = 1, file = "plum.jpg", name = "Слива" });
            //model.Colors.Add(new Color() { index = 16, amount = 1, file = "mint.jpg", name = "Мята" });
            //model.Colors.Add(new Color() { index = 17, amount = 1, file = "ocean.jpg", name = "Океан" });
            //model.Colors.Add(new Color() { index = 18, amount = 1, file = "turquoise.jpg", name = "Бирюза" });
            //model.Colors.Add(new Color() { index = 19, amount = 0, file = "grey_blue.jpg", name = "Серо-голубой" });
            //model.Colors.Add(new Color() { index = 20, amount = 1, file = "blue.jpg", name = "Голубой" });
            //model.Colors.Add(new Color() { index = 21, amount = 1, file = "cornflower.jpg", name = "Василек" });
            //model.Colors.Add(new Color() { index = 22, amount = 1, file = "sea.jpg", name = "Морская волна" });
            //model.Colors.Add(new Color() { index = 23, amount = 0, file = "grass.jpg", name = "Трава" });
            //model.Colors.Add(new Color() { index = 24, amount = 1, file = "grey_green.jpg", name = "Серо-зеленый" });
            //model.Colors.Add(new Color() { index = 25, amount = 0, file = "green.jpg", name = "Салатовый" });
            //model.Colors.Add(new Color() { index = 26, amount = 0, file = "cacao.jpg", name = "Какао" });
            //model.Colors.Add(new Color() { index = 27, amount = 0, file = "chocolate.jpg", name = "Шоколад" });
            //model.Colors.Add(new Color() { index = 28, amount = 1, file = "light_grey.jpg", name = "Светло-серый" });
            //model.Colors.Add(new Color() { index = 29, amount = 1, file = "grafit.jpg", name = "Графит" });
            //model.Colors.Add(new Color() { index = 30, amount = 0, file = "black.jpg", name = "Черный" });

            //XMLHelper.Save(model);

            return View(model);
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

            //if (EmailHelper.SendMail(recipient, sb.ToString(), "Новый заказ с сайта PledDream.ru"))
            System.Threading.Thread.Sleep(4000);
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