﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeThings.Web.Models
{
    public class ExchangesAddViewModel
    {
        public int NumberOfCharsInName { get; set; }

        public int NumberOfCharsInDescription { get; set; }

        public bool IsHidden { get; set; }
    }
}
