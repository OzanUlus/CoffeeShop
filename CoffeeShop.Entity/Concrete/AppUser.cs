﻿using CoffeeShop.Entity.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Cities City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }

        #region Nav pro and FK
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        #endregion
    }
}
