using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryService.Infrastructure.DomainModels
{
    public class ToppingDomainModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ToppingPriceDomainModel> ToppingPrices { get; set; }

        public static ToppingDomainModel AsToppingDomainModel(ToppingModel topppingModel, List<ToppingPriceModel> toppingPriceModels) {

            var toppingPrices = toppingPriceModels.FindAll(t => t.ToppingId == topppingModel.Id).ToList();
            return new ToppingDomainModel
            {
                Id = topppingModel.Id,
                Name = topppingModel.Name,
                ToppingPrices = toppingPrices.Select(t => ToppingPriceDomainModel.AsToppingPriceDomainModel(t)).ToList()
            };
        }
    }
}
