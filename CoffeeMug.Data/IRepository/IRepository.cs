using CoffeeMug.Data.Model.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Data.IRepository
{
    public interface IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        IEnumerable<TEntity> GetItems();
        TEntity Insert(TEntity entity);
        TEntity? GetSingle(Guid id);
        void Save();
    }
}
