using ReactNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactNetApp.Services
{
    public interface IProductService
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Product Find(long id);
        void Update(Product product);
        void Remove(Product product);

    }
}
