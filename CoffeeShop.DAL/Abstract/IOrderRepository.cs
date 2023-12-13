﻿using CoffeeShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
