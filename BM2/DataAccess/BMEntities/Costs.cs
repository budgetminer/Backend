using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2.DataAccess.BMEntities
{
    public partial class Costs : EntityBase
    {
        public int CosttypeId { get; set; }
        public decimal? Period { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Comment { get; set; }
        public decimal? Cost { get; set; }
        public int PartId { get; set; }

        public CostType Costtype { get; set; }
        public Part Part { get; set; }
    }
}
