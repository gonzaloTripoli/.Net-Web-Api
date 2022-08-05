﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeApp.DAL.Model
{
    public class Customer : EntityBase
    {
        
        public string Name  { get; set; }

        public string Mail { get; set; }

        public List<Order> Orders { get; set; }

    }
}
