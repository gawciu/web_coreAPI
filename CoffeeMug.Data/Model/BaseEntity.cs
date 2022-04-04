using CoffeeMug.Data.Model.IModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Data.Model
{
    public class BaseEntity : IBaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }       
        public DateTimeOffset CreatedAt { get; set; }
     
        public bool Archived { get; set; }

        public DateTimeOffset? ArchivedAt { get; set; }
        public BaseEntity()
        {
            CreatedAt = DateTimeOffset.Now;
        }
    }
}
