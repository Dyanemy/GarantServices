using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity; 

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Garant.Models
{
    public class User : IdentityUser
    {
        //public string Login { get; set;}
        //public string Email { get; set; }
        public int Pass { get; set;  }
        public int QurencyBallance { get; set; }
        public bool Active { get; set; }
        public int QurencyDeals { get; set; }
    }
}
