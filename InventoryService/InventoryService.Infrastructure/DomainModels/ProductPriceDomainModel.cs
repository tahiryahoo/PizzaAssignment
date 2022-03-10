using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.DomainModels
{
    public class ProductPriceDomainModel
    {
        public int Id { get; set; }
        public int? SizeId { get; set; }
        public int? CrustId { get; set; }
        public double Price { get; set; }
        public int Quntity { get; set; }

        public static ProductPriceDomainModel AsProductPriceDomainModel(ProductPriceModel productPriceModel) {

            return new ProductPriceDomainModel { 
            Id=productPriceModel.Id,
            SizeId=productPriceModel.SizeId,
            CrustId=productPriceModel.CrustId,
            Price=productPriceModel.Price
            };
        }
    }
}
