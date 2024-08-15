using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILogger<CountryController> _logger;

        public CountryController(ICountryRepository countryRepository, ILogger<CountryController> logger)
        {
            _countryRepository = countryRepository;
            _logger = logger;   
        }

        // GET: api/<ValuesController>
        [HttpGet("GetCountries")]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await _countryRepository.GetAll();
            return Ok(countries);
        } 
    }
}
