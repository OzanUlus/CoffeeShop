﻿using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class Cookie : BaseEntity
    {
        public string Name { get; set; }
        public string Describe { get; set; }
    }
}