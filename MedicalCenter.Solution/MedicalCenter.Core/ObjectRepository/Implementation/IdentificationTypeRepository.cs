using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class IdentificationTypeRepository : Repository<IdentificationTypeDTO>, IIdentificationTypeRepository
    {
        private readonly AppDbContext _dbcontext;

        public IdentificationTypeRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
