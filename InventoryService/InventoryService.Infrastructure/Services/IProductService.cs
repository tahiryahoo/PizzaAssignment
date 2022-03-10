using InventoryService.Infrastructure.DomainModels;
using System.Collections.Generic;

namespace InventoryService.Infrastructure.Services
{
    public interface IProductService
    {
        List<ProductDomainModel> GetProducts();
        ProductDomainModel GetProduct(int productId);
    }
}
