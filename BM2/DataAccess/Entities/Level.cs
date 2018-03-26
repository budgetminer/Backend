using Digipolis.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.Entities
{
    public class Level : EntityBase
    {
        [Required] public string lvName { get; set; }
        public string lvGrade { get; set; }
        public string lvBudgetowner { get; set; }
        public Customer Customer { get; set; }
        public Team Team { get; set; }
    }
}
