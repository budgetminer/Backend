using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Stacklayer
    {
        public Stacklayer()
        {
            Activitygroup = new HashSet<Activitygroup>();
            Partsgroup = new HashSet<Partsgroup>();
        }

        public decimal Id { get; set; }
        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<Activitygroup> Activitygroup { get; set; }
        public ICollection<Partsgroup> Partsgroup { get; set; }
    }
}
