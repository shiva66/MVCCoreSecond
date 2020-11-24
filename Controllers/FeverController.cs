using Microsoft.AspNetCore.Mvc;
using MVCAssinment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssinment2.Controllers
{
    public class FeverController : Controller
    {
        FeverService _feverService = new FeverService();
        //public IActionResult Fever()
        //{
        //    //List<Fever> fevers = _feverService.All();
        //    return View(fevers);
        //}
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int Temp)
        {
            _feverService.Add(Temp);

            return RedirectToAction(nameof(Fever));
          
        }
    }
}
