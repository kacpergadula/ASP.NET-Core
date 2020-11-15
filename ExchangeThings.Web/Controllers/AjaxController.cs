using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeThings.Web.Database;
using ExchangeThings.Web.Entities;
using ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Web.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class AjaxController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;
        public AjaxController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Ajax Post(ExchangesModel exchange)
        {
            var res = new Ajax();
            res.success = true;

            var entity = new ItemEntity
            {
                Name = exchange.Name,
                Description = exchange.Description,
                IsVisible = exchange.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();


            return res;
        }
    }
}
