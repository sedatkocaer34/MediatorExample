using MediatorExample.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Data.Context
{
    public class MediatorExampleDataContext:DbContext
    {
        public MediatorExampleDataContext(DbContextOptions<MediatorExampleDataContext> dbContextOptions):base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Product { get; set; }
    }
}
