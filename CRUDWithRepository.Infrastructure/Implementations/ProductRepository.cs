using CRUDWithRepository.core;
using CRUDWithRepository.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithRepository.Infrastructure.Implementations
{

    public class ProductRepository : IProductRepository
    {
        private readonly MyAppDbContext _context;
        public ProductRepository(MyAppDbContext context)
        {
            _context = context;
        }

        //get all row
        public async Task<IEnumerable<Product>> GetAll()
        {
            IEnumerable<Product> products = await _context.Products.ToListAsync();
            return products;
        }

        //get specific row
        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        //add method
        public async Task Add(Product model)
        {
            await _context.Products.AddAsync(model);
            await Save();
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        //update method
        public async Task Update(Product model)
        {
            var product = await _context.Products.FindAsync(model.Id);
            if (product != null)
            {
                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.Qty = model.Qty;
                //_context.Update(product);
                await Save();
            }
        }
        //delete method
        public async Task Delete(int id)
        {
            var products = await _context.Products.FindAsync(id);
            if (products != null)
            {
                _context.Products.Remove(products);
                await Save();
            }
        }




    }
}
