using Prototype.Services.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Services.ViewModels.Customer
{
    public class CustomerCreateViewModel : EntityBase
    {
        public string Name { get; set; }

        public string Mail { get; set; }

    }
}
