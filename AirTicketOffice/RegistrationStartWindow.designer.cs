
namespace AirTicketOffice
{
    partial class RegistrationStartWindow
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
			this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.cancelButton = new MaterialSkin.Controls.MaterialButton();
			this.label = new MaterialSkin.Controls.MaterialLabel();
			this.passwordAgainTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.continueButton = new MaterialSkin.Controls.MaterialButton();
			this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox();
			this.SuspendLayout();
			// 
			// materialDivider2
			// 
			this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider2.Depth = 0;
			this.materialDivider2.Location = new System.Drawing.Point(243, 401);
			this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider2.Name = "materialDivider2";
			this.materialDivider2.Size = new System.Drawing.Size(165, 1);
			this.materialDivider2.TabIndex = 25;
			this.materialDivider2.Text = "materialDivider2";
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(42, 401);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(165, 1);
			this.materialDivider1.TabIndex = 24;
			this.materialDivider1.Text = "materialDivider1";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.AutoSize = false;
			this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.cancelButton.Depth = 0;
			this.cancelButton.HighEmphasis = true;
			this.cancelButton.Icon = null;
			this.cancelButton.Location = new System.Drawing.Point(42, 421);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(366, 42);
			this.cancelButton.TabIndex = 23;
			this.cancelButton.Text = "Отменить";
			this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.cancelButton.UseAccentColor = false;
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// label
			// 
			this.label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label.AutoSize = true;
			this.label.Depth = 0;
			this.label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label.Location = new System.Drawing.Point(211, 391);
			this.label.MouseState = MaterialSkin.MouseState.HOVER;
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(28, 19);
			this.label.TabIndex = 22;
			this.label.Text = "или";
			// 
			// passwordAgainTextBox
			// 
			this.passwordAgainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordAgainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordAgainTextBox.Depth = 0;
			this.passwordAgainTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passwordAgainTextBox.Hint = "Повторите пароль";
			this.passwordAgainTextBox.LeadingIcon = null;
			this.passwordAgainTextBox.Location = new System.Drawing.Point(42, 257);
			this.passwordAgainTextBox.MaxLength = 50;
			this.passwordAgainTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passwordAgainTextBox.Multiline = false;
			this.passwordAgainTextBox.Name = "passwordAgainTextBox";
			this.passwordAgainTextBox.Size = new System.Drawing.Size(366, 50);
			this.passwordAgainTextBox.TabIndex = 21;
			this.passwordAgainTextBox.Text = "";
			this.passwordAgainTextBox.TrailingIcon = null;
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
			this.continueButton.Location = new System.Drawing.Point(42, 338);
			this.continueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.continueButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(366, 42);
			this.continueButton.TabIndex = 20;
			this.continueButton.Text = "Продолжить регистрацию";
			this.continueButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.continueButton.UseAccentColor = false;
			this.continueButton.UseVisualStyleBackColor = true;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Depth = 0;
			this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.passwordTextBox.Hint = "Введите пароль";
			this.passwordTextBox.LeadingIcon = null;
			this.passwordTextBox.Location = new System.Drawing.Point(42, 171);
			this.passwordTextBox.MaxLength = 50;
			this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.passwordTextBox.Multiline = false;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(366, 50);
			this.passwordTextBox.TabIndex = 19;
			this.passwordTextBox.Text = "";
			this.passwordTextBox.TrailingIcon = null;
			// 
			// loginTextBox
			// 
			this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginTextBox.Depth = 0;
			this.loginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.loginTextBox.Hint = "Введите логин";
			this.loginTextBox.LeadingIcon = null;
			this.loginTextBox.Location = new System.Drawing.Point(42, 85);
			this.loginTextBox.MaxLength = 50;
			this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
			this.loginTextBox.Multiline = false;
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(366, 50);
			this.loginTextBox.TabIndex = 19;
			this.loginTextBox.Tag = "";
			this.loginTextBox.Text = "";
			this.loginTextBox.TrailingIcon = null;
			// 
			// RegistrationStartWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 500);
			this.Controls.Add(this.materialDivider2);
			this.Controls.Add(this.materialDivider1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.label);
			this.Controls.Add(this.passwordAgainTextBox);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.MinimumSize = new System.Drawing.Size(450, 500);
			this.Name = "RegistrationStartWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация | Логин и пароль";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel label;
        private MaterialSkin.Controls.MaterialTextBox passwordAgainTextBox;
        private MaterialSkin.Controls.MaterialButton continueButton;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox loginTextBox;
		private MaterialSkin.Controls.MaterialButton cancelButton;
	}
}