using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Finance
    {
        public int Id { get; set; }
        public int NumberPhone { get; set; }
        public int Summa { get; set; }
        public DateTime DataCreated { get; set; }
        public string Status { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
