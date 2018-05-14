using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Stacklayer : EntityBase
    {
        public Stacklayer()
        {
            ActivityGroups = new HashSet<ActivityGroup>();
            PartsGroups = new HashSet<PartsGroup>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<ActivityGroup> ActivityGroups { get; set; }
        public ICollection<PartsGroup> PartsGroups { get; set; }
    }
}
