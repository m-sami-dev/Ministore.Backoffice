using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq; // Added for LINQ methods
using System.Text;

namespace App.core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;

        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }

        // Fix: Implement IProductService.Add(Product)
        public Product Add(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            product.Id = GenerateId();
            _products.Add(product);
            return product;
        }

        // Fix: Implement IProductService.Delete(string)
        public bool Delete(string id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;
            _products.Remove(product);
            return true;
        }

        // Fix: Implement IProductService.GetById(string)
        public Product? GetById(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        // Fix: Implement IProductService.GetAll()
        //public List<Product> GetAll()
        //{
        //    return _products.OrderBy(p => p.Name).ToList();
        //}

        // Existing methods (unchanged)
        public Product add(Product product)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product product)
        {
            return false;
        }
        public bool Delete(Product product)
        {
            return false;
        }
        public Product GetbyID(string id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }
        private void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Usb-cable",
                Category = ProductCategoryEnum.Electronics,
                Price = 1200m,
                Stock = 18,
                Status = ProductStatusEnum.Active
            });
        }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}