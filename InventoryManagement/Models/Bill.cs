﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class BillRowEntry
    {
        [DisplayName("Name")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        [DisplayName("Total Price")]
        public int TotalPrice { get; set; }
    }
}
