using CoinCashBack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.ValueObject
{
    public record Name
    {
        public string Value { get; }

        public Name(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length == 0)
            {
                throw new CCB_InvalidNameException();
            }

            Value = nome.Trim();
        }

        public static implicit operator string(Name name)
            => name.Value;

        public static implicit operator Name (string value)
            => new(value);

    }
}
