using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAssignmentAvSoft.Models;

namespace TestAssignmentAvSoft.Infrastructure
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<CounterModel> Counters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CounterModel>().HasData(
                new CounterModel() { Id = 1, Value = 1, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 1, Value = 2, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 1, Value = 3, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 2, Value = 1, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 2, Value = 1, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 2, Value = 3, Guid = Guid.NewGuid() },
                new CounterModel() { Id = 2, Value = 1, Guid = Guid.NewGuid() });
        }
    }



}
