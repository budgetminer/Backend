using Digipolis.DataAccess.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BM2.DataAccess.Entities
{
    public class Team : EntityBase
    {
        [Required] public string tmName { get; set; }
        public string tmLocation { get; set; }
        public string tmMission { get; set; }
        public string tmBudgetowner { get; set; }

        public Customer Customer { get; set; }
        public List<Level> Levels { get; set; }
    }
}
