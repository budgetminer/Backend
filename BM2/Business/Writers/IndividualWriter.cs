﻿using BM2.Business.Base;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Writers
{
    public class IndividualWriter : WriterBase<Individual>, IIndividualWriter
    {
        public IndividualWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
