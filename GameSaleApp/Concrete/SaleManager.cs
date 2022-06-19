using System;
using GameSale.Abstract;
using GameSale.Entities;
using GameSale.Entitites;

namespace GameSale.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sell(Customer customer, Game game, Offer offer=null)
        {
            if (offer == null)
            {
                Console.WriteLine($"{game.Name} game is sold to {customer.FirstName} {customer.LastName} with price {game.Price}.");
            }
            else
            {
                Console.WriteLine($"{game.Name} game is sold to {customer.FirstName} {customer.LastName} with offer {offer.Name} name and {offer.Discount} with price {game.Price* (100-offer.Discount)/100}.");
            }
        }
    }
}