using System.Threading.Tasks;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model;
using Model.Contracts;

namespace AirTicketOffice.Presentations.Presenters
{
	public class InitializationPresenter : BasePresenter<IInitializationView>
	{
		private readonly ILoginService _loginService;
		public InitializationPresenter(IApplicationController controller, IInitializationView view, ILoginService loginService) : base(controller, view)
		{
			_loginService = loginService;

			View.LoadUsers += LoadUsersAsync;
		}

		public async void LoadUsersAsync()
		{
			View.ChangeStatus(@"Идет загрузка базы данных пользователей...");

			await Task.Run(() => _loginService.LoadUsers());

			View.Close();
		}
	}
}
