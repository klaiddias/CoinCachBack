using System.Runtime.Serialization;

namespace CoinCashBack.Domain.Exceptions
{
    public class CCB_InvalidExchangeNameException : CCB_GenericException
    {
        public CCB_InvalidExchangeNameException():base("Invalid Exchange Name")
        {
        }
    }
}