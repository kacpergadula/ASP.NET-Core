using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExchangeThings.Web.Models
{
    public class ExchangesModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }
    }
}
