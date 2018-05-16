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
    public class ComponentWriter : WriterBase<Component>, IComponentWriter
    {
        public ComponentWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
