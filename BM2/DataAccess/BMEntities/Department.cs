using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Department : EntityBase
    {
        public Department()
        {
            Individual = new HashSet<Individual>();
        }

        public string Short { get; set; }
        public string Description { get; set; }

        public ICollection<Individual> Individual { get; set; }
    }
}
