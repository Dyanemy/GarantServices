using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Dialog
    {
        public int id { get; set; }
        public User Client { get; set; }
        public User Worker { get; set; }
    }
}
