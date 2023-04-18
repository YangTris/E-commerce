﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public string id { get; set; }
        public int name { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string imgURL { get; set; }
        public DateTime inDate { get; set; }
    }
}