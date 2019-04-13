using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace Application.Services
{
    public class ProductsService : IProductsService
    {
        private PersonalStoreDbContext context;
        public ProductsService(PersonalStoreDbContext context)
        {
            this.context = context;
        }
        public Product Get(long id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToArray();
        }
    }
}
