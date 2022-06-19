using System;
using System.Collections.Generic;
using System.Text;
using GameSale.Entities;

namespace GameSale.Abstract
{
    public interface IValidationService
    {
        public bool Validate(Customer customer);
    }
}
