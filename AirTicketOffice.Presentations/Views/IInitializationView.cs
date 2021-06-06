using System;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface IInitializationView : IView
	{
		Action LoadUsers { get; set; }

		void ChangeStatus(string status);
	}
}
