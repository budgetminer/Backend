using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Component : EntityBase
    {
        public Component()
        {
            Partsgroup = new HashSet<PartsGroup>();
        }

        public string Short { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<PartsGroup> Partsgroup { get; set; }
    }
}
