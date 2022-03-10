using InventoryService.Infrastructure.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Services
{
    public interface IInventoryService
    {
        InventoryDomainModel GetInventoryMetaData();
    }
}
