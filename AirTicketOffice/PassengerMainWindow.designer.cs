using System.Windows.Forms;

namespace AirTicketOffice
{
	partial class PassengerMainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerMainWindow));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.profileTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.accountGenderComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPatronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.accountNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.accountSurnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.changePasswordButton = new MaterialSkin.Controls.MaterialButton();
			this.accountLoginTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPhoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.accountPassportTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.exitFromAccountButton = new MaterialSkin.Controls.MaterialButton();
			this.saveAccountChangesButton = new MaterialSkin.Controls.MaterialButton();
			this.orderTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewCard = new MaterialSkin.Controls.MaterialCard();
			this.flightsDataGridView = new System.Windows.Forms.DataGridView();
			this.flightsNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsRouteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flightsDateToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.propertiesCard = new MaterialSkin.Controls.MaterialCard();
			this.mapTabPage = new System.Windows.Forms.TabPage();
			this.actionIconsImageList = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.carouselCard = new MaterialSkin.Controls.MaterialCard();
			this.mainTabControl.SuspendLayout();
			this.profileTabPage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.orderTabPage.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.dataGridViewCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTabControlImageList
			// 
			this.mainTabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabControlImageList.ImageStream")));
			this.mainTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.mainTabControlImageList.Images.SetKeyName(0, "home_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(1, "user_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(2, "search_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(3, "filter_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(4, "print_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(5, "map_icon.png");
			this.mainTabControlImageList.Images.SetKeyName(6, "order_icon.png");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.profileTabPage);
			this.mainTabControl.Controls.Add(this.orderTabPage);
			this.mainTabControl.Controls.Add(this.mapTabPage);
			this.mainTabControl.Depth = 0;
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.ImageList = this.mainTabControlImageList;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.mainTabControl.Multiline = true;
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(800, 428);
			this.mainTabControl.TabIndex = 5;
			this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
			// 
			// profileTabPage
			// 
			this.profileTabPage.BackColor = System.Drawing.Color.White;
			this.profileTabPage.Controls.Add(this.tableLayoutPanel1);
			this.profileTabPage.Controls.Add(this.panel3);
			this.profileTabPage.ImageKey = "user_icon.png";
			this.profileTabPage.Location = new System.Drawing.Point(4, 39);
			this.profileTabPage.Name = "profileTabPage";
			this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.profileTabPage.Size = new System.Drawing.Size(792, 385);
			this.profileTabPage.TabIndex = 1;
			this.profileTabPage.Text = "Мой профиль";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 332);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.accountGenderComboBox);
			this.panel4.Controls.Add(this.materialLabel2);
			this.panel4.Controls.Add(this.accountPatronymicTextBox);
			this.panel4.Controls.Add(this.materialLabel5);
			this.panel4.Controls.Add(this.accountNameTextBox);
			this.panel4.Controls.Add(this.materialLabel4);
			this.panel4.Controls.Add(this.accountSurnameTextBox);
			this.panel4.Controls.Add(this.materialLabel3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(387, 326);
			this.panel4.TabIndex = 2;
			// 
			// accountGenderComboBox
			// 
			this.accountGenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountGenderComboBox.AutoResize = false;
			this.accountGenderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.accountGenderComboBox.Depth = 0;
			this.accountGenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.accountGenderComboBox.DropDownHeight = 118;
			this.accountGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.accountGenderComboBox.DropDownWidth = 121;
			this.accountGenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.accountGenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.accountGenderComboBox.FormattingEnabled = true;
			this.accountGenderComboBox.IntegralHeight = false;
			this.accountGenderComboBox.ItemHeight = 29;
			this.accountGenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.accountGenderComboBox.Location = new System.Drawing.Point(17, 260);
			this.accountGenderComboBox.MaxDropDownItems = 4;
			this.accountGenderComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountGenderComboBox.Name = "accountGenderComboBox";
			this.accountGenderComboBox.Size = new System.Drawing.Size(363, 35);
			this.accountGenderComboBox.StartIndex = 0;
			this.accountGenderComboBox.TabIndex = 24;
			this.accountGenderComboBox.UseTallSize = false;
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.Location = new System.Drawing.Point(7, 238);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(30, 19);
			this.materialLabel2.TabIndex = 23;
			this.materialLabel2.Text = "Пол";
			// 
			// accountPatronymicTextBox
			// 
			this.accountPatronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPatronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPatronymicTextBox.Depth = 0;
			this.accountPatronymicTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPatronymicTextBox.LeadingIcon = null;
			this.accountPatronymicTextBox.Location = new System.Drawing.Point(17, 184);
			this.accountPatronymicTextBox.MaxLength = 50;
			this.accountPatronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPatronymicTextBox.Multiline = false;
			this.accountPatronymicTextBox.Name = "accountPatronymicTextBox";
			this.accountPatronymicTextBox.Size = new System.Drawing.Size(363, 36);
			this.accountPatronymicTextBox.TabIndex = 22;
			this.accountPatronymicTextBox.Text = "";
			this.accountPatronymicTextBox.TrailingIcon = null;
			this.accountPatronymicTextBox.UseTallSize = false;
			// 
			// materialLabel5
			// 
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel5.Location = new System.Drawing.Point(7, 162);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(71, 19);
			this.materialLabel5.TabIndex = 21;
			this.materialLabel5.Text = "Отчество";
			// 
			// accountNameTextBox
			// 
			this.accountNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountNameTextBox.Depth = 0;
			this.accountNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountNameTextBox.LeadingIcon = null;
			this.accountNameTextBox.Location = new System.Drawing.Point(17, 108);
			this.accountNameTextBox.MaxLength = 50;
			this.accountNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountNameTextBox.Multiline = false;
			this.accountNameTextBox.Name = "accountNameTextBox";
			this.accountNameTextBox.Size = new System.Drawing.Size(363, 36);
			this.accountNameTextBox.TabIndex = 20;
			this.accountNameTextBox.Text = "";
			this.accountNameTextBox.TrailingIcon = null;
			this.accountNameTextBox.UseTallSize = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.Location = new System.Drawing.Point(7, 86);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(33, 19);
			this.materialLabel4.TabIndex = 19;
			this.materialLabel4.Text = "Имя";
			// 
			// accountSurnameTextBox
			// 
			this.accountSurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountSurnameTextBox.Depth = 0;
			this.accountSurnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountSurnameTextBox.LeadingIcon = null;
			this.accountSurnameTextBox.Location = new System.Drawing.Point(17, 32);
			this.accountSurnameTextBox.MaxLength = 50;
			this.accountSurnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountSurnameTextBox.Multiline = false;
			this.accountSurnameTextBox.Name = "accountSurnameTextBox";
			this.accountSurnameTextBox.Size = new System.Drawing.Size(363, 36);
			this.accountSurnameTextBox.TabIndex = 18;
			this.accountSurnameTextBox.Text = "";
			this.accountSurnameTextBox.TrailingIcon = null;
			this.accountSurnameTextBox.UseTallSize = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.Location = new System.Drawing.Point(7, 10);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(70, 19);
			this.materialLabel3.TabIndex = 17;
			this.materialLabel3.Text = "Фамилия";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.changePasswordButton);
			this.panel5.Controls.Add(this.accountLoginTextBox);
			this.panel5.Controls.Add(this.materialLabel1);
			this.panel5.Controls.Add(this.accountPhoneTextBox);
			this.panel5.Controls.Add(this.materialLabel7);
			this.panel5.Controls.Add(this.materialLabel6);
			this.panel5.Controls.Add(this.accountPassportTextBox);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(396, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(387, 326);
			this.panel5.TabIndex = 3;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.changePasswordButton.AutoSize = false;
			this.changePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.changePasswordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.changePasswordButton.Depth = 0;
			this.changePasswordButton.HighEmphasis = true;
			this.changePasswordButton.Icon = null;
			this.changePasswordButton.Location = new System.Drawing.Point(21, 259);
			this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.changePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(362, 36);
			this.changePasswordButton.TabIndex = 29;
			this.changePasswordButton.Text = "Сменить пароль";
			this.changePasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.changePasswordButton.UseAccentColor = false;
			this.changePasswordButton.UseVisualStyleBackColor = true;
			// 
			// accountLoginTextBox
			// 
			this.accountLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountLoginTextBox.Depth = 0;
			this.accountLoginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountLoginTextBox.LeadingIcon = null;
			this.accountLoginTextBox.Location = new System.Drawing.Point(21, 32);
			this.accountLoginTextBox.MaxLength = 50;
			this.accountLoginTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountLoginTextBox.Multiline = false;
			this.accountLoginTextBox.Name = "accountLoginTextBox";
			this.accountLoginTextBox.Size = new System.Drawing.Size(362, 36);
			this.accountLoginTextBox.TabIndex = 28;
			this.accountLoginTextBox.Text = "";
			this.accountLoginTextBox.TrailingIcon = null;
			this.accountLoginTextBox.UseTallSize = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(11, 10);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(46, 19);
			this.materialLabel1.TabIndex = 27;
			this.materialLabel1.Text = "Логин";
			// 
			// accountPhoneTextBox
			// 
			this.accountPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPhoneTextBox.Depth = 0;
			this.accountPhoneTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPhoneTextBox.LeadingIcon = null;
			this.accountPhoneTextBox.Location = new System.Drawing.Point(21, 184);
			this.accountPhoneTextBox.MaxLength = 50;
			this.accountPhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPhoneTextBox.Multiline = false;
			this.accountPhoneTextBox.Name = "accountPhoneTextBox";
			this.accountPhoneTextBox.Size = new System.Drawing.Size(362, 36);
			this.accountPhoneTextBox.TabIndex = 26;
			this.accountPhoneTextBox.Text = "";
			this.accountPhoneTextBox.TrailingIcon = null;
			this.accountPhoneTextBox.UseTallSize = false;
			// 
			// materialLabel7
			// 
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel7.Location = new System.Drawing.Point(11, 162);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(126, 19);
			this.materialLabel7.TabIndex = 25;
			this.materialLabel7.Text = "Номер телефона";
			// 
			// materialLabel6
			// 
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel6.Location = new System.Drawing.Point(13, 86);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(124, 19);
			this.materialLabel6.TabIndex = 23;
			this.materialLabel6.Text = "Номер паспорта";
			// 
			// accountPassportTextBox
			// 
			this.accountPassportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountPassportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountPassportTextBox.Depth = 0;
			this.accountPassportTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.accountPassportTextBox.LeadingIcon = null;
			this.accountPassportTextBox.Location = new System.Drawing.Point(21, 108);
			this.accountPassportTextBox.MaxLength = 50;
			this.accountPassportTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.accountPassportTextBox.Multiline = false;
			this.accountPassportTextBox.Name = "accountPassportTextBox";
			this.accountPassportTextBox.Size = new System.Drawing.Size(362, 36);
			this.accountPassportTextBox.TabIndex = 24;
			this.accountPassportTextBox.Text = "";
			this.accountPassportTextBox.TrailingIcon = null;
			this.accountPassportTextBox.UseTallSize = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.exitFromAccountButton);
			this.panel3.Controls.Add(this.saveAccountChangesButton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(3, 335);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(786, 47);
			this.panel3.TabIndex = 0;
			// 
			// exitFromAccountButton
			// 
			this.exitFromAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exitFromAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exitFromAccountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.exitFromAccountButton.Depth = 0;
			this.exitFromAccountButton.HighEmphasis = true;
			this.exitFromAccountButton.Icon = null;
			this.exitFromAccountButton.Location = new System.Drawing.Point(6, 5);
			this.exitFromAccountButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.exitFromAccountButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.exitFromAccountButton.Name = "exitFromAccountButton";
			this.exitFromAccountButton.Size = new System.Drawing.Size(177, 36);
			this.exitFromAccountButton.TabIndex = 5;
			this.exitFromAccountButton.Text = "Выйти из аккаунта";
			this.exitFromAccountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.exitFromAccountButton.UseAccentColor = false;
			this.exitFromAccountButton.UseVisualStyleBackColor = true;
			// 
			// saveAccountChangesButton
			// 
			this.saveAccountChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveAccountChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveAccountChangesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.saveAccountChangesButton.Depth = 0;
			this.saveAccountChangesButton.HighEmphasis = true;
			this.saveAccountChangesButton.Icon = null;
			this.saveAccountChangesButton.Location = new System.Drawing.Point(577, 5);
			this.saveAccountChangesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.saveAccountChangesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.saveAccountChangesButton.Name = "saveAccountChangesButton";
			this.saveAccountChangesButton.Size = new System.Drawing.Size(203, 36);
			this.saveAccountChangesButton.TabIndex = 3;
			this.saveAccountChangesButton.Text = "Сохранить изменения";
			this.saveAccountChangesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.saveAccountChangesButton.UseAccentColor = false;
			this.saveAccountChangesButton.UseVisualStyleBackColor = true;
			// 
			// orderTabPage
			// 
			this.orderTabPage.Controls.Add(this.tableLayoutPanel2);
			this.orderTabPage.ImageKey = "order_icon.png";
			this.orderTabPage.Location = new System.Drawing.Point(4, 39);
			this.orderTabPage.Name = "orderTabPage";
			this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.orderTabPage.Size = new System.Drawing.Size(792, 385);
			this.orderTabPage.TabIndex = 2;
			this.orderTabPage.Text = "Заявка";
			this.orderTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.dataGridViewCard, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.propertiesCard, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.carouselCard, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 379);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// dataGridViewCard
			// 
			this.dataGridViewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridViewCard.Controls.Add(this.flightsDataGridView);
			this.dataGridViewCard.Depth = 0;
			this.dataGridViewCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.dataGridViewCard.Location = new System.Drawing.Point(210, 14);
			this.dataGridViewCard.Margin = new System.Windows.Forms.Padding(14);
			this.dataGridViewCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.dataGridViewCard.Name = "dataGridViewCard";
			this.dataGridViewCard.Padding = new System.Windows.Forms.Padding(14);
			this.dataGridViewCard.Size = new System.Drawing.Size(365, 351);
			this.dataGridViewCard.TabIndex = 4;
			// 
			// flightsDataGridView
			// 
			this.flightsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.flightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightsNumberColumn,
            this.flightsPlaneColumn,
            this.flightsRouteColumn,
            this.flightsDateFromColumn,
            this.flightsDateToColumn});
			this.flightsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightsDataGridView.Location = new System.Drawing.Point(14, 14);
			this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.flightsDataGridView.Name = "flightsDataGridView";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.flightsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.flightsDataGridView.RowHeadersVisible = false;
			this.flightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.flightsDataGridView.Size = new System.Drawing.Size(337, 323);
			this.flightsDataGridView.TabIndex = 3;
			// 
			// flightsNumberColumn
			// 
			this.flightsNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsNumberColumn.FillWeight = 10F;
			this.flightsNumberColumn.HeaderText = "№";
			this.flightsNumberColumn.Name = "flightsNumberColumn";
			this.flightsNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// flightsPlaneColumn
			// 
			this.flightsPlaneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsPlaneColumn.FillWeight = 22.5F;
			this.flightsPlaneColumn.HeaderText = "Самолет";
			this.flightsPlaneColumn.Name = "flightsPlaneColumn";
			// 
			// flightsRouteColumn
			// 
			this.flightsRouteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsRouteColumn.FillWeight = 22.5F;
			this.flightsRouteColumn.HeaderText = "Маршрут";
			this.flightsRouteColumn.Name = "flightsRouteColumn";
			// 
			// flightsDateFromColumn
			// 
			this.flightsDateFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateFromColumn.FillWeight = 22.5F;
			this.flightsDateFromColumn.HeaderText = "Дата и время отлета";
			this.flightsDateFromColumn.Name = "flightsDateFromColumn";
			// 
			// flightsDateToColumn
			// 
			this.flightsDateToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.flightsDateToColumn.FillWeight = 22.5F;
			this.flightsDateToColumn.HeaderText = "Дата и время прилета";
			this.flightsDateToColumn.Name = "flightsDateToColumn";
			// 
			// propertiesCard
			// 
			this.propertiesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.propertiesCard.Depth = 0;
			this.propertiesCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertiesCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.propertiesCard.Location = new System.Drawing.Point(603, 14);
			this.propertiesCard.Margin = new System.Windows.Forms.Padding(14);
			this.propertiesCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.propertiesCard.Name = "propertiesCard";
			this.propertiesCard.Padding = new System.Windows.Forms.Padding(14);
			this.propertiesCard.Size = new System.Drawing.Size(169, 351);
			this.propertiesCard.TabIndex = 5;
			// 
			// mapTabPage
			// 
			this.mapTabPage.BackColor = System.Drawing.Color.White;
			this.mapTabPage.ImageKey = "map_icon.png";
			this.mapTabPage.Location = new System.Drawing.Point(4, 39);
			this.mapTabPage.Margin = new System.Windows.Forms.Padding(0);
			this.mapTabPage.Name = "mapTabPage";
			this.mapTabPage.Size = new System.Drawing.Size(792, 385);
			this.mapTabPage.TabIndex = 0;
			this.mapTabPage.Text = "Карта";
			// 
			// actionIconsImageList
			// 
			this.actionIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("actionIconsImageList.ImageStream")));
			this.actionIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.actionIconsImageList.Images.SetKeyName(0, "add_icon.png");
			this.actionIconsImageList.Images.SetKeyName(1, "delete_icon.png");
			this.actionIconsImageList.Images.SetKeyName(2, "save_icon.png");
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// carouselCard
			// 
			this.carouselCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.carouselCard.Depth = 0;
			this.carouselCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carouselCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.carouselCard.Location = new System.Drawing.Point(14, 14);
			this.carouselCard.Margin = new System.Windows.Forms.Padding(14);
			this.carouselCard.MouseState = MaterialSkin.MouseState.HOVER;
			this.carouselCard.Name = "carouselCard";
			this.carouselCard.Padding = new System.Windows.Forms.Padding(14);
			this.carouselCard.Size = new System.Drawing.Size(168, 351);
			this.carouselCard.TabIndex = 6;
			// 
			// PassengerMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.statusStrip1);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.mainTabControl;
			this.Name = "PassengerMainWindow";
			this.Padding = new System.Windows.Forms.Padding(0);
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.PassengerMainWindow_Load);
			this.mainTabControl.ResumeLayout(false);
			this.profileTabPage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.orderTabPage.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.dataGridViewCard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList mainTabControlImageList;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private MaterialSkin.Controls.MaterialTabControl mainTabControl;
		private System.Windows.Forms.TabPage mapTabPage;
		private ImageList actionIconsImageList;
		private TabPage profileTabPage;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel4;
		private MaterialSkin.Controls.MaterialComboBox accountGenderComboBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialTextBox accountPatronymicTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialTextBox accountNameTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialTextBox accountSurnameTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private Panel panel5;
		private MaterialSkin.Controls.MaterialButton changePasswordButton;
		private MaterialSkin.Controls.MaterialTextBox accountLoginTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialTextBox accountPhoneTextBox;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialTextBox accountPassportTextBox;
		private Panel panel3;
		private MaterialSkin.Controls.MaterialButton exitFromAccountButton;
		private MaterialSkin.Controls.MaterialButton saveAccountChangesButton;
		private TabPage orderTabPage;
		private TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialCard dataGridViewCard;
		private DataGridView flightsDataGridView;
		private MaterialSkin.Controls.MaterialCard propertiesCard;
		private DataGridViewTextBoxColumn flightsNumberColumn;
		private DataGridViewTextBoxColumn flightsPlaneColumn;
		private DataGridViewTextBoxColumn flightsRouteColumn;
		private DataGridViewTextBoxColumn flightsDateFromColumn;
		private DataGridViewTextBoxColumn flightsDateToColumn;
		private Timer timer1;
		private MaterialSkin.Controls.MaterialCard carouselCard;
	}
}

