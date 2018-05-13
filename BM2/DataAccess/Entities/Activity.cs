using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Activity : EntityBase
    {
        public Activity()
        {
            Activitycosts = new HashSet<ActivityCosts>();
        }

        public string Name { get; set; }
        public int IndividualId { get; set; }
        public int TeamId { get; set; }

        public Individual Individual { get; set; }
        public Team Team { get; set; }
        public ICollection<ActivityCosts> Activitycosts { get; set; }
    }
}
