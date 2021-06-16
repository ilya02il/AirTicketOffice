using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AirTicketOffice.DAL.Implementations
{
	public class DbRepository : IDbRepository
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<T> Get<T>() where T : class, IEntity
        {
            return _context.Set<T>().Where(x => x.IsActive).AsQueryable();
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntity
        {
            return _context.Set<T>().Where(selector).Where(x => x.IsActive).AsQueryable();
        }

        public void Add<T>(T newEntity) where T : class, IEntity
        {
	        _context.Set<T>().Add(newEntity);
        }

        public async Task AddRange<T>(IEnumerable<T> newEntities) where T : class, IEntity
        {
            await Task.Run((() => _context.Set<T>().AddRange(newEntities)));
        }

        public async Task Delete<T>(int id) where T : class, IEntity
        {
            var activeEntity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

            if (activeEntity == null) return;

            activeEntity.IsActive = false;
            await Task.Run(() => _context.Set<T>().Remove(activeEntity));
        }

        public async Task Remove<T>(T entity) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().Remove(entity));
        }

        public async Task RemoveRange<T>(IEnumerable<T> entities) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().RemoveRange(entities));
        }

        public async Task Update<T>(T entity) where T : class, IEntity
        {
	        var innerEntity = await _context.Set<T>().FindAsync(entity.Id);

            if (innerEntity == null) return;

            foreach (var property in entity.GetType().GetProperties())
            {
	            if (property.GetValue(entity) == null)
                    property.SetValue(entity, property.GetValue(innerEntity));
            }

            await Task.Run(() => _context.Entry(innerEntity).CurrentValues.SetValues(entity));
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAll<T>() where T : class, IEntity
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<IQueryable<T>> GetAllAsync<T>() where T : class, IEntity
        {
	        return await Task.Run(() => _context.Set<T>().AsQueryable());
        }
    }
}
