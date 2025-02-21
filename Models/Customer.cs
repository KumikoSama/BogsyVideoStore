﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
    }

    public class GlobalCustomer
    {
        public static int CustomerID { get; set; }
        public static string FullName { get; set; }
    }
}
