using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Garant.Models
{
    public class CommentsViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public string Login { get; set; }   
        public string Email { get; set; }
        public string  Message { get; set; }

    }
}
