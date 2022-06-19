using GameSale.Abstract;
using GameSale.Entities;

namespace GameSale.Concrete
{
    public class ValidationManager : IValidationService
    {
        public bool Validate(Customer customer)
        {
            return true;
        }
    }
}