using MedicalCenter.Core.Data;
using MedicalCenter.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace MedicalCenter.Core.Init
{
    public class DBInitializer : IDBInitializer
    {
        private readonly AppDbContext _db;

        public DBInitializer(AppDbContext db)
        {
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (!_db.IdentificationTypes.Any())
            {
                var LDataJson = File.ReadAllText("../MedicalCenter.Core/Data/SeedData/IdentificationTypes.json");
                var LData = JsonSerializer.Deserialize<List<IdentificationTypeDTO>>(LDataJson);
                _db.IdentificationTypes.AddRange(LData);
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();

            if (!_db.Countries.Any())
            {
                var LDataJson = File.ReadAllText("../MedicalCenter.Cor/Data/SeedData/Countries.json");
                var LData = JsonSerializer.Deserialize<List<CountryDTO>>(LDataJson);
                _db.Countries.AddRange(LData);
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();

            if (!_db.Departments.Any())
            {
                var LDataJson = File.ReadAllText("../MedicalCenter.Cor/Data/SeedData/Departments.json");
                var LData = JsonSerializer.Deserialize<List<DepartmentDTO>>(LDataJson);
                _db.Departments.AddRange(LData);
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();

            if (!_db.Cities.Any())
            {
                var LDataJson = File.ReadAllText("../MedicalCenter.Cor/Data/SeedData/Cities.json");
                var LData = JsonSerializer.Deserialize<List<CityDTO>>(LDataJson);
                _db.Cities.AddRange(LData);
            }

            if (_db.ChangeTracker.HasChanges())
                _db.SaveChanges();
        }
    }
}
