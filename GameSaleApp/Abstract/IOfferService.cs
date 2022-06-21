using GameSale.Entities;

namespace GameSale.Abstract
{
    public interface IOfferService
    {
        public void Create(Offer offer);
        public void Update(Offer offer, Offer offerNew);
        public void Delete(Offer offer);
    }
}