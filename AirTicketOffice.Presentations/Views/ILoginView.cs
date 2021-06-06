using System;
using System.Drawing;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
    public interface ILoginView : IView
    {
	    event Action Login;
	    event Action Register;
	    event Action GetCaptcha;

        string Username { get; set; }
        string Password { get; set; }

        string CaptchaText { get; set; }

        Bitmap CaptchaPicture { set; }

        void ShowError(string errorMessage);
    }
}