using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistance.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance
{
    public class PersonalStoreDbContext : DbContext
    {
        public PersonalStoreDbContext(DbContextOptions<PersonalStoreDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .ApplyConfiguration(new ProductConfiguration());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
