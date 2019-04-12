using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAll();
        Product Get(long id);

    }
}
