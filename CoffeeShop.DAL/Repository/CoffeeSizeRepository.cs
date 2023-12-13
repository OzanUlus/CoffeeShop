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
    public class CoffeeSizeRepository : GenericRepository<CoffeeSize>, ICoffeeSizeRepository
    {
        public CoffeeSizeRepository(AppDbContext appDbContext, DbSet<CoffeeSize> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
