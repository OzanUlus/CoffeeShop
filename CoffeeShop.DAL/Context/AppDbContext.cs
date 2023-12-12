using CoffeeShop.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option): base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<CoffeeSize> CoffeeSizes { get; set; }
        public DbSet<Cooky> Cookies { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
