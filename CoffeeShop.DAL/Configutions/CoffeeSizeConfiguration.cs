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
    public class CoffeeSizeConfiguration : IEntityTypeConfiguration<CoffeeSize>
    {
        public void Configure(EntityTypeBuilder<CoffeeSize> builder)
        {

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Price).HasPrecision(3,2).IsRequired();

            
        }
    }
}
