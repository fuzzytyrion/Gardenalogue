using Gardenalogue.Core.Contexts;
using Gardenalogue.Core.Enums;
using Gardenalogue.Core.Models;
using Gardenalogue.Data.GardenRepos;
using Gardenalogue.Service.GardenServices;
using Gardenalogue.Web.Controllers;
using GenFu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardenalogue.Test.GardenTests
{
    [TestFixture]
    public class GardensControllerTests
    {
        private IEnumerable<Garden> GetFakeData()
        {
            var i = 1;
            var gardens = A.ListOf<Garden>(26);
            gardens.ForEach(x => x.Id = i++);
            return gardens.Select(_ => _);
        }

        [Test]
        public async Task GetGarden()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GardensController_GetByIdGardenTest")
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
                var controller = new GardensController(new GardenService(new GardenRepository(context)));
                var result = await controller.Get(1) as ObjectResult;
                Assert.IsNotNull(result);
                Assert.IsTrue(result is OkObjectResult);
                Assert.IsInstanceOf<Garden>(result.Value);
                Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            }
        }

        [Test]
        public async Task GetGardens()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GardensController_GetAllGardenTest")
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
                var controller = new GardensController(new GardenService(new GardenRepository(context)));
                var result = await controller.Get() as ObjectResult;
                Assert.IsNotNull(result);
                Assert.IsTrue(result is OkObjectResult);
                Assert.IsInstanceOf<List<Garden>>(result.Value);
                Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            }
        }
        
        [Test]
        public async Task PostGarden()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GardensController_PostGardenTest")
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
                var controller = new GardensController(new GardenService(new GardenRepository(context)));
                var result = await controller.Post(new Garden() { Id = 27, Name = "sdfdsa" }) as NoContentResult;
                Assert.IsNotNull(result);
                Assert.IsTrue(result is NoContentResult);
                Assert.AreEqual(StatusCodes.Status204NoContent, result.StatusCode);
            }
        }

        [Test]
        public async Task PutGarden()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GardensController_PutGardenTest")
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
                var controller = new GardensController(new GardenService(new GardenRepository(context)));
                var result = await controller.Put(new Garden() { Id = 1, Name = "sdfdsa" }) as NoContentResult;
                Assert.IsNotNull(result);
                Assert.IsTrue(result is NoContentResult);
                Assert.AreEqual(StatusCodes.Status204NoContent, result.StatusCode);
            }
        }

        [Test]
        public async Task Delete()
        {
            // arrange
            var options = new DbContextOptionsBuilder<GardenalogueContext>()
                .UseInMemoryDatabase(databaseName: "GardensController_DeleteGardenTest")
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
                var controller = new GardensController(new GardenService(new GardenRepository(context)));
                var result = await controller.Delete(1) as NoContentResult;
                Assert.IsNotNull(result);
                Assert.IsTrue(result is NoContentResult);
                Assert.AreEqual(StatusCodes.Status204NoContent, result.StatusCode);
            }
        }
    }
}
