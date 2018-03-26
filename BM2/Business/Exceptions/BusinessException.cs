using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Exceptions
{
    public class BusinessException
    {
        public BusinessException()
        {

        }

        public BusinessException(string message, string stackTrace)
        {
            Message = message;
            StackTrace = stackTrace;
        }

        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
