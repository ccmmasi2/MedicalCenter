using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class CityRepository : Repository<CityDTO>, ICityRepository
    {
        private readonly AppDbContext _dbcontext;

        public CityRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
