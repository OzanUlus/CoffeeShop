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
    public class CoffeeRepository : GenericRepository<Coffee>, ICoffeeRepository
    {
        public CoffeeRepository(AppDbContext appDbContext, DbSet<Coffee> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
