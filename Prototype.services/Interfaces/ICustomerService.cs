using Microsoft.AspNetCore.Mvc;
using Prototype.Services.ViewModels.Customer;


namespace Prototype.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerCreateViewModel Get(string id);

        string Create(CustomerCreateViewModel viewModel);

        List<CustomerCreateViewModel> Get( );

        CustomerCreateViewModel Update(CustomerCreateViewModel viewModel);

        CustomerCreateViewModel Delete(string id);

    }
}
