
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.surnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.patronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.backButton = new MaterialSkin.Controls.MaterialButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.continueButton = new MaterialSkin.Controls.MaterialButton();
			this.genderComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.passportTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.phoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 70);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 344F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 424);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.surnameTextBox);
			this.panel1.Controls.Add(this.patronymicTextBox);
			this.panel1.Controls.Add(this.nameTextBox);
			this.panel1.Controls.Add(this.backButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(401, 418);
			this.panel1.TabIndex = 2;
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.surnameTextBox.Depth = 0;
			this.surnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.surnameTextBox.Hint = "Введите фамилию";
			this.surnameTextBox.LeadingIcon = null;
			this.surnameTextBox.Location = new System.Drawing.Point(23, 12);
			this.surnameTextBox.MaxLength = 50;
			this.surnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.surnameTextBox.Multiline = false;
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(352, 50);
			this.surnameTextBox.TabIndex = 56;
			this.surnameTextBox.Text = "";
			this.surnameTextBox.TrailingIcon = null;
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.patronymicTextBox.Depth = 0;
			this.patronymicTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.patronymicTextBox.Hint = "Введите отчество";
			this.patronymicTextBox.LeadingIcon = null;
			this.patronymicTextBox.Location = new System.Drawing.Point(23, 184);
			this.patronymicTextBox.MaxLength = 50;
			this.patronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.patronymicTextBox.Multiline = false;
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(352, 50);
			this.patronymicTextBox.TabIndex = 55;
			this.patronymicTextBox.Text = "";
			this.patronymicTextBox.TrailingIcon = null;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameTextBox.Depth = 0;
			this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.nameTextBox.Hint = "Введите имя";
			this.nameTextBox.LeadingIcon = null;
			this.nameTextBox.Location = new System.Drawing.Point(23, 98);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.nameTextBox.Multiline = false;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(352, 50);
			this.nameTextBox.TabIndex = 53;
			this.nameTextBox.Tag = "";
			this.nameTextBox.Text = "";
			this.nameTextBox.TrailingIcon = null;
			// 
			// backButton
			// 
			this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.backButton.AutoSize = false;
			this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.backButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.backButton.Depth = 0;
			this.backButton.HighEmphasis = true;
			this.backButton.Icon = null;
			this.backButton.Location = new System.Drawing.Point(23, 348);
			this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(352, 42);
			this.backButton.TabIndex = 52;
			this.backButton.Text = "Назад";
			this.backButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.backButton.UseAccentColor = false;
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.continueButton);
			this.panel2.Controls.Add(this.genderComboBox);
			this.panel2.Controls.Add(this.passportTextBox);
			this.panel2.Controls.Add(this.phoneTextBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(410, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(401, 418);
			this.panel2.TabIndex = 3;
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.continueButton.AutoSize = false;
			this.continueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.continueButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.continueButton.Depth = 0;
			this.continueButton.HighEmphasis = true;
			this.continueButton.Icon = null;
			this.continueButton.Location = new System.Drawing.Point(26, 348);
			this.continueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.continueButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(352, 42);
			this.continueButton.TabIndex = 52;
			this.continueButton.Text = "Завершить регистрацию";
			this.continueButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.continueButton.UseAccentColor = false;
			this.continueButton.UseVisualStyleBackColor = true;
			// 
			// genderComboBox
			// 
			this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.genderComboBox.AutoResize = false;
			this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.genderComboBox.Depth = 0;
			this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.genderComboBox.DropDownHeight = 174;
			this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genderComboBox.DropDownWidth = 121;
			this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Hint = "Выберите свой пол";
			this.genderComboBox.IntegralHeight = false;
			this.genderComboBox.ItemHeight = 43;
			this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.genderComboBox.Location = new System.Drawing.Point(26, 184);
			this.genderComboBox.MaxDropDownItems = 4;
			this.genderComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(352, 49);
			this.genderComboBox.StartIndex = 0;
			this.genderComboBox.TabIndex = 51;
			// 
			// passportTextBox
			// 
			this.passportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passportTextBox.Depth = 0;
			this.passportTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passportTextBox.Hint = "Введите номер паспорта";
			this.passportTextBox.LeadingIcon = null;
			this.passportTextBox.Location = new System.Drawing.Point(26, 12);
			this.passportTextBox.MaxLength = 50;
			this.passportTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passportTextBox.Multiline = false;
			this.passportTextBox.Name = "passportTextBox";
			this.passportTextBox.Size = new System.Drawing.Size(352, 50);
			this.passportTextBox.TabIndex = 49;
			this.passportTextBox.Tag = "";
			this.passportTextBox.Text = "";
			this.passportTextBox.TrailingIcon = null;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.phoneTextBox.Depth = 0;
			this.phoneTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.phoneTextBox.Hint = "Введите номер телефона";
			this.phoneTextBox.LeadingIcon = null;
			this.phoneTextBox.Location = new System.Drawing.Point(26, 98);
			this.phoneTextBox.MaxLength = 50;
			this.phoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.phoneTextBox.Multiline = false;
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(352, 50);
			this.phoneTextBox.TabIndex = 50;
			this.phoneTextBox.Text = "";
			this.phoneTextBox.TrailingIcon = null;
			// 
			// RegistrationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 500);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "RegistrationWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация | Личная информация";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private MaterialSkin.Controls.MaterialButton backButton;
		private System.Windows.Forms.Panel panel2;
		private MaterialSkin.Controls.MaterialButton continueButton;
		private MaterialSkin.Controls.MaterialComboBox genderComboBox;
		private MaterialSkin.Controls.MaterialTextBox passportTextBox;
		private MaterialSkin.Controls.MaterialTextBox phoneTextBox;
		private MaterialSkin.Controls.MaterialTextBox patronymicTextBox;
		private MaterialSkin.Controls.MaterialTextBox nameTextBox;
		private MaterialSkin.Controls.MaterialTextBox surnameTextBox;
	}
}