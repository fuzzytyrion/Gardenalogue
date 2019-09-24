using System.Collections.Generic;
using System.Threading.Tasks;
using Gardenalogue.Core.Models;

namespace Gardenalogue.Core.Repos
{
    public interface IGardenRepository
    {
        Task Create(Garden garden);
        Task Delete(int id);
        Task<List<Garden>> GetAll();
        Task<Garden> GetByid(int id);
        Task Update(Garden garden);
    }
}