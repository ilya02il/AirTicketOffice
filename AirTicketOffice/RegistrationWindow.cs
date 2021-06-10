using System;
using System.Windows.Forms;
using AirTicketOffice.DAL.Entities;
using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AirTicketOffice
{
    public partial class RegistrationWindow : MaterialForm, IRegistrationView
    {
	    public event Action Register;
	    public event Action Back;

	    private readonly ApplicationContext _context;

	    public UserEntity User
	    {
		    get => new UserEntity()
		    {
			    Surname = surnameTextBox.Text,
                Name = nameTextBox.Text,
                Patronymic = patronymicTextBox.Text,
                Gender = genderComboBox.SelectedItem.ToString(),
                PassportNumber = passportTextBox.Text,
                PhoneNumber = phoneTextBox.Text
		    };

		    set
		    {
			    surnameTextBox.Text = value.Surname;
			    nameTextBox.Text = value.Name;
			    patronymicTextBox.Text = value.Patronymic;
			    genderComboBox.SelectedItem = value.Gender;
			    passportTextBox.Text = value.PassportNumber;
			    phoneTextBox.Text = value.PhoneNumber;
		    }
	    }

        public RegistrationWindow(ApplicationContext context, MaterialSkinManager manager)
        {
	        _context = context;

			InitializeComponent();
			
            manager.AddFormToManage(this);

            continueButton.Click += (sender, args) => Register?.Invoke();
            backButton.Click += (sender, args) => Back?.Invoke();
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
