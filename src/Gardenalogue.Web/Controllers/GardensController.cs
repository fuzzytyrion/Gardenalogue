using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gardenalogue.Core.Models;
using Gardenalogue.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gardenalogue.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GardensController : ControllerBase
    {
        private readonly IGardenService _gardenService;

        public GardensController(IGardenService gardenService)
        {
            _gardenService = gardenService;
        }

        // GET: api/Gardens
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _gardenService.GetAll());
        }

        // GET: api/Gardens/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _gardenService.GetByid(id));
        }

        // POST: api/Gardens
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Garden value)
        {
            await _gardenService.Create(value);
            return NoContent();
        }

        // PUT: api/Gardens/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Garden value)
        {
            await _gardenService.Update(value);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _gardenService.Delete(id);
            return NoContent();
        }
    }
}
