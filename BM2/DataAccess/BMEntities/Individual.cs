using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2.DataAccess.BMEntities
{
    public partial class Individual : EntityBase
    {
        public Individual()
        {
            Activities = new HashSet<Activity>();
            Parts = new HashSet<Part>();
        }

        public int DepartmentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int TeamId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Department Department { get; set; }
        public Team Team { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
