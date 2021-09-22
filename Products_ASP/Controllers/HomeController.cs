using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Products_ASP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Products_ASP.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       

        public IActionResult Index()
        {
            // добавляем в вью бек нашу колекцию с бд телефонов для отображения
            ViewBag.Phones = PhoneRep.Select();
            return View();
        }

        public IActionResult NewProduct() => View();
        
        public IActionResult Add(Phone phone)
        {
            // если форма не аустая добавляем новый телефон
            if (phone.model != null && phone.manufacturer != null && phone.price != 0)
            { PhoneRep.Create(phone); }
            // возвращаемся на главную
            return Redirect("/Home/Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
