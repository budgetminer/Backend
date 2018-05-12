﻿using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Readers {
    public class LevelsReader : ReaderBase<Level>, ILevelsReader {
        public LevelsReader(IUowProvider uowProvider) : base(uowProvider) {

        }
    }
}
