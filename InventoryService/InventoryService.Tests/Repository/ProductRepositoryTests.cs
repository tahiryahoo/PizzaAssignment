using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Models;
using InventoryService.Infrastructure.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InventoryService.Tests.Repository
{
    public class ProductRepositoryTests
    {

        [Fact]
        public void ConstructorTest() { 
        
        }
        [Fact]
        public void GetAllTest()
        {
            var repo = new ProductRepository<ProductDomainModel>();
            var productList = repo.GetAll();
            Assert.NotNull(productList);
        }

        [Fact]
        public void GetByIdTest()
        {
            var repo = new ProductRepository<ProductDomainModel>();
            var productDetails = repo.GetById(1);
            Assert.NotNull(productDetails);
        }
    }
}
