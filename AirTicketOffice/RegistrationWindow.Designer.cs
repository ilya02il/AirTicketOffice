
namespace AirTicketOffice
{
	partial class RegistrationWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginLabel = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.repeatedPasswordTextBox = new System.Windows.Forms.TextBox();
			this.repeatedPasswordLabel = new System.Windows.Forms.Label();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patronymicTextBox = new System.Windows.Forms.TextBox();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.genderLabel = new System.Windows.Forms.Label();
			this.passportNumberTextBox = new System.Windows.Forms.TextBox();
			this.passportNumberLabel = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			this.signUpButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(14, 15);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(41, 13);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Логин:";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginTextBox.Location = new System.Drawing.Point(123, 12);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(197, 20);
			this.loginTextBox.TabIndex = 1;
			this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(123, 38);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(197, 20);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(14, 41);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(48, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Пароль:";
			// 
			// repeatedPasswordTextBox
			// 
			this.repeatedPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.repeatedPasswordTextBox.Location = new System.Drawing.Point(123, 64);
			this.repeatedPasswordTextBox.Name = "repeatedPasswordTextBox";
			this.repeatedPasswordTextBox.Size = new System.Drawing.Size(197, 20);
			this.repeatedPasswordTextBox.TabIndex = 5;
			this.repeatedPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repeatedPasswordTextBox_KeyDown);
			// 
			// repeatedPasswordLabel
			// 
			this.repeatedPasswordLabel.AutoSize = true;
			this.repeatedPasswordLabel.Location = new System.Drawing.Point(14, 67);
			this.repeatedPasswordLabel.Name = "repeatedPasswordLabel";
			this.repeatedPasswordLabel.Size = new System.Drawing.Size(103, 13);
			this.repeatedPasswordLabel.TabIndex = 4;
			this.repeatedPasswordLabel.Text = "Повторите пароль:";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.surnameTextBox.Location = new System.Drawing.Point(123, 90);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(197, 20);
			this.surnameTextBox.TabIndex = 7;
			this.surnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surnameTextBox_KeyDown);
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(14, 93);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(59, 13);
			this.surnameLabel.TabIndex = 6;
			this.surnameLabel.Text = "Фамилия:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Location = new System.Drawing.Point(123, 116);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(197, 20);
			this.nameTextBox.TabIndex = 9;
			this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(14, 119);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(29, 13);
			this.nameLabel.TabIndex = 8;
			this.nameLabel.Text = "Имя";
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.patronymicTextBox.Location = new System.Drawing.Point(123, 142);
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(197, 20);
			this.patronymicTextBox.TabIndex = 11;
			this.patronymicTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patronymicTextBox_KeyDown);
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(14, 145);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(57, 13);
			this.patronymicLabel.TabIndex = 10;
			this.patronymicLabel.Text = "Отчество:";
			// 
			// genderLabel
			// 
			this.genderLabel.AutoSize = true;
			this.genderLabel.Location = new System.Drawing.Point(14, 171);
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(30, 13);
			this.genderLabel.TabIndex = 12;
			this.genderLabel.Text = "Пол:";
			// 
			// passportNumberTextBox
			// 
			this.passportNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.passportNumberTextBox.Location = new System.Drawing.Point(123, 194);
			this.passportNumberTextBox.Name = "passportNumberTextBox";
			this.passportNumberTextBox.Size = new System.Drawing.Size(197, 20);
			this.passportNumberTextBox.TabIndex = 15;
			this.passportNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passportNumberTextBox_KeyDown);
			// 
			// passportNumberLabel
			// 
			this.passportNumberLabel.AutoSize = true;
			this.passportNumberLabel.Location = new System.Drawing.Point(14, 197);
			this.passportNumberLabel.Name = "passportNumberLabel";
			this.passportNumberLabel.Size = new System.Drawing.Size(94, 13);
			this.passportNumberLabel.TabIndex = 14;
			this.passportNumberLabel.Text = "Номер паспорта:";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneNumberTextBox.Location = new System.Drawing.Point(123, 220);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(197, 20);
			this.phoneNumberTextBox.TabIndex = 17;
			this.phoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumberTextBox_KeyDown);
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(14, 223);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(96, 13);
			this.phoneNumberLabel.TabIndex = 16;
			this.phoneNumberLabel.Text = "Номер телефона:";
			// 
			// genderComboBox
			// 
			this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Location = new System.Drawing.Point(123, 168);
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(197, 21);
			this.genderComboBox.TabIndex = 18;
			// 
			// signUpButton
			// 
			this.signUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.signUpButton.Location = new System.Drawing.Point(195, 246);
			this.signUpButton.Name = "signUpButton";
			this.signUpButton.Size = new System.Drawing.Size(125, 23);
			this.signUpButton.TabIndex = 19;
			this.signUpButton.Text = "Зарегистрироваться";
			this.signUpButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.Location = new System.Drawing.Point(17, 246);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 20;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// RegistrationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 279);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.signUpButton);
			this.Controls.Add(this.genderComboBox);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.passportNumberTextBox);
			this.Controls.Add(this.passportNumberLabel);
			this.Controls.Add(this.genderLabel);
			this.Controls.Add(this.patronymicTextBox);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.repeatedPasswordTextBox);
			this.Controls.Add(this.repeatedPasswordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.loginLabel);
			this.Name = "RegistrationWindow";
			this.Text = "Регистрация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox repeatedPasswordTextBox;
		private System.Windows.Forms.Label repeatedPasswordLabel;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox patronymicTextBox;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label genderLabel;
		private System.Windows.Forms.TextBox passportNumberTextBox;
		private System.Windows.Forms.Label passportNumberLabel;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.ComboBox genderComboBox;
		private System.Windows.Forms.Button signUpButton;
		private System.Windows.Forms.Button cancelButton;
	}
}