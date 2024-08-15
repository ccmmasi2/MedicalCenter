using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class CustomerRepository : Repository<CustomerDTO>, ICustomerRepository
    {
        private readonly AppDbContext _dbcontext;

        public CustomerRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomersByIdentification(string partialIdentification)
        {
            return await _dbcontext.Customers
                                   .Where(c => c.Identification.ToString().StartsWith(partialIdentification))
                                   .ToListAsync();
        }
    }
}
