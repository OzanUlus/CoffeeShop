using CoffeeShop.Entity.Abstract;
using CoffeeShop.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class Order : BaseEntity
    {
        
        public string OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStates OrderState { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }

    }
 }
