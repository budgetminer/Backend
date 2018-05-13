using BM2.Business.Base;
using BM2.Business.Writers.Definitions;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Writers
{
    public class ComponentWriter : WriterBase<Component>, IComponentWriter
    {
        public ComponentWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
