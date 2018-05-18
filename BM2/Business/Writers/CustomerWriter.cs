using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;

namespace BudgetMiner.Business.Writers
{
    public class CustomerWriter : WriterBase<Customer>, ICustomerWriter
    {

        public CustomerWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
