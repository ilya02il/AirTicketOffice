using System;
using System.Drawing;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;

namespace AirTicketOffice
{
	public partial class AuthorizationWindow : Form, ILoginView
	{
		public event Action Login;
		public event Action Register;
		public event Action GetCaptcha;

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

		public string CaptchaText
		{
			get => captchaTextBox.Text;
			set => captchaTextBox.Text = value;
		}

		public Bitmap CaptchaPicture
		{
			set => captchaPictureBox.Image = value;
		}

		public AuthorizationWindow(ApplicationContext context)
		{
			_context = context;
			InitializeComponent();

			signInButton.Click += (sender, args) =>
			{
				loginTextBox.Focus();
				Login?.Invoke();
			};

			Shown += (sender, args) => GetCaptcha?.Invoke();
			captchaPictureBox.Click += (sender, args) => GetCaptcha?.Invoke();
			registrationLinkLabel.LinkClicked += (sender, args) => Register?.Invoke();
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
			if (e.KeyCode == Keys.Enter) captchaTextBox.Focus();
		}

		private void captchaTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) signInButton.Focus();
		}
	}
}
