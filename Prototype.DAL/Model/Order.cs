using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp.DAL.Model
{
    public class Order : EntityBase
    {
        public Customer Customer { get; set; }

        public DateTime PurchaseDate { get; set; }

        public List<Product> Products { get; set; }

        public int Price { get; set; }

        
    }
}
