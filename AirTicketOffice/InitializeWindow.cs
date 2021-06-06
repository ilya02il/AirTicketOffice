using AirTicketOffice.Presentations.Views;
using System;
using System.Windows.Forms;

namespace AirTicketOffice
{
	public partial class InitializeWindow : Form, IInitializationView
	{
		public Action LoadUsers { get; set; }

		public InitializeWindow()
		{
			InitializeComponent();

			Shown += (sender, args) => LoadUsers?.Invoke();
		}

		public new void Show()
		{
			ShowDialog();
		}

		public void ChangeStatus(string status)
		{
			statusLabel.Text = status;
		}
	}
}
