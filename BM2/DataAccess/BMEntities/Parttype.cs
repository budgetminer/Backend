using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class PartType : EntityBase
    {
        public ICollection<Part> Parts { get; set; }
        public string Short { get; set; }
        public string Description { get; set; }
    }
}
