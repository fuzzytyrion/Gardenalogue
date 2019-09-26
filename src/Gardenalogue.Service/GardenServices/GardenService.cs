using Gardenalogue.Core.Enums;
using Gardenalogue.Core.Models;
using Gardenalogue.Core.Repos;
using Gardenalogue.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gardenalogue.Service.GardenServices
{
    public class GardenService : IGardenService
    {
        private readonly IGardenRepository _gardenRepository;

        public GardenService(IGardenRepository gardenRepository)
        {
            _gardenRepository = gardenRepository;
        }

        public Task<GardenRepositoryOutcome> Create(Garden garden)
        {
            return _gardenRepository.Create(garden);
        }

        public Task<GardenRepositoryOutcome> Delete(int id)
        {
            return _gardenRepository.Delete(id);
        }

        public Task<List<Garden>> GetAll()
        {
            return _gardenRepository.GetAll();
        }

        public Task<Garden> GetByid(int id)
        {
            return _gardenRepository.GetByid(id);
        }

        public Task<GardenRepositoryOutcome> Update(Garden garden)
        {
            return _gardenRepository.Update(garden);
        }
    }
}
