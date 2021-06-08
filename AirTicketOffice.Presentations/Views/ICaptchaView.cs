using System;
using System.Drawing;
using AirTicketOffice.Presentations.Common;

namespace AirTicketOffice.Presentations.Views
{
	public interface ICaptchaView : IView
	{
		event Action GetCaptcha;
		event Action CheckCaptcha;
		string CaptchaText { get; set; }
		Bitmap CaptchaPicture { set; }

		void ShowError(string message);
	}
}
