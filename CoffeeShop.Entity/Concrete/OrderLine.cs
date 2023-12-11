using CoffeeShop.Entity.Abstract;

namespace CoffeeShop.Entity.Concrete
{
    public class OrderLine : BaseEntity
    {
        public OrderLine()
        {
            Id = Guid.NewGuid().ToString();
        }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        
        #region Nav pro and FK
        public virtual Order Order { get; set; }
        public string OrderId { get; set; }
       
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }

        public Coffee Coffee { get; set; }
        public string CoffeeId { get; set; }
        public Cake Cake { get; set; }
        public string CakeId { get; set; }
        public Cookie Cookie { get; set; }
        public string CookieId { get; set; }
        public CoffeeSize CoffeeSize { get; set; }
        public string CoffeeSizeId { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        #endregion


    }
}
