using System;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;

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

		public AuthorizationWindow(ApplicationContext context)
		{
			_context = context;

			InitializeComponent();

			var manager = MaterialSkinManager.Instance;
			manager.EnforceBackcolorOnAllComponents = true;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.LIGHT;
			manager.ColorScheme = new ColorScheme(
				Primary.Indigo400,
				Primary.Indigo500,
				Primary.Indigo100,
				Accent.Blue200,
				TextShade.WHITE
				);

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
			Application.Run(_context);
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

		private void captchaTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.Enter) signInButton.Focus();
		}
	}
}
