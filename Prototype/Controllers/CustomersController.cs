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


        //[HttpGet]
        //[Route("customer")]
        //public async Task<ActionResult<List<CustomerCreateViewModel>>> Get()
        //{
        //    return Ok(customers);
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCreateViewModel>> Get(int id)
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

        //[HttpPut]
        //public async Task<ActionResult<CustomerCreateViewModel>> UpdateCustomer(CustomerCreateViewModel request)
        //{
        //    var customer = customers.Find(c => c.Id == request.Id);
        //    if (customer == null)
        //    {
        //        return BadRequest("Customer not found");
        //    }
        //    customer.Name = request.Name;
        //    customer.Mail = request.Mail;
        //    customers.Add(customer);
        //    return Ok(customer);

        //}
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<CustomerCreateViewModel>> DeleteCustomer(string id)
        //{
        //    var customer = customers.Find(c => c.Id == id);
        //    if (customer == null)
        //    {
        //        return BadRequest("Customer not found");
        //    }
        //   customers.Remove(customer);

        //    return Ok(customers);

        //}

    }
}
