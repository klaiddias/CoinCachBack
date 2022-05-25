using CoinCashBack.Domain.ValueObject;

namespace CoinCashBack.Domain.Entities
{
    public record CoinBuy : Coin
    {

        private Price _buyPrice = 0;
        private DateOnly _buyDate;
        private Quantity _buyQuantity;


    }
}