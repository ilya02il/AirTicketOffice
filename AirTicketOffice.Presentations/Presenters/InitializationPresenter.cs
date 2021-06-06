using System.Threading.Tasks;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model;
using Model.Contracts;

namespace AirTicketOffice.Presentations.Presenters
{
	public class InitializationPresenter : BasePresenter<IInitializationView>
	{
		private readonly ILoginService _service;
		public InitializationPresenter(IApplicationController controller, IInitializationView view, ILoginService service) : base(controller, view)
		{
			_service = service;

			View.LoadUsers += LoadUsersAsync;
		}

		public async void LoadUsersAsync()
		{
			View.ChangeStatus(@"Идет загрузка базы данных пользователей...");

			await Task.Run(() => _service.LoadUsers());

			View.Close();
		}
	}
}
