using CoffeeMug.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Common.DTO.Response
{
    public class ProductResponseModel
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }

        public decimal Price { get; set; }
        public ProductResponseModel(Product dbModel)
        {
            this.Id = dbModel.Id;
            this.Name = dbModel.Name;
            this.Number = dbModel.Number ?? null;
            this.Quantity = dbModel.Quantity ?? 0;
            this.Description = dbModel.Description ?? null;
            this.Price = dbModel.Price;
        }
    }
}
