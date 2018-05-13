using DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace BM2
{
    public partial class Part : EntityBase
    {
        public Part()
        {
            Costs = new HashSet<Costs>();
        }

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

        public Individual Individual { get; set; }
        public PartsGroup Partsgroup { get; set; }
        public ICollection<Costs> Costs { get; set; }
        public PartType PartType { get; set; }
    }
}
