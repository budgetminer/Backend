using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class ActivityCosts : EntityBase
    {
        public decimal? Period { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Comment { get; set; }
        public decimal? Cost { get; set; }
        public int CosttypeId { get; set; }
        public int ActivityId { get; set; }

        public Activity Activity { get; set; }
        public CostType Costtype { get; set; }
    }
}
