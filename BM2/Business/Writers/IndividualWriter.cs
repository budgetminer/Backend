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
    public class IndividualWriter : WriterBase<Individual>, IIndividualWriter
    {
        public IndividualWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
