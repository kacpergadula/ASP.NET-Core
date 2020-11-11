using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Web.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class AjaxController : ControllerBase
    {
        public Ajax Post()
        {
            var res = new Ajax();
            res.success = true;
            return res;
        }
    }
}
