using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Common.DTO.Request
{
    public class UpdateProductRequestModel
    {
        public string? Description { get; set; }
        public int? Quantity { get; set; }
    }
}
