using System.Runtime.Serialization;

namespace CoinCashBack.Domain.Exceptions
{
    [Serializable]
    public class CCB_CoinAlreadyExistsException : CCB_GenericException
    {
        public CCB_CoinAlreadyExistsException():base("Coin already excists")
        {
        }
    }
}