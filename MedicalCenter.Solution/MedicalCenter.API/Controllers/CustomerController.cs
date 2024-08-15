using MedicalCenter.Core.Models;
using MedicalCenter.Core.ObjectRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerRepository customerRepository, ILogger<CustomerController> logger)
        {
            _customerRepository = customerRepository;
            _logger = logger;   
        }

        // GET: api/<ValuesController>
        [HttpGet("Create(customer)")]
        public async Task<IActionResult> Create(CustomerDTO customer)
        {
            try
            {
                await _customerRepository.Insert(customer);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while processing order request");
                return StatusCode(500, "An error occurred while processing the order request");
            }
        }

        [HttpGet("GetCustomersByIdentification")]
        public async Task<IEnumerable<CustomerDTO>> GetCustomersByIdentification([FromQuery] string partialIdentification)
        {
            return await _customerRepository.GetCustomersByIdentification(partialIdentification);
        }
    }
}
