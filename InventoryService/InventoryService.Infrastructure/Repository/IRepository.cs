using InventoryService.Infrastructure.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save(T obj);
    }
}
