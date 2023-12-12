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
    public class CakeConfiguration : IEntityTypeConfiguration<Cake>
    {
        public void Configure(EntityTypeBuilder<Cake> builder)
        {
           builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();
           builder.Property(x=>x.Describe).HasMaxLength(250).IsRequired();

            builder.HasOne(x => x.OrderLine).WithMany(x=>x.Cakes).HasForeignKey(x=>x.OrderLineId);
            builder.HasOne(x => x.Image).WithOne(x => x.Cake).HasForeignKey<Cake>(x => x.ImageId);
        }
    }
}
