﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BudgetMiner.DataAccess.BMEntities
{
    public partial class PartType : EntityBase
    {
        public ICollection<Part> Parts { get; set; }
        public string Short { get; set; }
        public string Description { get; set; }
    }
}
