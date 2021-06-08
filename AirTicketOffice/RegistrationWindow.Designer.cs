
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
			this.cancelButton = new MaterialSkin.Controls.MaterialButton();
			this.signUpButton = new MaterialSkin.Controls.MaterialButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.repeatedPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.repeatedPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
			this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
			this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.genderComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.genderLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.phoneNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.phoneNumberLabel = new MaterialSkin.Controls.MaterialLabel();
			this.passportNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.passportNumberLabel = new MaterialSkin.Controls.MaterialLabel();
			this.patronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.patronymicLabel = new MaterialSkin.Controls.MaterialLabel();
			this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
			this.surnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.surnameLabel = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.cancelButton.Depth = 0;
			this.cancelButton.HighEmphasis = true;
			this.cancelButton.Icon = null;
			this.cancelButton.Location = new System.Drawing.Point(22, 577);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(82, 36);
			this.cancelButton.TabIndex = 21;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.cancelButton.UseAccentColor = false;
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// signUpButton
			// 
			this.signUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.signUpButton.Depth = 0;
			this.signUpButton.HighEmphasis = true;
			this.signUpButton.Icon = null;
			this.signUpButton.Location = new System.Drawing.Point(494, 577);
			this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.signUpButton.Name = "signUpButton";
			this.signUpButton.Size = new System.Drawing.Size(191, 36);
			this.signUpButton.TabIndex = 22;
			this.signUpButton.Text = "Зарегистрироваться";
			this.signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.signUpButton.UseAccentColor = false;
			this.signUpButton.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 67);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 501);
			this.tableLayoutPanel1.TabIndex = 23;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.repeatedPasswordTextBox);
			this.panel2.Controls.Add(this.repeatedPasswordLabel);
			this.panel2.Controls.Add(this.passwordTextBox);
			this.panel2.Controls.Add(this.passwordLabel);
			this.panel2.Controls.Add(this.loginTextBox);
			this.panel2.Controls.Add(this.loginLabel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(359, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(350, 495);
			this.panel2.TabIndex = 26;
			// 
			// repeatedPasswordTextBox
			// 
			this.repeatedPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.repeatedPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.repeatedPasswordTextBox.Depth = 0;
			this.repeatedPasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.repeatedPasswordTextBox.LeadingIcon = null;
			this.repeatedPasswordTextBox.Location = new System.Drawing.Point(25, 192);
			this.repeatedPasswordTextBox.MaxLength = 50;
			this.repeatedPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.repeatedPasswordTextBox.Multiline = false;
			this.repeatedPasswordTextBox.Name = "repeatedPasswordTextBox";
			this.repeatedPasswordTextBox.Size = new System.Drawing.Size(300, 36);
			this.repeatedPasswordTextBox.TabIndex = 31;
			this.repeatedPasswordTextBox.Text = "";
			this.repeatedPasswordTextBox.TrailingIcon = null;
			this.repeatedPasswordTextBox.UseTallSize = false;
			this.repeatedPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repeatedPasswordTextBox_KeyDown);
			// 
			// repeatedPasswordLabel
			// 
			this.repeatedPasswordLabel.AutoSize = true;
			this.repeatedPasswordLabel.Depth = 0;
			this.repeatedPasswordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.repeatedPasswordLabel.Location = new System.Drawing.Point(12, 170);
			this.repeatedPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.repeatedPasswordLabel.Name = "repeatedPasswordLabel";
			this.repeatedPasswordLabel.Size = new System.Drawing.Size(139, 19);
			this.repeatedPasswordLabel.TabIndex = 30;
			this.repeatedPasswordLabel.Text = "Повторите пароль";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Depth = 0;
			this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passwordTextBox.LeadingIcon = null;
			this.passwordTextBox.Location = new System.Drawing.Point(25, 109);
			this.passwordTextBox.MaxLength = 50;
			this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passwordTextBox.Multiline = false;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(300, 36);
			this.passwordTextBox.TabIndex = 29;
			this.passwordTextBox.Text = "";
			this.passwordTextBox.TrailingIcon = null;
			this.passwordTextBox.UseTallSize = false;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Depth = 0;
			this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passwordLabel.Location = new System.Drawing.Point(12, 87);
			this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(57, 19);
			this.passwordLabel.TabIndex = 28;
			this.passwordLabel.Text = "Пароль";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginTextBox.Depth = 0;
			this.loginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.loginTextBox.LeadingIcon = null;
			this.loginTextBox.Location = new System.Drawing.Point(25, 31);
			this.loginTextBox.MaxLength = 50;
			this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.loginTextBox.Multiline = false;
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(300, 36);
			this.loginTextBox.TabIndex = 27;
			this.loginTextBox.Text = "";
			this.loginTextBox.TrailingIcon = null;
			this.loginTextBox.UseTallSize = false;
			this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Depth = 0;
			this.loginLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.loginLabel.Location = new System.Drawing.Point(12, 9);
			this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(46, 19);
			this.loginLabel.TabIndex = 26;
			this.loginLabel.Text = "Логин";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.genderComboBox);
			this.panel1.Controls.Add(this.genderLabel);
			this.panel1.Controls.Add(this.materialDivider1);
			this.panel1.Controls.Add(this.phoneNumberTextBox);
			this.panel1.Controls.Add(this.phoneNumberLabel);
			this.panel1.Controls.Add(this.passportNumberTextBox);
			this.panel1.Controls.Add(this.passportNumberLabel);
			this.panel1.Controls.Add(this.patronymicTextBox);
			this.panel1.Controls.Add(this.patronymicLabel);
			this.panel1.Controls.Add(this.nameTextBox);
			this.panel1.Controls.Add(this.nameLabel);
			this.panel1.Controls.Add(this.surnameTextBox);
			this.panel1.Controls.Add(this.surnameLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 495);
			this.panel1.TabIndex = 25;
			// 
			// genderComboBox
			// 
			this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.genderComboBox.AutoResize = false;
			this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.genderComboBox.Depth = 0;
			this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.genderComboBox.DropDownHeight = 118;
			this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genderComboBox.DropDownWidth = 121;
			this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.IntegralHeight = false;
			this.genderComboBox.ItemHeight = 29;
			this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.genderComboBox.Location = new System.Drawing.Point(30, 274);
			this.genderComboBox.MaxDropDownItems = 4;
			this.genderComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(299, 35);
			this.genderComboBox.StartIndex = 0;
			this.genderComboBox.TabIndex = 49;
			this.genderComboBox.UseTallSize = false;
			// 
			// genderLabel
			// 
			this.genderLabel.AutoSize = true;
			this.genderLabel.Depth = 0;
			this.genderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.genderLabel.Location = new System.Drawing.Point(17, 252);
			this.genderLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(30, 19);
			this.genderLabel.TabIndex = 48;
			this.genderLabel.Text = "Пол";
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(20, 332);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(309, 1);
			this.materialDivider1.TabIndex = 47;
			this.materialDivider1.Text = "materialDivider1";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.phoneNumberTextBox.Depth = 0;
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.phoneNumberTextBox.LeadingIcon = null;
			this.phoneNumberTextBox.Location = new System.Drawing.Point(30, 450);
			this.phoneNumberTextBox.MaxLength = 50;
			this.phoneNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.phoneNumberTextBox.Multiline = false;
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(299, 36);
			this.phoneNumberTextBox.TabIndex = 46;
			this.phoneNumberTextBox.Text = "";
			this.phoneNumberTextBox.TrailingIcon = null;
			this.phoneNumberTextBox.UseTallSize = false;
			this.phoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumberTextBox_KeyDown);
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Depth = 0;
			this.phoneNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.phoneNumberLabel.Location = new System.Drawing.Point(17, 428);
			this.phoneNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(126, 19);
			this.phoneNumberLabel.TabIndex = 45;
			this.phoneNumberLabel.Text = "Номер телефона";
			// 
			// passportNumberTextBox
			// 
			this.passportNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passportNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passportNumberTextBox.Depth = 0;
			this.passportNumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passportNumberTextBox.LeadingIcon = null;
			this.passportNumberTextBox.Location = new System.Drawing.Point(30, 370);
			this.passportNumberTextBox.MaxLength = 50;
			this.passportNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passportNumberTextBox.Multiline = false;
			this.passportNumberTextBox.Name = "passportNumberTextBox";
			this.passportNumberTextBox.Size = new System.Drawing.Size(299, 36);
			this.passportNumberTextBox.TabIndex = 44;
			this.passportNumberTextBox.Text = "";
			this.passportNumberTextBox.TrailingIcon = null;
			this.passportNumberTextBox.UseTallSize = false;
			this.passportNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passportNumberTextBox_KeyDown);
			// 
			// passportNumberLabel
			// 
			this.passportNumberLabel.AutoSize = true;
			this.passportNumberLabel.Depth = 0;
			this.passportNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passportNumberLabel.Location = new System.Drawing.Point(17, 348);
			this.passportNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.passportNumberLabel.Name = "passportNumberLabel";
			this.passportNumberLabel.Size = new System.Drawing.Size(124, 19);
			this.passportNumberLabel.TabIndex = 43;
			this.passportNumberLabel.Text = "Номер паспорта";
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.patronymicTextBox.Depth = 0;
			this.patronymicTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.patronymicTextBox.LeadingIcon = null;
			this.patronymicTextBox.Location = new System.Drawing.Point(30, 192);
			this.patronymicTextBox.MaxLength = 50;
			this.patronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.patronymicTextBox.Multiline = false;
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(299, 36);
			this.patronymicTextBox.TabIndex = 42;
			this.patronymicTextBox.Text = "";
			this.patronymicTextBox.TrailingIcon = null;
			this.patronymicTextBox.UseTallSize = false;
			this.patronymicTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patronymicTextBox_KeyDown);
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Depth = 0;
			this.patronymicLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.patronymicLabel.Location = new System.Drawing.Point(17, 170);
			this.patronymicLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(71, 19);
			this.patronymicLabel.TabIndex = 41;
			this.patronymicLabel.Text = "Отчество";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameTextBox.Depth = 0;
			this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.nameTextBox.LeadingIcon = null;
			this.nameTextBox.Location = new System.Drawing.Point(30, 109);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.nameTextBox.Multiline = false;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(299, 36);
			this.nameTextBox.TabIndex = 40;
			this.nameTextBox.Text = "";
			this.nameTextBox.TrailingIcon = null;
			this.nameTextBox.UseTallSize = false;
			this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Depth = 0;
			this.nameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.nameLabel.Location = new System.Drawing.Point(17, 87);
			this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(33, 19);
			this.nameLabel.TabIndex = 39;
			this.nameLabel.Text = "Имя";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.surnameTextBox.Depth = 0;
			this.surnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.surnameTextBox.LeadingIcon = null;
			this.surnameTextBox.Location = new System.Drawing.Point(30, 31);
			this.surnameTextBox.MaxLength = 50;
			this.surnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.surnameTextBox.Multiline = false;
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(299, 36);
			this.surnameTextBox.TabIndex = 38;
			this.surnameTextBox.Text = "";
			this.surnameTextBox.TrailingIcon = null;
			this.surnameTextBox.UseTallSize = false;
			this.surnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surnameTextBox_KeyDown);
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Depth = 0;
			this.surnameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.surnameLabel.Location = new System.Drawing.Point(17, 9);
			this.surnameLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(70, 19);
			this.surnameLabel.TabIndex = 37;
			this.surnameLabel.Text = "Фамилия";
			// 
			// RegistrationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 638);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.signUpButton);
			this.Controls.Add(this.cancelButton);
			this.MinimumSize = new System.Drawing.Size(709, 638);
			this.Name = "RegistrationWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Регистрация";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MaterialSkin.Controls.MaterialButton cancelButton;
		private MaterialSkin.Controls.MaterialButton signUpButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private MaterialSkin.Controls.MaterialTextBox repeatedPasswordTextBox;
		private MaterialSkin.Controls.MaterialLabel repeatedPasswordLabel;
		private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
		private MaterialSkin.Controls.MaterialLabel passwordLabel;
		private MaterialSkin.Controls.MaterialTextBox loginTextBox;
		private MaterialSkin.Controls.MaterialLabel loginLabel;
		private System.Windows.Forms.Panel panel1;
		private MaterialSkin.Controls.MaterialComboBox genderComboBox;
		private MaterialSkin.Controls.MaterialLabel genderLabel;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private MaterialSkin.Controls.MaterialTextBox phoneNumberTextBox;
		private MaterialSkin.Controls.MaterialLabel phoneNumberLabel;
		private MaterialSkin.Controls.MaterialTextBox passportNumberTextBox;
		private MaterialSkin.Controls.MaterialLabel passportNumberLabel;
		private MaterialSkin.Controls.MaterialTextBox patronymicTextBox;
		private MaterialSkin.Controls.MaterialLabel patronymicLabel;
		private MaterialSkin.Controls.MaterialTextBox nameTextBox;
		private MaterialSkin.Controls.MaterialLabel nameLabel;
		private MaterialSkin.Controls.MaterialTextBox surnameTextBox;
		private MaterialSkin.Controls.MaterialLabel surnameLabel;
	}
}