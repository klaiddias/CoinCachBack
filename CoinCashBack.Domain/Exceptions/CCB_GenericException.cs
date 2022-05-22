using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.Exceptions
{
    public abstract class CCB_GenericException : Exception
    {
        protected CCB_GenericException():this("Generic Exception")
        {
        }

        protected CCB_GenericException(string? message) : base(message)
        {
        }

        protected CCB_GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        protected CCB_GenericException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
