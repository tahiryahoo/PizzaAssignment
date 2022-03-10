using InventoryService.Infrastructure.Models;
using InventoryService.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InventoryService.Tests.Repository
{
    public class GenericRepositoryTests
    {
        [Fact]
        public void GetAllTest()
        {
            var repo = new GenericRepository<ProductTypeModel>();
            var productList = repo.GetAll();
            Assert.NotNull(productList);
        }
    }
}
