using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class ToppingPriceModel
    {
        public int ToppingType { get; set; }

        public int SizeId { get; set; }

        public double Price { get; set; }

        public int ToppingId { get; set; }
    }
}
