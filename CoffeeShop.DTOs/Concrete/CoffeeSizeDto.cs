﻿using CoffeeShop.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTOs.Concrete
{
    public class CoffeeSizeDto : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AdditionalPrice { get; set; }
    }
}
