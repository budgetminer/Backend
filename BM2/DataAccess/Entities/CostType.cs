using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class CostType : EntityBase
    {
        public CostType()
        {
            Activitycosts = new HashSet<ActivityCosts>();
            Costs = new HashSet<Costs>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<ActivityCosts> Activitycosts { get; set; }
        public ICollection<Costs> Costs { get; set; }
    }
}
