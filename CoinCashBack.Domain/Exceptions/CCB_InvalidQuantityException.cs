using System.Runtime.Serialization;

namespace CoinCashBack.Domain.Exceptions
{
    public class CCB_InvalidQuantityException : CCB_GenericException
    {
        public CCB_InvalidQuantityException() : base("Invalid Quantity")
        {
        }
    }
}