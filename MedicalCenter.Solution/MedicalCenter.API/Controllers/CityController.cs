using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;
        private readonly ILogger<CityController> _logger;

        public CityController(ICityRepository cityRepository, ILogger<CityController> logger)
        {
            _cityRepository = cityRepository;
            _logger = logger;   
        }

        // GET: api/<ValuesController>
        [HttpGet("GetCitiesByDepartmentId")]
        public async Task<IActionResult> GetCitiesByDepartmentId(int departmentId)
        {
            var products = await _cityRepository.GetCitiesByDepartmentId(departmentId);
            return Ok(products);
        }
    }
}
