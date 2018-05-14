using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Customer : EntityBase
    {
        public Customer()
        {
            Component = new HashSet<Component>();
            Individual = new HashSet<Individual>();
        }

        public string Name { get; set; }

        public ICollection<Component> Component { get; set; }
        public ICollection<Individual> Individual { get; set; }
    }
}
