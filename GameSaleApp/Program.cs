using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using GameSale.Abstract;
using GameSale.Concrete;
using GameSale.Entities;
using GameSale.Entitites;

namespace GameSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Atacan";
            customer1.LastName = "Özkan";
            customer1.DateOfBirth = new DateTime(1985, 1, 1);
            customer1.NationalityId = "1111111111";

            Customer customer1Update = new Customer();
            customer1Update.Id = 1;
            customer1Update.FirstName = "Ata";
            customer1Update.LastName = "Özkan";
            customer1Update.DateOfBirth = new DateTime(1984, 1, 1);
            customer1Update.NationalityId = "11111111111";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Atacan";
            customer2.LastName = "Özkan";
            customer2.DateOfBirth = new DateTime(1985, 1, 1);
            customer2.NationalityId = "22222222222";

            Customer customer2Update = new Customer();
            customer2Update.Id = 2;
            customer2Update.FirstName = "Can";
            customer2Update.LastName = "Özkan";
            customer2Update.DateOfBirth = new DateTime(1983, 1, 1);
            customer2Update.NationalityId = "22222222222";

            RegisterManager registerManager = new RegisterManager(new MernisServiceReferenceAdapter());
            registerManager.Create(customer1);
            registerManager.Create(customer2);
            //registerManager.Update(customer1, customer1Update);
            //registerManager.Update(customer2, customer2Update);
            //registerManager.Delete(customer1);
            //registerManager.Delete(customer2);

            
            Offer offer1 = new Offer();
            offer1.Id = 1;
            offer1.Name = "Offer 1";
            offer1.Discount = 10;

            Offer offer2 = new Offer();
            offer2.Id = 2;
            offer2.Name = "Offer 2";
            offer2.Discount = 25;

            OfferManager offerManager = new OfferManager();
            offerManager.Create(offer1);
            offerManager.Create(offer2);

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Game 1";
            game1.Price = 100;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "Game 2";
            game2.Price = 200;

            SaleManager saleManager = new SaleManager();
            saleManager.Sell(customer1, game1, offer1);
            saleManager.Sell(customer2, game2);
        }

    }

}
