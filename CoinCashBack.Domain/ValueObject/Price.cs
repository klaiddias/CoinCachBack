using CoinCashBack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.ValueObject
{
    public record Price
    {
        public decimal Value { get;}

        public Price(decimal price)
        {
            if (price < 0)
            {
                throw new CCB_InvalidPriceException();
            }

            Value = price;
        }

        public static implicit operator decimal (Price price)
            => price.Value;
        public static implicit operator Price (decimal price)
            => new Price(price);
    }
}
