using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class Extra : BaseEntity
    {
        public Extra()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public decimal Price { get; set; }


        #region Nav pro and FK
        public OrderLine OrderLine { get; set; }
        public string OrderLineId { get; set; }
        ICollection<Coffee>Coffees { get; set; }
        #endregion
    }
}
