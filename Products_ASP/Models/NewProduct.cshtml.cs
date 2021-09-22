using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Products_ASP.Models;

namespace Products_ASP.Views.Home
{
    public class NewProductModel : PageModel
    {
        public Phone phone { get; set; }
        public void OnGet()
        {
        }
    }
}
