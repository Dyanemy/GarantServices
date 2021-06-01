using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Models
{
    public class Deal
    {

        public int Id { get; set; }
        public string NameDeal { get; set; }
        public string Explanation { get; set; }
        public string IdAuthor { get; set; }
        public string IdExecutor { get; set; }
        public DateTime DataCreated { get; set; }
        public DateTime DataFinish { get; set; }
        public int QurencySumma { get; set; }
        public bool AcceptForAuthor { get; set; }
        public bool AcceptForExucator { get; set; }
        public bool FinishAcceptForAuthor { get; set; }
        public bool FinishAcceptForExecutor { get; set; }
        public string Status { get; set; }
        [NotMapped]
        public string ReturnUrl { get; set; }
        [NotMapped]
        public string LoginForExucator { get; set; }
        [NotMapped]
        public int DayForFinish { get; set; }
    }
}
