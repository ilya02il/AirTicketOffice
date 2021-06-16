using System;
using System.Collections.Generic;
using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;
using System.Linq.Expressions;

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

		public async void Edit<TEntity>(TEntity entity) where TEntity : class, IEntity
		{
			var primaryEntity = _dbRepository.Get<TEntity>().FirstOrDefault();



			await _dbRepository.Update(entity);
			await _dbRepository.SaveChangesAsync();
		}

		public async void EditAllAsync<TEntity>(ICollection<TEntity> entities)
			where TEntity : class, IEntity
		{
			foreach (var entity in entities)
			{
				await _dbRepository.Update(entity);
			}

			await _dbRepository.SaveChangesAsync();
		}

		public async void EditAllAsync<TEntity>(ICollection<TEntity> entities, params Expression<Func<TEntity, object>>[] properties)
			where TEntity : class, IEntity
		{
			foreach (var entity in entities)
			{
				await _dbRepository.Update(entity);
			}

			await _dbRepository.SaveChangesAsync();
		}

		#region get functions

		public IQueryable<OrderEntity> GetUserOrders(UserEntity user)
		{
			return _dbRepository.Get<OrderEntity>(order => order.UserId == user.Id);
		}

		public IQueryable<TicketEntity> GetUserTickets(UserEntity user)
		{
			return _dbRepository.Get<TicketEntity>(ticket => ticket.UserId == user.Id);
		}

		public IQueryable<TicketEntity> GetFlightTickets(FlightEntity flight)
		{
			return _dbRepository.Get<TicketEntity>(ticket => ticket.FlightId == flight.Id);
		}

		public IQueryable<FlightEntity> GetPlaneFlights(PlaneEntity plane)
		{
			return _dbRepository.Get<FlightEntity>(flight => flight.PlaneId == plane.Id);
		}

		public IQueryable<CrewMemberEntity> GetPlaneCrewMembers(PlaneEntity plane)
		{
			return _dbRepository.Get<CrewMemberEntity>(crewMember => crewMember.PlaneId == plane.Id);
		}

		public IQueryable<FlightEntity> GetRouteFlights(RouteEntity route)
		{
			return _dbRepository.Get<FlightEntity>(flight => flight.RouteId == route.Id);
		}

		#endregion
	}
}
