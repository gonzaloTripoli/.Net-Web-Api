using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype.Services.Interfaces;
using Prototype.Services.ViewModels.Customer;


namespace PrototypeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        [Route("customer")]
        public async Task<ActionResult<List<CustomerCreateViewModel>>> Get()
        {
            var customers = _customerService.Get();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCreateViewModel>> Get(string id)
        {
            var customer = _customerService.Get(id);
            if (customer == null)
            {
                return BadRequest("Customer not found");
            }
            return Ok(customer);
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddCustomer(CustomerCreateViewModel customer)
        {
            var id = _customerService.Create(customer);
            return Ok(id);

        }

        [HttpPut]
        public async Task<ActionResult<CustomerCreateViewModel>> UpdateCustomer(CustomerCreateViewModel request)
        {
            var customer = _customerService.Update(request);
            if (customer == null)
            {
                return BadRequest("Customer not found");
            }

            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerCreateViewModel>> DeleteCustomer(string id)
        {
            var customer = _customerService.Delete(id);
            if (customer == null)
            {
                return BadRequest("Customer not found");
            }
            

            return Ok(customer);

        }


    }
}
