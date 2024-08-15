using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IDepartmentRepository departmentRepository, ILogger<DepartmentController> logger)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;   
        }

        // GET: api/<ValuesController>
        [HttpGet("GetDepartmentsByCountryId")]
        public async Task<IActionResult> GetDepartmentsByCountryId(int countryId)
        {
            var products = await _departmentRepository.GetDepartmentsByCountryId(countryId);
            return Ok(products);
        }
    }
}
