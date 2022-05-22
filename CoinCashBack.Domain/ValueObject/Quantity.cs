using CoinCashBack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.ValueObject
{
    public record Quantity
    {
        public decimal Value { get; }

        public Quantity(decimal value)
        {
            if (value < 0)
            {
                throw new CCB_InvalidQuantityException();
            }

            Value = value;
        }

        public static implicit operator decimal(Quantity quantity)
            => quantity.Value;
        public static implicit operator Quantity (decimal value)
            => new(value);
    }
}
