
namespace AirTicketOffice
{
	partial class AuthorizationWindow
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
			this.signInButton = new System.Windows.Forms.Button();
			this.captchaPictureBox = new System.Windows.Forms.PictureBox();
			this.captchaTextBox = new System.Windows.Forms.TextBox();
			this.captchaLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.registrationLinkLabel = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(12, 15);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(44, 13);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Логин: ";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Location = new System.Drawing.Point(69, 12);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(179, 20);
			this.loginTextBox.TabIndex = 1;
			this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(69, 38);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(179, 20);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 41);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(51, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Пароль: ";
			// 
			// signInButton
			// 
			this.signInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.signInButton.Location = new System.Drawing.Point(93, 207);
			this.signInButton.Name = "signInButton";
			this.signInButton.Size = new System.Drawing.Size(75, 23);
			this.signInButton.TabIndex = 4;
			this.signInButton.Text = "ОК";
			this.signInButton.UseVisualStyleBackColor = true;
			// 
			// captchaPictureBox
			// 
			this.captchaPictureBox.Location = new System.Drawing.Point(15, 64);
			this.captchaPictureBox.Name = "captchaPictureBox";
			this.captchaPictureBox.Size = new System.Drawing.Size(233, 81);
			this.captchaPictureBox.TabIndex = 5;
			this.captchaPictureBox.TabStop = false;
			// 
			// captchaTextBox
			// 
			this.captchaTextBox.Location = new System.Drawing.Point(93, 151);
			this.captchaTextBox.Name = "captchaTextBox";
			this.captchaTextBox.Size = new System.Drawing.Size(155, 20);
			this.captchaTextBox.TabIndex = 7;
			this.captchaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.captchaTextBox_KeyDown);
			// 
			// captchaLabel
			// 
			this.captchaLabel.AutoSize = true;
			this.captchaLabel.Location = new System.Drawing.Point(12, 154);
			this.captchaLabel.Name = "captchaLabel";
			this.captchaLabel.Size = new System.Drawing.Size(75, 13);
			this.captchaLabel.TabIndex = 6;
			this.captchaLabel.Text = "Текст капчи: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Еще не зарегистрированы?";
			// 
			// registrationLinkLabel
			// 
			this.registrationLinkLabel.AutoSize = true;
			this.registrationLinkLabel.Location = new System.Drawing.Point(75, 187);
			this.registrationLinkLabel.Name = "registrationLinkLabel";
			this.registrationLinkLabel.Size = new System.Drawing.Size(113, 13);
			this.registrationLinkLabel.TabIndex = 9;
			this.registrationLinkLabel.TabStop = true;
			this.registrationLinkLabel.Text = "Зарегистрироваться";
			// 
			// AuthorizationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 242);
			this.Controls.Add(this.registrationLinkLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.captchaTextBox);
			this.Controls.Add(this.captchaLabel);
			this.Controls.Add(this.captchaPictureBox);
			this.Controls.Add(this.signInButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.loginLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AuthorizationWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button signInButton;
		private System.Windows.Forms.PictureBox captchaPictureBox;
		private System.Windows.Forms.TextBox captchaTextBox;
		private System.Windows.Forms.Label captchaLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel registrationLinkLabel;
	}
}