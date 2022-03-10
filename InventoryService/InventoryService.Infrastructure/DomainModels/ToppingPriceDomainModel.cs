using InventoryService.Infrastructure.Models;

namespace InventoryService.Infrastructure.DomainModels
{
    public class ToppingPriceDomainModel
    {
        public int ToppingType { get; set; }

        public int SizeId { get; set; }

        public double Price { get; set; }

        public int ToppingId { get; set; }

        public static ToppingPriceDomainModel AsToppingPriceDomainModel(ToppingPriceModel toppingPriceModel) {
            return new ToppingPriceDomainModel
            {
                ToppingType = toppingPriceModel.ToppingType,
                SizeId = toppingPriceModel.SizeId,
                Price = toppingPriceModel.Price,
                ToppingId = toppingPriceModel.ToppingId
            };
        }
    }
}
