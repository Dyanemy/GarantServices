using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Message
    {
        public int id { get; set; }
        public int DialogID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User Sender { get; set; }
    }
}