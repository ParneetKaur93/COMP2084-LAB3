using PhoneApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {

            var phonelist = new List<Phone>
                {
                    new Phone{ PhoneId = 01, PhoneName = "SamsungJ8", Manufacturer = "Samsung"},
                new Phone { PhoneId = 02, PhoneName ="Oppo", Manufacturer = "Oppo"},


            };
            return View(phonelist);
        }
    }
}