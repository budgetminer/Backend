﻿using BM2.Business.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Business.Readers.Definitions
{
    public interface IPartsReader : IReaderBase<Part>
    {
        Task<List<Part>> GetPartForPartGroupAndPartType(int partGroupId, int partTypeId);
    }
}
