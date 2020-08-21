﻿using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class MainConceptsContext : DbContext
    {
        public MainConceptsContext(DbContextOptions<MainConceptsContext> options) 
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Calculator> Calculator { get; set; }
        public DbSet<CalculatorType> CalculatorType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}