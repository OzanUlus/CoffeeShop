using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class Coffee : BaseEntity
    {
        public Coffee()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Describe { get; set; }


        #region Nav pro and FK
        public OrderLine OrderLine { get; set; }
        public string OrderLineId { get; set; }

        public string ImageId { get; set; }
        public Image Image { get; set; }
        public Extra Extra { get; set; }
        public string ExtraId { get; set; }
        public CoffeeSize CoffeeSize { get; set; }
        public string CoffeeSizeId { get; set; }
        #endregion
    }
}

