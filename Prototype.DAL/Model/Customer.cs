using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp.DAL.Model
{
    public class Customer : EntityBase
    {
        
        public string name  { get; set; }

        public string mail { get; set; }

        public ICollection<Item> items { get; set; }

    }
}
