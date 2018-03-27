﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Writers
{
    public class CustomerWriter : WriterBase<Customer>, ICustomerWriter
    {

        public CustomerWriter(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
