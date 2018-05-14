using BM2.Business.Base;
using BM2.DataAccess.BMEntities;
using DataAccess;

namespace BM2.Business.Writers
{
    public class CustomerWriter : WriterBase<Customer>, ICustomerWriter
    {

        public CustomerWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
