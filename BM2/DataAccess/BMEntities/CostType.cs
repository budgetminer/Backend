using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2.DataAccess.BMEntities
{
    public partial class CostType : EntityBase
    {
        public CostType()
        {
            ActivityCosts = new HashSet<ActivityCosts>();
            Costs = new HashSet<Costs>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<ActivityCosts> ActivityCosts { get; set; }
        public ICollection<Costs> Costs { get; set; }
    }
}
