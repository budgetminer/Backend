using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BudgetMiner.DataAccess.BMEntities
{
    public partial class Team : EntityBase
    {
        public Team()
        {
            Activities = new HashSet<Activity>();
            Individuals = new HashSet<Individual>();
        }

        public string Name { get; set; }
        public string Comments { get; set; }

        public ICollection<Activity> Activities { get; set; }
        public ICollection<Individual> Individuals { get; set; }
    }
}
