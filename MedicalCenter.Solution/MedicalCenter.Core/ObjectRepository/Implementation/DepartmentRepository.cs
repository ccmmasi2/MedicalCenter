using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class DepartmentRepository : Repository<DepartmentDTO>, IDepartmentRepository
    {
        private readonly AppDbContext _dbcontext;

        public DepartmentRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
