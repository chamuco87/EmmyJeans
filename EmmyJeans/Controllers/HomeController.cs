using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Net;
using System.Net.Mail;
using System.Web.Http;

namespace EmmyJeans.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult BlogDetail()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Home2()
        {
            return View();
        }

        public ActionResult Home3()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }

        [System.Web.Http.HttpGet]
        public bool SendEmailMessage(string nombre, string telefono, string email, string mensaje)
        {


            var fromAddress = new MailAddress("roberto.ortiz@emmy-jeans.com", "Pagina de Internet");
            var toAddress = new MailAddress("roberto.ortiz@emmy-jeans.com", "Roberto Ortiz");
            const string fromPassword = "roberto123";
            const string subject = "Nuevo Mensaje";
            string body = nombre + telefono + email+ mensaje;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            return true;
        }
    }
}
