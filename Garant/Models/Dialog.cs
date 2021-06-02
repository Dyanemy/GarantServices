using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Dialog
    {
        public int id { get; set; }
        public string ClientId { get; set; }
        public string WorkerId { get; set; }

        [NotMapped]
        public User AnotherUser { get; set; }
    }
}
