using CoinCashBack.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCashBack.Domain.Entities
{
    public class Portifolio
    {

        public Guid Id { get; private set; }
        private Name _name;
        private List<CoinTrade> _coins = new();


        public Portifolio(Guid id, Name name)
        {
            Id = id;
            _name = name;
        }

        public void AddCoin(CoinTrade coin)
        {
            bool alreadyExists = _coins.Any(c => c.Id == coin.Id);

            if (alreadyExists)
            {
                throw new CCB_CoinAlreadyExistsException();
            }
        
        }
    }
}
