using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Context;
using CoffeeShop.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext, DbSet<Order> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
