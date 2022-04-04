

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Data.Model
{
    public class Product : BaseEntity
    {        
        [Required, StringLength (100)]
        public string Name { get; set; }
        public int? Number { get; set; }
        public int? Quantity { get; set; }
        [StringLength (200)]
        public string? Description { get; set; }
   
        [Required]
        public decimal Price { get; set; }
    }
}
