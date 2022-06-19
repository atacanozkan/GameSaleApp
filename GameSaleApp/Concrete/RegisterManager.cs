using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using GameSale.Abstract;
using GameSale.Entities;

namespace GameSale.Concrete
{
    public class RegisterManager
    {
        private List<Customer> customers;
        private IValidationService _iValidationService;

        public RegisterManager(IValidationService iValidationService)
        {
            customers = new List<Customer>();
            _iValidationService = iValidationService;
        }

        public void Create(Customer customer)
        {
            if (_iValidationService.Validate(customer))
            {
                Customer c = customers.FirstOrDefault(c => c.Id == customer.Id);

                if (c != null)
                {
                    Console.WriteLine($"{customer.Id} id customer is already registered.");
                }
                else
                {
                    Console.WriteLine($"{customer.Id} id customer is created.");
                    customers.Add(customer);
                }
            }
        }

        public void Update(Customer customer, Customer customerNew)
        {
            Customer c = customers.FirstOrDefault(c => c.Id == customer.Id);

            if (c == null)
            {
                Console.WriteLine($"{customer.Id} id customer is not registered.");
            }
            else
            {
                c.Id = customer.Id;
                c.NationalityId = customer.NationalityId;
                c.LastName = customer.LastName;
                c.DateOfBirth = customer.DateOfBirth;
                c.FirstName = customer.FirstName;
                Console.WriteLine($"{customer.Id} id customer is updated.");
            }
        }

        public void Delete(Customer customer)
        {
            Customer c = customers.FirstOrDefault(c => c.Id == customer.Id);

            if (c == null)
            {
                Console.WriteLine($"{customer.Id} id customer is not registered.");
            }
            else
            {
                customers.Remove(c);
                Console.WriteLine($"{customer.Id} id customer is deleted.");
            }
        }
    }
}