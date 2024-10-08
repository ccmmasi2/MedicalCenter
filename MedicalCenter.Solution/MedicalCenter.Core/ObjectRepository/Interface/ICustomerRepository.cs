﻿using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Models;

namespace MedicalCenter.Core.ObjectRepository.Interface
{
    public interface ICustomerRepository : IRepository<CustomerDTO>
    {
        Task<IEnumerable<CustomerDTO>> GetCustomersByIdentification(string partialIdentification);

    }
}
