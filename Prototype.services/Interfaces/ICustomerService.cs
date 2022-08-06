using Microsoft.AspNetCore.Mvc;
using Prototype.Services.ViewModels.Customer;


namespace Prototype.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerCreateViewModel Get(int id);

        int Create(CustomerCreateViewModel viewModel);

    }
}
