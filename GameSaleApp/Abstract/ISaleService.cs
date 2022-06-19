using GameSale.Entities;
using GameSale.Entitites;

namespace GameSale.Abstract
{
    public interface ISaleService
    {
        public void Sell(Customer customer, Game game, Offer offer);
    }
}