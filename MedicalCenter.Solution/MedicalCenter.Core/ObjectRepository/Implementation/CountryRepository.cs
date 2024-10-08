﻿using MedicalCenter.Core.BaseRepository;
using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;

namespace MedicalCenter.Core.ObjectRepository.Implementation
{
    public class CountryRepository : Repository<CountryDTO>, ICountryRepository
    {
        private readonly AppDbContext _dbcontext;

        public CountryRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
