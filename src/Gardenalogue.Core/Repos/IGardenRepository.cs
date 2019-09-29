using System.Collections.Generic;
using System.Threading.Tasks;
using Gardenalogue.Core.Enums;
using Gardenalogue.Core.Models;

namespace Gardenalogue.Core.Repos
{
    public interface IGardenRepository
    {
        Task<GardenRepositoryOutcome> Create(Garden garden);
        Task<GardenRepositoryOutcome> Delete(int id);
        Task<List<Garden>> GetAll();
        Task<Garden> GetByid(int id);
        Task<GardenRepositoryOutcome> Update(Garden garden);
    }
}