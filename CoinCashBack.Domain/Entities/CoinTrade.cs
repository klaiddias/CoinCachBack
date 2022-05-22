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
        private Name Name { get; init; }
        private Acronyms _acronyms;
        private Price _buyPrice;
        private Exchange _exchange;

        public Price? Price { get; }
        public Quantity Quantity { get; set; } = 0;
        public DateOnly? DateOnly { get; set; }
        public Price? _sellPrice { get; set; }
        public DateOnly? _sellDate { get; set; }

        internal CoinTrade(Guid id, Name _name, Acronyms acronyms,  Exchange exchange)
        {
            Id = id;
            Name = _name;
            _acronyms = acronyms;
            Price = price;
        }
    }
}
