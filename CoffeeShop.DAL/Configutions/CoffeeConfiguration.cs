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
    public class CoffeeConfiguration : IEntityTypeConfiguration<Coffee>
    {
        public void Configure(EntityTypeBuilder<Coffee> builder)
        {

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Describe).HasMaxLength(250).IsRequired();

            builder.HasOne(x=>x.Extra).WithMany(x=>x.Coffees).HasForeignKey(x=>x.ExtraId);
            builder.HasOne(x=>x.CoffeeSize).WithMany(x=>x.Coffees).HasForeignKey(x=>x.CoffeeSizeId);
            builder.HasOne(x => x.OrderLine).WithMany(x => x.Coffees).HasForeignKey(x => x.OrderLineId);
            builder.HasOne(x => x.Image).WithOne(x => x.Coffee).HasForeignKey<Coffee>(x => x.ImageId);
        }
    }
}
