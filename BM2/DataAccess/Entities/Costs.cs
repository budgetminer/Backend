using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Costs : EntityBase
    {
        public decimal CosttypeId { get; set; }
        public decimal? Period { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Comment { get; set; }
        public decimal? Cost { get; set; }
        public decimal PartId { get; set; }

        public Costtype Costtype { get; set; }
        public Part Part { get; set; }
    }
}
