using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactNetApp.Models;

namespace ReactNetApp.Services
{
    public class ProductService : IProductService
    {
        private StoreContext context;
        public ProductService(StoreContext context)
        {
            this.context = context;
        }
        public void Add(Product product)
        {
            context.Add(product);
            context.SaveChanges();
        }

        public Product Find(long id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToArray();
        }

        public void Remove(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}
