﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class ToppingModel : ITypeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ToppingType { get; set; }
    }
}
