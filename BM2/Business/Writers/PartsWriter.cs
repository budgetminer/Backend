using BudgetMiner.Business.Base;
using BudgetMiner.Business.Writers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Writers
{
    public class PartsWriter : WriterBase<Part>, IPartsWriter
    {
        public PartsWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
