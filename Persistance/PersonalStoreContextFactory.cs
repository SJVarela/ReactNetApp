using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance
{
    public class PersonalStoreContextFactory : IDesignTimeDbContextFactory<PersonalStoreDbContext>
    {
        public PersonalStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PersonalStoreDbContext>();

            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PersonalStore");
            return new PersonalStoreDbContext(builder.Options);
        }
    }
}
