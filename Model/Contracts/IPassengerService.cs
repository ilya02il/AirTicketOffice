using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AirTicketOffice.DAL.Entities;

namespace Model.Contracts
{
	public interface IPassengerService
	{
		IQueryable<TEntity> GetAll<TEntity>()
			where TEntity : class, IEntity;

		IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> selector)
			where TEntity : class, IEntity;
		
		void Add<TEntity>(TEntity newEntity)
			where TEntity : class, IEntity;

		void Edit<TEntity>(TEntity entity) where TEntity : class, IEntity;

		int GetAmountOfEmptySeats(PlaneEntity plane, ClassEntity type);
	}
}
