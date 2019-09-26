using Gardenalogue.Core.Contexts;
using Gardenalogue.Core.Enums;
using Gardenalogue.Core.Models;
using Gardenalogue.Data.GardenRepos;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardenalogue.Test.GardenTests
{
    [TestFixture]
    class GardenRepoTests
    {
        private IEnumerable<Garden> GetFakeData()
        {
            var i = 1;
            var gardens = A.ListOf<Garden>(26);
            gardens.ForEach(x => x.Id = i++);
            return gardens.Select(_ => _);
        }

        [Test]
        public async Task GetByIdGardenTest()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GetByIdGardenTest")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new GardenalogueContext(options))
            {
                context.Gardens.AddRange(GetFakeData());
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new GardenalogueContext(options))
            {
                var repo = new GardenRepository(context);
                var result = await repo.GetByid(1);
                Assert.IsNotNull(result);
            }
        }

        [Test]
        public async Task GetAllGardenTest()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GetAllGardenTest")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new GardenalogueContext(options))
            {
                context.Gardens.AddRange(GetFakeData());
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new GardenalogueContext(options))
            {
                var repo = new GardenRepository(context);
                var result = await repo.GetAll();
                Assert.AreEqual(26, result.Count);
            }
        }

        [Test]
        public async Task DeleteGardenTest()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "DeleteGardenTest")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new GardenalogueContext(options))
            {
                context.Gardens.AddRange(GetFakeData());
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new GardenalogueContext(options))
            {
                var repo = new GardenRepository(context);
                var result = await repo.Delete(1);
                var count = await repo.GetAll();
                Assert.AreEqual(25, count.Count);
                Assert.AreEqual(GardenRepositoryOutcome.Success, result);
            }
        }

        [Test]
        public async Task UpdateGardenTest()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "UpdateGardenTest")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new GardenalogueContext(options))
            {
                context.Gardens.AddRange(GetFakeData());
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new GardenalogueContext(options))
            {
                var repo = new GardenRepository(context);
                var result = await repo.Update(new Garden() { Id = 1, Name = "dsfds" });
                Assert.AreEqual(26, context.Gardens.ToList().Count);
                Assert.AreEqual(GardenRepositoryOutcome.Success, result);
            }
        }

        [Test]
        public async Task CreateGardenTest()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "CreateGardenTest")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new GardenalogueContext(options))
            {
                context.Gardens.AddRange(GetFakeData());
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new GardenalogueContext(options))
            {
                var repo = new GardenRepository(context);
                var result = await repo.Create(new Garden() { Id = 27, Name = "dsfds" });
                Assert.AreEqual(27, context.Gardens.ToList().Count);
                Assert.AreEqual(GardenRepositoryOutcome.Success, result);
            }
        }
    }
}
