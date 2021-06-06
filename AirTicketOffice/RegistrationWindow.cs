using System;
using AirTicketOffice.Presentations.Views;
using System.Windows.Forms;
using AirTicketOffice.DAL.Entities;

namespace AirTicketOffice
{
	public partial class RegistrationWindow : Form, IRegistrationView
	{
		public event Action Register;

		public UserEntity User
		{
			get
			{
				var user = new UserEntity()
				{
					Login = loginTextBox.Text,
					HashedPassword = passwordTextBox.Text,
					Surname = surnameTextBox.Text,
					Name = nameTextBox.Text,
					Patronymic = patronymicTextBox.Text,
					Gender = genderComboBox.SelectedText,
					PassportNumber = passportNumberTextBox.Text,
					PhoneNumber = phoneNumberTextBox.Text
				};

				return user;
			}
		}

		public RegistrationWindow()
		{
			InitializeComponent();

			signUpButton.Click += (sender, args) => Register?.Invoke();
		}

		public new void Show()
		{
			ShowDialog();
		}

		private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) passportNumberTextBox.Focus();
		}

		private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) repeatedPasswordTextBox.Focus();
		}

		private void repeatedPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) surnameTextBox.Focus();
		}

		private void surnameTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) nameTextBox.Focus();
		}

		private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) patronymicTextBox.Focus();
		}

		private void patronymicTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) genderComboBox.Focus();
		}

		private void passportNumberTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) phoneNumberTextBox.Focus();
		}

		private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) signUpButton.Focus();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
