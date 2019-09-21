using Gardenalogue.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gardenalogue.Core.Contexts
{
    public class GardenalogueContext : DbContext
    {
        public GardenalogueContext(DbContextOptions<GardenalogueContext> options) : base(options) { }

        public DbSet<Garden> Gardens { get; set; }
    }
}
