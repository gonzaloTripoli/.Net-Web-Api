using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype.Services.ViewModels.Customer;

namespace PrototypeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        [HttpGet]
        [Route("customer")]
        public dynamic listCustomers()
        {
            return new CustomerList
            {
                Mail = "asdasd@mail.com",

                 Name="Robox"

            };
        }

    }
}
