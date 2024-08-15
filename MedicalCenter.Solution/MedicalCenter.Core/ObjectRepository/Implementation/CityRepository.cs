using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class CityRepository : Repository<CityDTO>, ICityRepository
    {
        private readonly AppDbContext _dbcontext;

        public CityRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<CityDTO>> GetCitiesByDepartmentId(int departmentId)
        {
            IQueryable<CityDTO> query = _dbcontext.Cities;

            if (departmentId != 0)
            {
                query = query.Where(p => p.DepartmentId == departmentId);
            }

            var cities = await query
                            .Select(p => new CityDTO
                            {
                                ID = p.ID,
                                Name = p.Name,
                                DepartmentId = p.DepartmentId,
                            })
                            .ToListAsync();

            return cities;
        }
    }
}
