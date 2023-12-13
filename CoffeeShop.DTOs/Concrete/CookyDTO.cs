using CoffeeShop.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTOs.Concrete
{
    public class CookyDTO : IDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}
