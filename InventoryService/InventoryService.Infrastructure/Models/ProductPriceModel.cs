using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class ProductPriceModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? CrustId { get; set; }
        public double Price { get; set; }
        public int Quntity { get; set; }

    }
}
