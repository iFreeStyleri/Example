using Example.Core.Abstractions;
using Example.Domain.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Repositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : Entity
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }


        public Task Delete(TModel entity)
        {
            _context.Set<TModel>().Remove(entity);
            return Task.FromResult(entity);
        }

        public IQueryable<TModel> GetAll()
            => _context.Set<TModel>().AsQueryable();

        public async Task<TModel> GetById(int id)
            => await _context.Set<TModel>().SingleOrDefaultAsync(model => model.Id == id);
        public Task Insert(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
            return Task.FromResult(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(TModel entity)
        {
            _context.Set<TModel>().Update(entity);
            return Task.FromResult(entity);
        }
    }
}
