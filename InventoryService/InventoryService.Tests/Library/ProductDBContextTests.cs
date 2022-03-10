using InventoryService.Infrastructure.Library;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InventoryService.Tests.Library
{
    public class ProductDBContextTests
    {
        [Fact]
        public void ReadJsonDBTest() {

            var fileContent = ProductDBContext.ReadJsonDB();

            Assert.NotNull(fileContent);
        }
    }
}
