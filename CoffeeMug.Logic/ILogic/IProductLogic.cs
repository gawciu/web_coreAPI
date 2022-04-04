using CoffeeMug.Common.DTO.Request;
using CoffeeMug.Common.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Logic.ILogic
{
    public interface IProductLogic
    {
        public IEnumerable<ProductResponseModel> GetAll();
        public ProductResponseModel GetSingle(Guid id);
        public ProductResponseModel Update(Guid id,UpdateProductRequestModel model);
        public bool Delete(Guid id);
        public ProductResponseModel Add(AddProductRequestModel model);

    }
}
