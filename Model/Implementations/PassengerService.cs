using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;

namespace Model.Implementations
{
	public class PassengerService : IPassengerService
	{
		private readonly IDbRepository _dbRepository;

		public PassengerService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class, IEntity
		{
			return _dbRepository.GetAll<TEntity>();
		}

		public IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> selector)
			where TEntity : class, IEntity
		{
			return _dbRepository.Get(selector);
		}

		public int GetAmountOfEmptySeats(PlaneEntity plane, ClassEntity type)
		{
			var planeSeats = _dbRepository.GetAll<SeatEntity>().
				FirstOrDefault(seat => seat.PlaneId == plane.Id && seat.ClassId == type.Id);

			if (planeSeats == null)
				throw new NullReferenceException("This plane has no seats of this class.");

			var classTicketsAmount = _dbRepository.Get<TicketEntity>(ticket => ticket.TicketPrice.ClassId == type.Id).Count();

			return planeSeats.Amount - classTicketsAmount;
		}

		public void Add<TEntity>(TEntity newEntity)
			where TEntity : class, IEntity
		{
			_dbRepository.Add(newEntity);
			_dbRepository.SaveChanges();
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
	}
}
