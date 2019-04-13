using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance
{
    public class DbSeeder
    {
        public void SeedAll(PersonalStoreDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }
            SeedProducts(context);
        }

        private void SeedProducts(PersonalStoreDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
