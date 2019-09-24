using Gardenalogue.Core.Models;
using GenFu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gardenalogue.Core.Contexts
{
    public class GardenalogueContext : DbContext
    {
        public GardenalogueContext(DbContextOptions<GardenalogueContext> options) : base(options) { }

        public GardenalogueContext() { }

        public DbSet<Garden> Gardens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding
            var i = 1;
            var gardensToSeed = A.ListOf<Garden>(26);
            gardensToSeed.ForEach(x => x.Id = i++);
            modelBuilder.Entity<Garden>().HasData(gardensToSeed);
        }
    }
}
