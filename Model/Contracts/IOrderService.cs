using AirTicketOffice.DAL.Entities;
using System.Linq;

namespace Model.Contracts
{
	public interface IOrderService
	{
		IQueryable<OrderEntity> GetAllOrders();

		void AddOrder(OrderEntity newOrder);
		void DeleteOrder(OrderEntity order);
		void EditOrderInfo(OrderEntity order);
	}
}
