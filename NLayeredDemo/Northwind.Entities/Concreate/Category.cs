﻿using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities.Concreate
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
