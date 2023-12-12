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

        public ICollection<Coffee> Coffees { get; set; }
        public ICollection<Cake> Cakes { get; set; }
        public ICollection<Cooky> Cookies { get; set; }
       
        #endregion


    }
}
