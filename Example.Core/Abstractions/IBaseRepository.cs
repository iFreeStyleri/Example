using Example.Domain.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Abstractions
{
    public interface IBaseRepository<TModel> where TModel : Entity
    {
        Task<TModel> GetById(int id);
        IQueryable<TModel> GetAll();
        Task Insert(TModel entity);
        Task Update(TModel entity);
        Task SaveChanges();
        Task Delete(TModel entity);
    }
}
