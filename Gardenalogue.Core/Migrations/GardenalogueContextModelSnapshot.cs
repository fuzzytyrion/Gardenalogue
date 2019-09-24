﻿// <auto-generated />
using Gardenalogue.Core.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gardenalogue.Core.Migrations
{
    [DbContext(typeof(GardenalogueContext))]
    partial class GardenalogueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gardenalogue.Core.Models.Garden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Gardens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "rights"
                        },
                        new
                        {
                            Id = 2,
                            Name = "pork"
                        },
                        new
                        {
                            Id = 3,
                            Name = "direct"
                        },
                        new
                        {
                            Id = 4,
                            Name = "beer"
                        },
                        new
                        {
                            Id = 5,
                            Name = "direct"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Post-ironic"
                        },
                        new
                        {
                            Id = 7,
                            Name = "mixtape"
                        },
                        new
                        {
                            Id = 8,
                            Name = "fanny"
                        },
                        new
                        {
                            Id = 9,
                            Name = "gastropub"
                        },
                        new
                        {
                            Id = 10,
                            Name = "richardson"
                        },
                        new
                        {
                            Id = 11,
                            Name = "cray"
                        },
                        new
                        {
                            Id = 12,
                            Name = "VHS"
                        },
                        new
                        {
                            Id = 13,
                            Name = "work"
                        },
                        new
                        {
                            Id = 14,
                            Name = "terry"
                        },
                        new
                        {
                            Id = 15,
                            Name = "butcher"
                        },
                        new
                        {
                            Id = 16,
                            Name = "irony"
                        },
                        new
                        {
                            Id = 17,
                            Name = "apparel"
                        },
                        new
                        {
                            Id = 18,
                            Name = "way"
                        },
                        new
                        {
                            Id = 19,
                            Name = "rights"
                        },
                        new
                        {
                            Id = 20,
                            Name = "tofu"
                        },
                        new
                        {
                            Id = 21,
                            Name = "truck"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Post-ironic"
                        },
                        new
                        {
                            Id = 23,
                            Name = "direct"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Post-ironic"
                        },
                        new
                        {
                            Id = 25,
                            Name = "number"
                        },
                        new
                        {
                            Id = 26,
                            Name = "viral"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
