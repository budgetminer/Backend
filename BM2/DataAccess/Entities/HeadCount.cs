using DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace BM2.DataAccess.Entities
{
    public class HeadCount : EntityBase
    {
        public string Budgetowner { get; set; }
        [Required] public string Year { get; set; }
        public string hcNofte { get; set; }
        public string hcFtegr { get; set; }
        public string HcFtecost { get; set; }
        public string hcFteextern { get; set; }
        public Customer Customer { get; set; }
        public Team Team { get; set; }
        public Level Level { get; set; }
    }
}
