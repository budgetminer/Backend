using System;

namespace BM2.Models.ViewModels
{
    public class CostModel
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int CostTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Cost { get; set; }

        public CostTypeModel CostType { get; set; }
    }
}