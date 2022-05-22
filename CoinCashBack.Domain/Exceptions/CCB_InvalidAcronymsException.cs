using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.Exceptions
{
    public class CCB_InvalidAcronymsException : CCB_GenericException
    {
        public CCB_InvalidAcronymsException() : base("Invalid Acronyms")
        {
        }
    }
}
