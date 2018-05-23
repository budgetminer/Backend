using BudgetMiner.Business.Base;
using BudgetMiner.Business.Writers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;

namespace BudgetMiner.Business.Writers
{
    public class StacklayerWriter : WriterBase<Stacklayer>, IStacklayerWriter
    {
        public StacklayerWriter(IUowProvider uowProvider) : base(uowProvider)
        {

        }
    }
}
