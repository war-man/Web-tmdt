﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.ProductDetails
{
    public class LoadDetailsViewModel
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public List<string> ListSize { get; set; }
        public string Color { get; set; }
        public string ListImage { get; set; }
        public string Descrtiption { get; set; }
    }
}