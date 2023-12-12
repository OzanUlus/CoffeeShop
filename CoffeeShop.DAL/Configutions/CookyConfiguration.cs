using CoffeeShop.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Configutions
{
    public class CookyConfiguration : IEntityTypeConfiguration<Cooky>
    {
       

        public void Configure(EntityTypeBuilder<Cooky> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Describe).IsRequired().HasMaxLength(250);

            builder.HasOne(x => x.Image).WithOne(x => x.Cookie).HasForeignKey<Cooky>(x => x.ImageId);
        }
    }
}
