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

        public CustomerCreateViewModel Get(int id)
        {
            
                var customer = _context.Customer
                    .Include(x => x.Orders)
                    .Where(x => x.Id == id).FirstOrDefault();


                var viewModel = _mapper.Map<CustomerCreateViewModel>(customer);

                return viewModel;


        }

        public int Create(CustomerCreateViewModel viewModel)
        {
            Customer customer = _mapper.Map<Customer>(viewModel); 
            _context.Add(customer);
            _context.SaveChanges();
            return viewModel.Id;
        }

    }
}
