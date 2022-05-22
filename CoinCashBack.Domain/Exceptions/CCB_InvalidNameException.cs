using System.Runtime.Serialization;

namespace CoinCashBack.Domain.Exceptions
{
    public class CCB_InvalidNameException : CCB_GenericException
    {
        public CCB_InvalidNameException() : base("Invalid Name")
        {
        }
    }
}