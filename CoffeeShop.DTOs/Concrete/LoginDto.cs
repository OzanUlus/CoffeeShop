using CoffeeShop.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTOs.Concrete
{
    public class LoginDto : IDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
