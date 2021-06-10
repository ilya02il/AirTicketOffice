using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Common;
using AirTicketOffice.Presentations.Views;
using Model.Contracts;
using System;

namespace AirTicketOffice.Presentations.Presenters
{
	public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _loginService;
        private readonly ICaptchaService _captchaService;
        private int _counter;

        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService loginService, ICaptchaService captchaService)
            : base(controller, view)
        {
	        _loginService = loginService;
	        _captchaService = captchaService;
	        _counter = 0;

            Controller.Run<InitializationPresenter>();

            View.Login += () => Login(View.Username, View.Password);
            View.Register += Register;
        }

        private void Login(string username, string password)
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

            var user = _loginService.Login(new UserEntity {Login = username, HashedPassword = password});

            if (user == null)
            {
                View.ShowError("Неверный логин или пароль.");

                View.Username = string.Empty;
                View.Password = string.Empty;

                _counter++;
            }
            else
            {
	            Controller.Run<CaptchaPresenter>();

	            if (_captchaService.IsValid)
	            {
                    //Controller.Run<MainPresenter, UserEntity>(user);
		            View.Close();
                }
            }

            if (_counter < 3) return;

            View.ShowError("Вы ввели неверный пароль 3 раза. Приложение будет закрыто.");
            View.Close();
        }

        public void Register()
        {
            Controller.Run<RegistrationStartPresenter, UserEntity>(new UserEntity());
            View.Close();
        }
    }
}