using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Models.ViewModels
{
    public class PartModel
    {
        public decimal? Vendor { get; set; }
        public string Name { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractExpiryDate { get; set; }
        public string Comments { get; set; }
        public int PartsGroupId { get; set; }
        public int IndividualId { get; set; }
        public int PartTypeId { get; set; }
        public decimal? Units { get; set; }
        public DateTime? Renawaldate { get; set; }
        public decimal? Yearlyincrease { get; set; }
        public string Metric { get; set; }

        public IndividualModel Individual { get; set; }
        public ICollection<CostModel> Costs { get; set; }
        public PartsTypeModel PartType { get; set; }
    }
}
