﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BudgetMiner.DataAccess.BMEntities
{
    public partial class ActivityGroup : EntityBase
    {
        public string Groupname { get; set; }
        public string Comments { get; set; }
        public int StacklayerId { get; set; }

        public Stacklayer Stacklayer { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
