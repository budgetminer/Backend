using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Partsgroup : EntityBase
    {
        public Partsgroup()
        {
            Part = new HashSet<Part>();
        }

        public string Groupname { get; set; }
        public int StacklayerId { get; set; }
        public int ComponentId { get; set; }
        public string Comments { get; set; }

        public Component Component { get; set; }
        public Stacklayer Stacklayer { get; set; }
        public ICollection<Part> Part { get; set; }
    }
}
