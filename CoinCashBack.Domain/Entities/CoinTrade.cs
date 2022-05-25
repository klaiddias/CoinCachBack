using CoinCashBack.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.Entities
{
    public class CoinTrade
    {
        public Guid Id { get; init; }

        private Price _sellPrice = 0;
        private Exchange _exchange;
        private DateOnly _sellDate;


        internal CoinTrade()
        {
            Id = id;
        }
    }
}
