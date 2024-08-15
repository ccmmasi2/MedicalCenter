using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class DepartmentRepository : Repository<DepartmentDTO>, IDepartmentRepository
    {
        private readonly AppDbContext _dbcontext;

        public DepartmentRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<DepartmentDTO>> GetDepartmentsByCountryId(int countryId)
        {
            IQueryable<DepartmentDTO> query = _dbcontext.Departments;

            if (countryId != 0)
            {
                query = query.Where(p => p.CountryId == countryId);
            }

            var departments = await query
                            .Select(p => new DepartmentDTO
                            {
                                ID = p.ID,
                                Name = p.Name,
                                CountryId = p.CountryId,
                            })
                            .ToListAsync();

            return departments;
        } 
    }
}
