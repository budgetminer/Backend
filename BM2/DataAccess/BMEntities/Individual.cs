using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Individual : EntityBase
    {
        public Individual()
        {
            Activity = new HashSet<Activity>();
            Part = new HashSet<Part>();
        }

        public int DepartmentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int TeamId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Department Department { get; set; }
        public Team Team { get; set; }
        public ICollection<Activity> Activity { get; set; }
        public ICollection<Part> Part { get; set; }
    }
}
