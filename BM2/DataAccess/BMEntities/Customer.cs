using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2.DataAccess.BMEntities
{
    public partial class Customer : EntityBase
    {
        public Customer()
        {
            Components = new HashSet<Component>();
            Individuals = new HashSet<Individual>();
        }

        public string Name { get; set; }
        public ICollection<Component> Components { get; set; }
        public ICollection<Individual> Individuals { get; set; }
    }
}
