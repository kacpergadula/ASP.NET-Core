using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Web.Controllers
{
    public class ExchangesController : Controller
    {

        public IActionResult Display()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Display(ExchangesModel exchanges)
        {
            var viewModel = new ExchangesAddViewModel
            {
                NumberOfCharsInName = exchanges.Name.Length,
                NumberOfCharsInDescription = exchanges.Description.Length,
                IsHidden = !exchanges.IsVisible
                
            };

            return View("ExchangesAdded", viewModel);
            //return RedirectToAction("ExchangesAdded");
        }

        /*[HttpGet]

        public IActionResult ExchangesAdded()
        {
            return View();
        }*/

    }
}
