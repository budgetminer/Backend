using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Stacklayer : EntityBase
    {
        public Stacklayer()
        {
            Activitygroup = new HashSet<ActivityGroup>();
            Partsgroup = new HashSet<PartsGroup>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<ActivityGroup> Activitygroup { get; set; }
        public ICollection<PartsGroup> Partsgroup { get; set; }
    }
}
