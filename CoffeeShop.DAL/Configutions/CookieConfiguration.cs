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
    public class CookieConfiguration : IEntityTypeConfiguration<Cookie>
    {
        public void Configure(EntityTypeBuilder<Cookie> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);

           

            
            
        }
    }
}
