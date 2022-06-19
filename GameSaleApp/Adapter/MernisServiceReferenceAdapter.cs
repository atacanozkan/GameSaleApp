using System;
using GameSale.Abstract;
using GameSale.Entities;
using GameSale.Entitites;
using MernisServiceReference;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameSale.Concrete
{
    class MernisServiceReferenceAdapter: IValidationService
    {
        public bool Validate(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            bool result = client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), 
                                                customer.FirstName.ToUpper(),
                                                customer.LastName.ToUpper(), 
                                                customer.DateOfBirth.Year);

            Console.WriteLine($"{customer.Id} id customer is {(result?"":"not ")}validated.");
            return result;
        }
    }
}