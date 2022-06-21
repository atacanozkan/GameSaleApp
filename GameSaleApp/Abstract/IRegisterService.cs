using GameSale.Entities;

namespace GameSale.Abstract
{
    public interface IRegisterService
    {
        public void Create(Customer customer);
        public void Update(Customer customer, Customer customerNew);
        public void Delete(Customer customer);
    }
}