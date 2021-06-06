using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using reCaptcha;
using System;

namespace AirTicketOffice.Presentations.Presenters
{
	public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _service;
        private string _captchaText;
        private int _counter;

        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service)
            : base(controller, view)
        {
	        _service = service;
	        _counter = 0;

            Controller.Run<InitializationPresenter>();

            View.Login += () => Login(View.Username, View.Password, View.CaptchaText);
            View.Register += Register;
            View.GetCaptcha += GetCaptcha;
        }

        private void Login(string username, string password, string captchaText)
        {
            if (username == null)
                throw new ArgumentNullException("username");
            if (password == null)
                throw new ArgumentNullException("password");

            if (username == string.Empty && password == string.Empty)
            {
	            View.ShowError("Заполните поля с логином и паролем.");
	            return;
            }
            if (username == string.Empty)
            {
	            View.ShowError("Заполните поле с логином.");
	            return;
            }
            if (password == string.Empty)
            {
	            View.ShowError("Заполните поле с паролем.");
	            return;
            }

            if (captchaText != _captchaText)
            {
                View.ShowError("Не верный текст капчи.");
                GetCaptcha();
                return;
            }

            var user = _service.Login(new UserEntity {Login = username, HashedPassword = password});

            if (user == null)
            {
                View.ShowError("Неверный логин или пароль.");

                View.Username = string.Empty;
                View.Password = string.Empty;

                View.CaptchaText = string.Empty;
                GetCaptcha();

                _counter++;
            }
            else
            {
                Controller.Run<MainPresenter, UserEntity>(user);
                View.Close();
            }

            if (_counter < 3) return;

            View.ShowError("Вы ввели неверный пароль 3 раза. Приложение будет закрыто.");
            View.Close();
        }

        public void GetCaptcha()
        {
	        var random = new Random();

	        _captchaText = random.Next(100000).ToString();

			View.CaptchaPicture = Captcha.GenerateCaptcha(_captchaText, 233, 81);
        }

        public void Register()
        {
            Controller.Run<RegistrationPresenter>();
        }
    }
}