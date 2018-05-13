using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Activity : EntityBase
    {
        public Activity()
        {
            Activitycosts = new HashSet<Activitycosts>();
        }

        public string Name { get; set; }
        public decimal IndividualId { get; set; }
        public decimal TeamId { get; set; }

        public Individual Individual { get; set; }
        public Team Team { get; set; }
        public ICollection<Activitycosts> Activitycosts { get; set; }
    }
}
