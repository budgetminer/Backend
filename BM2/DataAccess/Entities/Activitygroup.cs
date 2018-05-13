using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Activitygroup : EntityBase
    {
        public string Groupname { get; set; }
        public string Comments { get; set; }
        public decimal StacklayerId { get; set; }

        public Stacklayer Stacklayer { get; set; }
    }
}
