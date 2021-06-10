using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace AirTicketOffice
{
	public partial class AuthorizationWindow : MaterialForm, ILoginView
	{
		public event Action Login;
		public event Action Register;

		private readonly ApplicationContext _context;

		public string Username
		{
			get => loginTextBox.Text;
			set => loginTextBox.Text = value;
		}

		public string Password
		{
			get => passwordTextBox.Text;
			set => passwordTextBox.Text = value;
		}

		public AuthorizationWindow(ApplicationContext context, MaterialSkinManager manager)
		{
			_context = context;

			InitializeComponent();

			manager.AddFormToManage(this);

			signInButton.Click += (sender, args) =>
			{
				loginTextBox.Focus();
				Login?.Invoke();
			};
			
			singUpButton.Click += (sender, args) => Register?.Invoke();
		}

		public new void Show()
		{
			_context.MainForm = this;

			if (Application.OpenForms.Count > 0)
			{
				base.Show();
			}
			else
			{
				Application.Run(_context);
			}

		}

		public void ShowError(string errorMessage)
		{
			MessageBox.Show(errorMessage);
		}

		private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) passwordTextBox.Focus();
		}

		private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) signInButton.Focus();
		}
	}
}
