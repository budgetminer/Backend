using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Team : EntityBase
    {
        public Team()
        {
            Activity = new HashSet<Activity>();
            Individual = new HashSet<Individual>();
        }

        public string Name { get; set; }
        public string Comments { get; set; }

        public ICollection<Activity> Activity { get; set; }
        public ICollection<Individual> Individual { get; set; }
    }
}
