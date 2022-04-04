using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Data.Model.IModels
{
    public interface IBaseEntity
    {

        public Guid Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public bool Archived { get; set; }

        public DateTimeOffset? ArchivedAt { get; set; }
    }
}
