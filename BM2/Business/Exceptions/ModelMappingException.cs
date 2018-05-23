using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Exceptions
{
    public class ModelMappingException : BusinessException
    {
        public ModelMappingException()
        {
            Message = "Model komt niet overeen met data-contract";
        }
    }
}
