using CoffeeShop.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Configutions
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.ImageURL).IsRequired();

            builder.HasOne(x=>x.Coffee).WithOne(x => x.Image).HasForeignKey<Image>(x=>x.CoffeeId);
            builder.HasOne(x=>x.Cookie).WithOne(x => x.Image).HasForeignKey<Image>(x=>x.CookieId);
            builder.HasOne(x=>x.Cake).WithOne(x => x.Image).HasForeignKey<Image>(x=>x.CakeId);

          
        }
    }
}
