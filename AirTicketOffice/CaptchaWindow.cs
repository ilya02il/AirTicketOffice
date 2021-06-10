using System;
using System.Drawing;
using System.Windows.Forms;
using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AirTicketOffice
{
	public partial class CaptchaWindow : MaterialForm, ICaptchaView
	{
		public event Action GetCaptcha;
		public event Action CheckCaptcha;

		public string CaptchaText
		{
			get => captchaTextBox.Text;
			set => captchaTextBox.Text = value;
		}

		public Bitmap CaptchaPicture
		{
			set => captchaPictureBox.Image = value;
		}

		public CaptchaWindow(MaterialSkinManager manager)
		{
			InitializeComponent();
			
			manager.AddFormToManage(this);

			Shown += (sender, args) => GetCaptcha?.Invoke();
			resetCaptchaButton.Click += (sender, args) => GetCaptcha?.Invoke();
			acceptButton.Click += (sender, args) => CheckCaptcha?.Invoke();
		}

		public new void Show()
		{
			ShowDialog();
		}

		public void ShowError(string message)
		{
			MessageBox.Show(message);
		}
	}
}
