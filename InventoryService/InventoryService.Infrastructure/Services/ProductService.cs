using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductDomainModel> productRepository;
        public ProductService(IRepository<ProductDomainModel> repository)
        {
            productRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public ProductDomainModel GetProduct(int productId)
        {
            try
            {
                return productRepository.GetById(productId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductDomainModel> GetProducts()
        {
            try
            {
                return productRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
