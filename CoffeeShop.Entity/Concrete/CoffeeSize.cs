using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class CoffeeSize : BaseEntity
    {
        public CoffeeSize()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
