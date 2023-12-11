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
        public string UserName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
       
        public virtual List<OrderLine> OrderLines { get; set; }

    }
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        //ürünler nav prop olarak eklenecek

    }
}
