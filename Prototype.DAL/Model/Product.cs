using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp.DAL.Model
{
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int QuantityAvailable { get; set; }

        public Item item { get; set; }
    }
}
