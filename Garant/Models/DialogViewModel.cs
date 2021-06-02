using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class DialogViewModel
    {
        public Dialog dialog { get; set; }
        public List<Message> Messages { get; set; }
    }
}
