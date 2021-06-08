using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using reCaptcha;
using System;

namespace AirTicketOffice.Presentations.Presenters
{
	public class CaptchaPresenter : BasePresenter<ICaptchaView>
	{
		private readonly ICaptchaService _captchaService;

		public CaptchaPresenter(IApplicationController controller, ICaptchaView view, ICaptchaService captchaService) : base(controller, view)
		{
			_captchaService = captchaService;

			View.GetCaptcha += GetCaptcha;
			View.CheckCaptcha += () => CheckCaptcha(View.CaptchaText);
		}

		public void CheckCaptcha(string captchaText)
		{
			if (_captchaService.CheckCaptcha(captchaText))
			{
				View.Close();
			}
			else
			{
				View.ShowError("Не верный текст капчи.");

				View.CaptchaText = string.Empty;
				GetCaptcha();
			}
		}

		public void GetCaptcha()
		{
			var random = new Random();

			_captchaService.CaptchaText = random.Next(100000).ToString();

			View.CaptchaPicture = Captcha.GenerateCaptcha(_captchaService.CaptchaText, 310, 100);
		}
	}
}
