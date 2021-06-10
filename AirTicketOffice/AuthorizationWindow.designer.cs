
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
			this.signInButton = new MaterialSkin.Controls.MaterialButton();
			this.singUpButton = new MaterialSkin.Controls.MaterialButton();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.label = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// signInButton
			// 
			this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.signInButton.AutoSize = false;
			this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.signInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.signInButton.Depth = 0;
			this.signInButton.HighEmphasis = true;
			this.signInButton.Icon = null;
			this.signInButton.Location = new System.Drawing.Point(43, 484);
			this.signInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.signInButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.signInButton.Name = "signInButton";
			this.signInButton.Size = new System.Drawing.Size(366, 42);
			this.signInButton.TabIndex = 10;
			this.signInButton.Text = "Войти";
			this.signInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.signInButton.UseAccentColor = false;
			this.signInButton.UseVisualStyleBackColor = true;
			// 
			// singUpButton
			// 
			this.singUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.singUpButton.AutoSize = false;
			this.singUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.singUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.singUpButton.Depth = 0;
			this.singUpButton.HighEmphasis = true;
			this.singUpButton.Icon = null;
			this.singUpButton.Location = new System.Drawing.Point(43, 567);
			this.singUpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.singUpButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.singUpButton.Name = "singUpButton";
			this.singUpButton.Size = new System.Drawing.Size(366, 42);
			this.singUpButton.TabIndex = 15;
			this.singUpButton.Text = "Зарегистрироваться";
			this.singUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.singUpButton.UseAccentColor = false;
			this.singUpButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox.Image = global::AirTicketOffice.Properties.Resources.user_picture_0_5x;
			this.pictureBox.Location = new System.Drawing.Point(123, 90);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(200, 200);
			this.pictureBox.TabIndex = 8;
			this.pictureBox.TabStop = false;
			// 
			// loginTextBox
			// 
			this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginTextBox.Depth = 0;
			this.loginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.loginTextBox.Hint = "Логин";
			this.loginTextBox.LeadingIcon = null;
			this.loginTextBox.Location = new System.Drawing.Point(43, 327);
			this.loginTextBox.MaxLength = 50;
			this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.loginTextBox.Multiline = false;
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(366, 50);
			this.loginTextBox.TabIndex = 9;
			this.loginTextBox.Text = "";
			this.loginTextBox.TrailingIcon = null;
			this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Depth = 0;
			this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passwordTextBox.Hint = "Пароль";
			this.passwordTextBox.LeadingIcon = null;
			this.passwordTextBox.Location = new System.Drawing.Point(43, 403);
			this.passwordTextBox.MaxLength = 50;
			this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passwordTextBox.Multiline = false;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Password = true;
			this.passwordTextBox.Size = new System.Drawing.Size(366, 50);
			this.passwordTextBox.TabIndex = 11;
			this.passwordTextBox.Text = "";
			this.passwordTextBox.TrailingIcon = null;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label.AutoSize = true;
			this.label.Depth = 0;
			this.label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label.Location = new System.Drawing.Point(213, 537);
			this.label.MouseState = MaterialSkin.MouseState.HOVER;
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(28, 19);
			this.label.TabIndex = 14;
			this.label.Text = "или";
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(43, 547);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(165, 1);
			this.materialDivider1.TabIndex = 17;
			this.materialDivider1.Text = "materialDivider1";
			// 
			// materialDivider2
			// 
			this.materialDivider2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider2.Depth = 0;
			this.materialDivider2.Location = new System.Drawing.Point(244, 547);
			this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider2.Name = "materialDivider2";
			this.materialDivider2.Size = new System.Drawing.Size(165, 1);
			this.materialDivider2.TabIndex = 18;
			this.materialDivider2.Text = "materialDivider2";
			// 
			// AuthorizationWindow
			// 
			this.ClientSize = new System.Drawing.Size(450, 650);
			this.Controls.Add(this.materialDivider2);
			this.Controls.Add(this.materialDivider1);
			this.Controls.Add(this.singUpButton);
			this.Controls.Add(this.label);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.signInButton);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.pictureBox);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(450, 650);
			this.MinimumSize = new System.Drawing.Size(450, 650);
			this.Name = "AuthorizationWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MaterialSkin.Controls.MaterialButton signInButton;
		private MaterialSkin.Controls.MaterialButton singUpButton;
		private System.Windows.Forms.PictureBox pictureBox;
		private MaterialSkin.Controls.MaterialTextBox loginTextBox;
		private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
		private MaterialSkin.Controls.MaterialLabel label;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private MaterialSkin.Controls.MaterialDivider materialDivider2;
	}
}

