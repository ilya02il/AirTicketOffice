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

		public async void Edit<TEntity>(TEntity entity) where TEntity : class, IEntity
		{
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

		#region get functions

		public int GetAmountOfEmptySeats(PlaneEntity plane, ClassEntity type)
		{
			var planeSeats = _dbRepository.GetAll<SeatEntity>().
				FirstOrDefault(seat => seat.PlaneId == plane.Id && seat.ClassId == type.Id);

			if (planeSeats == null)
				throw new NullReferenceException("This plane has no seats of this class.");

			var classTicketsAmount = _dbRepository.Get<TicketEntity>(ticket => ticket.ClassId == type.Id).Count();

			return planeSeats.Amount - classTicketsAmount;
		}

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
