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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.SurName).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.County).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Address).HasMaxLength(200).IsRequired();
           
        }
    }
}
