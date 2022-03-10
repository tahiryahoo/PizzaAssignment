using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Services
{
    public class InventoryServices : IInventoryService
    {
        private readonly IRepository<InventoryDomainModel> inventoryRepository;
        public InventoryServices(IRepository<InventoryDomainModel> repository)
        {
            inventoryRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public InventoryDomainModel GetInventoryMetaData()
        {
            try
            {
                return inventoryRepository.GetById(0);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
