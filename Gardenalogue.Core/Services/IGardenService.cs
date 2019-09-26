using Gardenalogue.Core.Enums;
using Gardenalogue.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gardenalogue.Core.Services
{
    public interface IGardenService
    {
        Task<GardenRepositoryOutcome> Create(Garden garden);
        Task<GardenRepositoryOutcome> Delete(int id);
        Task<List<Garden>> GetAll();
        Task<Garden> GetByid(int id);
        Task<GardenRepositoryOutcome> Update(Garden garden);
    }
}
