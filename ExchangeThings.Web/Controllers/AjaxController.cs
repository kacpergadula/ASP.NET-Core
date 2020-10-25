using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Web.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class AjaxController : Controller
    {
        public IActionResult Post()
        {
            return View();
        }
    }
}
