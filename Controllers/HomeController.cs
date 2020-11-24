using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssinment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            
            return View();
        }


        public IActionResult About()
        {
            
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
        
    }
}
