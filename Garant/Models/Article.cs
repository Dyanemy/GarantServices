using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Article
    {
        public int id { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public int TimeToRead { get; set; }
        public string Content { get; set; }
    }
}
