using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Activity : EntityBase
    {
        public Activity()
        {
            ActivityCosts = new HashSet<ActivityCosts>();
        }

        public string Name { get; set; }
        public int IndividualId { get; set; }
        public int TeamId { get; set; }
        public int ActivityGroupId { get; set; }
        
        public ActivityGroup ActivityGroup { get; set; }
        public Individual Individual { get; set; }
        public Team Team { get; set; }
        public ICollection<ActivityCosts> ActivityCosts { get; set; }
    }
}
