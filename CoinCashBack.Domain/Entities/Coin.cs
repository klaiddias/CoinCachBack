using CoinCashBack.Domain.ValueObject;

namespace CoinCashBack.Domain.Entities
{
    public record Coin
    {
        private Name _name;
        private Acronyms _acronyms;

        public Coin(Name name, Acronyms acronyms, Price buyPrice, Exchange exchange)
        {
            _name = name;
            _acronyms = acronyms;
        }
    }
}