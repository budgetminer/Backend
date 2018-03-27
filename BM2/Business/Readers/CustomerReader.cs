using DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.DataAccess.Entities;
using System.Linq;
using BM2.Business.Base;

namespace BM2.Business.Readers
{
    public class CustomerReader : ReaderBase<Customer>, ICustomerReader
    {

        public CustomerReader(IUnitOfWork uow ) : base(uow)
        {

        }

    }
}
