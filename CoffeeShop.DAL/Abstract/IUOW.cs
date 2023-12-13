using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Abstract
{
    public interface IUOW
    {
        void SaveChanges();
        IRepository<T> GetGenericRepostory<T>() where T : class, IEntity;
        ICakeRepository GetCakeRepository();
        ICoffeeRepository GetCoffeeRepository();
        ICoffeeSizeRepository GetCoffeeSizeRepository();
        ICookyRepository GetCookyRepository();
        IExtraRepository GetExtraRepository();
        IOrderLineRepository GetOrderLineRepository();
        IOrderRepository GetOrderRepository();
    }
}
