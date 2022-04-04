using CoffeeMug.Common.DTO.Request;
using CoffeeMug.Common.DTO.Response;
using CoffeeMug.Data.IRepository;
using CoffeeMug.Data.Model;
using CoffeeMug.Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Logic.Logic
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _productRepository;
        public ProductLogic(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductResponseModel Add(AddProductRequestModel model)
        {
            var dbModel = new Product
            {
                Name = model.Name,
                Number = model.Number,
                Quantity = model.Quantity,
                Description = model.Description,
                Price = model.Price
            };
            _productRepository.Insert(dbModel);
            _productRepository.Save();
            return new ProductResponseModel(dbModel);
        }

        public bool Delete(Guid id)
        {
            var dbModel = _productRepository.GetSingle(id);
            if (dbModel != null)
            {
                dbModel.Archived = true;
                dbModel.ArchivedAt = DateTime.Now;
                _productRepository.Save();
                return true;
            }
            return false;
        }

        public IEnumerable<ProductResponseModel> GetAll()
        {
            return _productRepository.GetItems().Select(p => new ProductResponseModel(p));
        }

        public ProductResponseModel? GetSingle(Guid id)
        {
            var dbModel = _productRepository.GetSingle(id);
            return dbModel != null ? new ProductResponseModel(dbModel) : null;
        }

        public ProductResponseModel? Update(Guid id, UpdateProductRequestModel model)
        {
            var dbModel = _productRepository.GetSingle(id);
            if (dbModel != null)
            {
                dbModel.Quantity = model.Quantity;
                dbModel.Description = model.Description;
                _productRepository.Save();
                return new ProductResponseModel(dbModel);
            }
            return null;
        }
    }
}
