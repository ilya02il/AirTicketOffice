using AirTicketOffice.Presentations.Common;
using System;

namespace AirTicketOffice.Presentations.Views
{
	public interface ILoginView : IView
    {
	    event Action Login;
	    event Action Register;

        string Username { get; set; }
        string Password { get; set; }

        void ShowError(string errorMessage);
    }
}