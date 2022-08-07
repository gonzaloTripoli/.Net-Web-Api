using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prototype.DAL;
using Prototype.Services.Interfaces;
using Prototype.Services.ViewModels.Customer;
using PrototypeApp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private PrototypeDbContext _context { get; set; }

        private IMapper _mapper { get; set; }

        public CustomerService(PrototypeDbContext context,
           IMapper mapper)
        {
            _context = context != null ? context : throw new ArgumentNullException(nameof(context));
            _mapper = mapper != null ? mapper : throw new ArgumentNullException(nameof(mapper));
        }

        public CustomerCreateViewModel Get(string id)
        {

            var customer = GetCustomer(id);
            customer.Orders = new List<Order>();
            var viewModel = _mapper.Map<CustomerCreateViewModel>(customer);

            return viewModel;


        }

        public string Create(CustomerCreateViewModel viewModel)
        {
            Customer customer = _mapper.Map<Customer>(viewModel);
            _context.Add(customer);

            _context.SaveChanges();
            return viewModel.Id;
        }


        public List<CustomerCreateViewModel> Get()
        {
            List<CustomerCreateViewModel> customerList = new List<CustomerCreateViewModel>();
            customerList.InsertRange(0, _context.Customer.Select(x => _mapper.Map<CustomerCreateViewModel>(x)));
            return customerList;
        }

        public CustomerCreateViewModel Update(CustomerCreateViewModel viewModel)
        {
            Customer customer = _mapper.Map<Customer>(viewModel);

            _context.Update(customer);
            _context.SaveChanges();

            return viewModel;

        }

        public CustomerCreateViewModel Delete(string id)
        {
            var customer = GetCustomer(id);
            if(customer != null)
            {
                _context.Remove(customer);
                _context.SaveChanges();
            }

            return _mapper.Map<CustomerCreateViewModel>(customer);

        }

        private Customer GetCustomer(string id)
        {
            var customer = _context.Customer
               .Include(x => x.Orders)
               .Where(x => x.Id == id).FirstOrDefault();

            return customer;

        }
    }
}
