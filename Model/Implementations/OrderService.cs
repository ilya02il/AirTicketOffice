using AirTicketOffice.DAL.Contracts;
using AirTicketOffice.DAL.Entities;
using Model.Contracts;
using System.Linq;

namespace Model.Implementations
{
	public class OrderService : IOrderService
	{
		private readonly IDbRepository _dbRepository;

		public OrderService(IDbRepository dbRepository)
		{
			_dbRepository = dbRepository;
		}

		public IQueryable<OrderEntity> GetAllOrders()
		{
			return _dbRepository.GetAll<OrderEntity>();
		}

		public void AddOrder(OrderEntity newOrder)
		{
			_dbRepository.Add(newOrder);
		}

		public void DeleteOrder(OrderEntity order)
		{
			_dbRepository.Delete<OrderEntity>(order.Id);
		}

		public void EditOrderInfo(OrderEntity order)
		{
			_dbRepository.Update(order);
		}
	}
}
