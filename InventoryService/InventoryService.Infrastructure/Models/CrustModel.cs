using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Models
{
    public class CrustModel : ITypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
