using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryService.Infrastructure.DomainModels
{
    public class ProductDomainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCustomizable { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductSubTypeId { get; set; }
        public string Image { get; set; }
        public List<ProductPriceDomainModel> ProductPrices { get; set; }

        public static ProductDomainModel AsProductDomainModel(ProductModel productModel, List<ProductPriceModel> productPriceModelList) {

            var productPrices = productPriceModelList.FindAll(p=>p.ProductId== productModel.Id);

            return new ProductDomainModel
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Description = productModel.Description,
                IsCustomizable = productModel.IsCustomizable,
                ProductTypeId = productModel.ProductTypeId,
                ProductSubTypeId = productModel.ProductSubTypeId,
                Image = productModel.Image,
                ProductPrices = productPrices.Select(p => ProductPriceDomainModel.AsProductPriceDomainModel(p)).ToList()
            };
        }

        public static ProductDomainModel AsProductDomainModel(ProductModel productModel)
        {
            return new ProductDomainModel
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Description = productModel.Description,
                IsCustomizable = productModel.IsCustomizable,
                ProductTypeId = productModel.ProductTypeId,
                ProductSubTypeId = productModel.ProductSubTypeId,
                Image = productModel.Image
            };
        }

    }
}
