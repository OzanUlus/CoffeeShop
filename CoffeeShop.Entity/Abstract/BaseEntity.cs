using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Abstract
{
    public class BaseEntity : IEntity
    {
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public string? ModifieddBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
