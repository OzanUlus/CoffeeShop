using CoffeeShop.DTOs.Base;
using CoffeeShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTOs.Concrete
{
    public class OrderLineDTO : IDTO
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public string OrderId { get; set; }

        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public string? AppUserNameAndSurname { get; set; }
        public ICollection<Extra> Extras { get; set; }

    }
}
