﻿using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Models;

namespace MedicalCenter.Core.ObjectRepository.Interface
{
    public interface IDepartmentRepository : IRepository<DepartmentDTO>
    {
        Task<List<DepartmentDTO>> GetDepartmentsByCountryId(int countryId);
    }
}
