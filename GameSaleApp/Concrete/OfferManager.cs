using GameSale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameSale.Concrete
{
    public class OfferManager
    {
        private List<Offer> offers;

        public OfferManager()
        {
            offers = new List<Offer>();
        }

        public void Create(Offer offer)
        {
            Offer c = offers.FirstOrDefault(c => c.Id == offer.Id);

            if (c != null)
            {
                Console.WriteLine($"{offer.Id} id offer is already registered.");
            }
            else
            {
                Console.WriteLine($"{offer.Id} id offer is created.");
                offers.Add(offer);
            }
        }

        public void Update(Offer offer, Offer offerNew)
        {
            Offer o = offers.FirstOrDefault(o => o.Id == offer.Id);

            if (o == null)
            {
                Console.WriteLine($"{offer.Id} id offer is not registered.");
            }
            else
            {
                o.Id = offer.Id;
                o.Name = offer.Name;
                o.Discount = offer.Discount;

                Console.WriteLine($"{offer.Id} id offer is updated.");
            }
        }

        public void Delete(Offer offer)
        {
            Offer o = offers.FirstOrDefault(o => o.Id == offer.Id);

            if (o == null)
            {
                Console.WriteLine($"{offer.Id} id offer is not registered.");
            }
            else
            {
                offers.Remove(o);
                Console.WriteLine($"{offer.Id} id offer is deleted.");
            }
        }
    }
}