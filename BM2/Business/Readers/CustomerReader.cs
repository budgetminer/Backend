using DataAccess;
using System;
using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;

namespace BudgetMiner.Business.Readers
{
    public class CustomerReader : ReaderBase<Customer>, ICustomerReader
    {
        private IUowProvider uowProvider;

        public CustomerReader(IUowProvider uowProvider ) : base(uowProvider)
        {
            this.uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }
    }
}
