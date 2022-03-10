using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.DomainModels
{
    public class InventoryDomainModel
    {
        public List<ToppingDomainModel> ProductToppings { get; set; }
        public List<SizeModel> ProductSizes { get; set; }
        public List<CrustModel> ProductCrusts { get; set; }
        public List<ProductTypeModel> ProductTypes { get; set; }
        public List<ExtraCheeseModel> ExtraCheesePrices { get; set; }
    }
}
