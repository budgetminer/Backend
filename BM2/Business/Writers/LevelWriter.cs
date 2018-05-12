using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Writers
{
    public class LevelWriter : WriterBase<Level>, ILevelWriter
    {
        public LevelWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
