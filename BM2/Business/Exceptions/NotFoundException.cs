using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Exceptions
{
    public class NotFoundException : BusinessException
    {
        public NotFoundException()
        {
            Message = "Entity Not Found";
        }
    }
}
