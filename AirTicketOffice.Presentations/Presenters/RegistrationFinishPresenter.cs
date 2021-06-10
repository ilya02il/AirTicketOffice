using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice.Presentations.Presenters
{
	public class RegistrationFinishPresenter : BasePresenter<IRegistrationFinishView>
	{
		public RegistrationFinishPresenter(IApplicationController controller, IRegistrationFinishView view)
			: base(controller, view)
		{
			View.FinishRegistration += FinishRegistration;
		}

		public void FinishRegistration()
		{
			View.Close();
		}
	}
}
