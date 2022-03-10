using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Library;
using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryService.Infrastructure.Repository
{
    public class InventoryRepository<T> : IRepository<T> where T : InventoryDomainModel
    {
        private ProductDBContextModel _context;
        public InventoryRepository()
        {
            _context = ProductDBContext.ReadJsonDB();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            var pizzaTopping = _context.ToppingsMaster;
            var pizzaToppingPrice = _context.ToppingsPrice;
            var toppingDomainModel = pizzaTopping.Select(t=> ToppingDomainModel.AsToppingDomainModel(t,pizzaToppingPrice)).ToList();
            var inventoryModel = new InventoryDomainModel
            {
                ExtraCheesePrices = _context.ExtraCheesePrice,
                ProductCrusts = _context.CrustMaster,
                ProductSizes = _context.SizeMaster,
                ProductTypes = _context.ProductTypeMaster,
                ProductToppings = toppingDomainModel
            };
            return (T)inventoryModel;
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
