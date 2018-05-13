using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Costtype : EntityBase
    {
        public Costtype()
        {
            Activitycosts = new HashSet<Activitycosts>();
            Costs = new HashSet<Costs>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<Activitycosts> Activitycosts { get; set; }
        public ICollection<Costs> Costs { get; set; }
    }
}
