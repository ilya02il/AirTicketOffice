using System;
using AirTicketOffice.Presentations.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AirTicketOffice
{
    public partial class RegistrationFinishWindow : MaterialForm, IRegistrationFinishView
    {
	    public event Action FinishRegistration;

        public RegistrationFinishWindow(MaterialSkinManager manager)
        {
			InitializeComponent();
            
            manager.AddFormToManage(this);

            continueButton.Click += (sender, args) => FinishRegistration?.Invoke();
        }

        public new void Show()
        {
	        ShowDialog();
        }
    }
}
