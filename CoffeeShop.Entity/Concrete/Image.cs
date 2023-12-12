using CoffeeShop.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity.Concrete
{
    public class Image : BaseEntity
    {
        public Image()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string ImageURL { get; set; }


        #region Nav pro and FK

        public Coffee Coffee { get; set; }
        public string CoffeeId { get; set; }
        public Cake Cake { get; set; }
        public string CakeId { get; set; }
        public Cookie Cookie { get; set; }
        public string CookieId { get; set; }

        #endregion
    }
}
