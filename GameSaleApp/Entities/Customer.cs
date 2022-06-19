using GameSale.Abstract;
using System.Collections.Generic;
using GameSale.Entitites;
using System;

namespace GameSale.Entities
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalityId { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}