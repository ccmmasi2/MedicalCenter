﻿using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Models;

namespace MedicalCenter.Core.ObjectRepository.Interface
{
    public interface ICityRepository : IRepository<CityDTO>
    {
        Task<List<CityDTO>> GetCitiesByDepartmentId(int departmentId);
    }
}
