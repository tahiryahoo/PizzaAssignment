using InventoryService.Infrastructure.DomainModels;
using InventoryService.Infrastructure.Library;
using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryService.Infrastructure.Repository
{
    public class ProductRepository<T> : IRepository<T> where T : ProductDomainModel
    {
        private ProductDBContextModel _context;
        public ProductRepository()
        {
            _context = ProductDBContext.ReadJsonDB();     
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            try
            {
                var productEntityModel = _context.ProductMaster;
                var productPriceEntityModel = _context.ProductPriceMaster;

                var productDomainModelList = new List<T>();
                foreach (var product in productEntityModel)
                {
                    productDomainModelList.Add((T)ProductDomainModel.AsProductDomainModel(product, productPriceEntityModel));
                }
                return (List<T>)productDomainModelList;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public T GetById(int id)
        {
            var productDomainModel = _context.ProductMaster.First(p => p.Id == id);
            var productPriceDomainModel = _context.ProductPriceMaster;
            return (T)ProductDomainModel.AsProductDomainModel(productDomainModel, productPriceDomainModel);
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
