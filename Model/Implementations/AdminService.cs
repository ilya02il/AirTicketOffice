using System;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Model.Implementations
{
	public class AdminService : IAdminService
	{
		private readonly IDbRepository _dbRepository;

		public AdminService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class, IEntity
		{
			return _dbRepository.GetAll<TEntity>();
		}

		public async void Add<TEntity>(TEntity newEntity) where TEntity : class, IEntity
		{
			_dbRepository.Add(newEntity);
			await _dbRepository.SaveChangesAsync();
		}

		public async void Delete<TEntity>(int id) where TEntity : class, IEntity
		{
			await _dbRepository.Delete<TEntity>(id);
			await _dbRepository.SaveChangesAsync();
		}

		public async void Delete<TEntity>(TEntity entity) where TEntity : class, IEntity
		{
			await _dbRepository.Delete<TEntity>(entity.Id);
			await _dbRepository.SaveChangesAsync();
		}

		public async void Edit<TEntity>(TEntity entity) where TEntity : class, IEntity
		{
			if (_dbRepository.Get<TEntity>(e => e.Id == entity.Id).Any())
			{
				await _dbRepository.Update(entity);
			}
			else
			{
				_dbRepository.Add(entity);
			}
			await _dbRepository.SaveChangesAsync();
		}

		public async void EditAllAsync<TEntity>(ICollection<TEntity> entities)
			where TEntity : class, IEntity
		{
			foreach (var entity in entities)
			{
				if (_dbRepository.Get<TEntity>(e => e.Id == entity.Id).Any())
				{
					await _dbRepository.Update(entity);
				}
				else
				{
					_dbRepository.Add(entity);
				}
			}

			await _dbRepository.SaveChangesAsync();
		}
	}
}
