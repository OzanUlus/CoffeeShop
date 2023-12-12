using CoffeeShop.Entity.Abstract;
using CoffeeShop.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Configutions
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.HasOne(x => x.Order).WithMany(x => x.OrderLines).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.OrderLines).HasForeignKey(x => x.AppUserId);
          
        }
    }
}
