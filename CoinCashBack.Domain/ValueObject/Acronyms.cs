using CoinCashBack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.ValueObject
{
    public record Acronyms 
    {
        public string Value { get;}

        public Acronyms(string acronyms)
        {
            if (string.IsNullOrWhiteSpace(acronyms) 
                || acronyms.Length < 3)
            {
                throw new CCB_InvalidAcronymsException();
            }
            Value = acronyms.Trim();
        }

        public static implicit operator string (Acronyms acronyms)
            => acronyms.Value;

        public static implicit operator Acronyms (string value)
            => new Acronyms(value);
    }
}
