using CoffeeShop.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class AppUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Cities City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
    }
}
