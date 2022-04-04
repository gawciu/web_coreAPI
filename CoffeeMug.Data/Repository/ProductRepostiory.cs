using CoffeeMug.Data.IRepository;
using CoffeeMug.Data.Model;
using CoffeeMug.Data.ModelDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Data.Repository
{
    public class ProductRepostiory : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepostiory(ProductDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetItems()
        {
            return _context.Products.Where(p => !p.Archived).ToList();
        }

        public Product GetSingle(Guid id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id && !p.Archived);
        }

        public Product Insert(Product entity)
        {
            _context.Products.Add(entity);
            return entity;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
