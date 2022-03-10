using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCustomizable { get; set; }

        public int ProductTypeId { get; set; }
        public int ProductSubTypeId { get; set; }
        public string Image { get; set; }
    }
}
