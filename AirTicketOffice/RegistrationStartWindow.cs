using System;
using System.Windows.Forms;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AirTicketOffice
{
    public partial class RegistrationStartWindow : MaterialForm, IRegistrationStartView
	{
		public event Action NextStep;
		public event Action Back;

		private readonly ApplicationContext _context;

		public UserEntity User
		{
			get => new UserEntity()
				{
					Login = loginTextBox.Text,
					HashedPassword = passwordTextBox.Text
				};

			set
			{
				loginTextBox.Text = value.Login;
				passwordTextBox.Text = value.HashedPassword;
			}
		}

		public RegistrationStartWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;

            InitializeComponent();
			
			manager.AddFormToManage(this);

			continueButton.Click += (sender, args) =>
			{
				if (passwordTextBox.Text != passwordAgainTextBox.Text)
				{
					GetMessage("Пароли не совпадают.");
					return;
				}

				NextStep?.Invoke();
			};
			cancelButton.Click += (sender, args) => Back?.Invoke();
        }

		public new void Show()
		{
			_context.MainForm = this;
			base.Show();
		}

		public void GetMessage(string message)
		{
			MessageBox.Show(message);
		}
	}
}
