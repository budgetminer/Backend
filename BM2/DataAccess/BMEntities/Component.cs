using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2.DataAccess.BMEntities
{
    public partial class Component : EntityBase
    {
        public Component()
        {
            PartsGroups = new HashSet<PartsGroup>();
        }

        public string Short { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<PartsGroup> PartsGroups { get; set; }
    }
}
