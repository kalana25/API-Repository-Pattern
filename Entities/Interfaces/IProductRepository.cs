using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Collections;

namespace Entities.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Edit(Product product);
        void Remove(int id);
        List<Product> GetProducts();
        Product FindById(int id);
    }
}
