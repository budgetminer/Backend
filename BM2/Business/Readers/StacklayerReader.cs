using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
{
    public class StacklayerReader : ReaderBase<Stacklayer>, IStacklayerReader
    {
        public StacklayerReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
