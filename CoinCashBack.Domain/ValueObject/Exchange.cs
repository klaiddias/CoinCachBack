using CoinCashBack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.ValueObject
{
    public record Exchange
    {

        public string Value { get; }

        public Exchange(string value)
        {   
            if (string.IsNullOrWhiteSpace(value) || value.Length == 0) 
            {
                throw new CCB_InvalidExchangeNameException();
            }
            Value = value.Trim();
        }
    }
}
