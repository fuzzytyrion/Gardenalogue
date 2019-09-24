﻿using Gardenalogue.Core.Contexts;
using Gardenalogue.Core.Models;
using Gardenalogue.Core.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gardenalogue.Data.GardenRepos
{
    public class GardenRepository : IGardenRepository
    {
        private readonly GardenalogueContext _gardenContext;

        public GardenRepository(GardenalogueContext gardenContext)
        {
            _gardenContext = gardenContext;
        }

        public async Task<List<Garden>> GetAll()
        {
            return await _gardenContext.Gardens.AsNoTracking().ToListAsync();
        }

        public async Task<Garden> GetByid(int id)
        {
            return await _gardenContext.Gardens.AsNoTracking().SingleOrDefaultAsync(g => g.Id == id);
        }

        public async Task Create(Garden garden)
        {
            await _gardenContext.Gardens.AddAsync(garden);
            await _gardenContext.SaveChangesAsync();
        }

        public async Task Update(Garden garden)
        {
            _gardenContext.Update(garden);
            await _gardenContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var gardenToDelete = await _gardenContext.Gardens.FindAsync(id);
            _gardenContext.Gardens.Remove(gardenToDelete);
        }


    }
}
