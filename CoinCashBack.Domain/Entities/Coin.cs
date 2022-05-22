using CoinCashBack.Domain.ValueObject;

namespace CoinCashBack.Domain.Entities
{
    public record Coin
    {
        private Name _name;
        private Acronyms _acronyms;
        private Price _buyPrice;
        private Exchange _exchange;

        public Coin(Name name, Acronyms acronyms, Price buyPrice, Exchange exchange)
        {
            _name = name;
            _acronyms = acronyms;
            _buyPrice = buyPrice;
            _exchange = exchange;
        }

        public static implicit operator string (Coin coin)
            => coin.va
    }
}