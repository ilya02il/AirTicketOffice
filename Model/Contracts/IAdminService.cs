using System;
using System.Collections.Generic;
using AirTicketOffice.DAL.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace Model.Contracts
{
	public interface IAdminService
	{
		IQueryable<TEntity> GetAll<TEntity>()
			where TEntity : class, IEntity;

		void Add<TEntity>(TEntity newEntity)
			where TEntity : class, IEntity;
			
		void Delete<TEntity>(int id)
			where TEntity : class, IEntity;
			
		void Edit<TEntity>(TEntity entity)
			where TEntity : class, IEntity;

		void EditAllAsync<TEntity>(ICollection<TEntity> entities)
			where TEntity : class, IEntity;
		
	}
}
