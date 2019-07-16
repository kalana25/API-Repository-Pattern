using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Entities;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext context;

        public ProductRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public void Edit(Product product)
        {
            this.context.Products.Update(product);
            this.context.SaveChanges();
        }

        public Product FindById(int id)
        {
            return this.context.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return this.context.Products.ToList();
        }

        public void Remove(int id)
        {
            Product p = FindById(id);
            this.context.Products.Remove(p);
        }
    }
}
