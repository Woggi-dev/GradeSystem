
namespace GradeSystem.forms
{
    partial class logForm
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
            this.fullyLogButton = new System.Windows.Forms.Button();
            this.pwdShowCheckbox = new System.Windows.Forms.CheckBox();
            this.pwdTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.homepageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullyLogButton
            // 
            this.fullyLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.fullyLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullyLogButton.FlatAppearance.BorderSize = 0;
            this.fullyLogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.fullyLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullyLogButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullyLogButton.ForeColor = System.Drawing.Color.White;
            this.fullyLogButton.Location = new System.Drawing.Point(79, 391);
            this.fullyLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullyLogButton.Name = "fullyLogButton";
            this.fullyLogButton.Size = new System.Drawing.Size(365, 37);
            this.fullyLogButton.TabIndex = 31;
            this.fullyLogButton.Text = "Войти";
            this.fullyLogButton.UseVisualStyleBackColor = false;
            this.fullyLogButton.Click += new System.EventHandler(this.fullyLogButton_Click);
            // 
            // pwdShowCheckbox
            // 
            this.pwdShowCheckbox.AutoSize = true;
            this.pwdShowCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwdShowCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pwdShowCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.pwdShowCheckbox.Location = new System.Drawing.Point(79, 315);
            this.pwdShowCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwdShowCheckbox.Name = "pwdShowCheckbox";
            this.pwdShowCheckbox.Size = new System.Drawing.Size(166, 27);
            this.pwdShowCheckbox.TabIndex = 28;
            this.pwdShowCheckbox.Text = "Показать пароль";
            this.pwdShowCheckbox.UseVisualStyleBackColor = true;
            this.pwdShowCheckbox.CheckedChanged += new System.EventHandler(this.pwdShowCheckbox_CheckedChanged);
            // 
            // pwdTextbox
            // 
            this.pwdTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pwdTextbox.Location = new System.Drawing.Point(79, 266);
            this.pwdTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwdTextbox.MaxLength = 50;
            this.pwdTextbox.Multiline = true;
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.PasswordChar = '•';
            this.pwdTextbox.Size = new System.Drawing.Size(364, 42);
            this.pwdTextbox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label5.Location = new System.Drawing.Point(79, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextbox.Location = new System.Drawing.Point(79, 171);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTextbox.MaxLength = 50;
            this.loginTextbox.Multiline = true;
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(364, 42);
            this.loginTextbox.TabIndex = 23;
            this.loginTextbox.TextChanged += new System.EventHandler(this.loginTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(79, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Телефон или электронная почта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(79, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "или";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Black;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.regButton.Location = new System.Drawing.Point(79, 480);
            this.regButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(365, 37);
            this.regButton.TabIndex = 34;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // homepageButton
            // 
            this.homepageButton.BackgroundImage = global::GradeSystem.Properties.Resources.white_crossed1;
            this.homepageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homepageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.ForeColor = System.Drawing.Color.Gray;
            this.homepageButton.Location = new System.Drawing.Point(16, 15);
            this.homepageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(20, 18);
            this.homepageButton.TabIndex = 35;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.button1.Location = new System.Drawing.Point(288, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "Забыли пароль?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Khaki;
            this.errorLabel.Location = new System.Drawing.Point(79, 357);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(365, 31);
            this.errorLabel.TabIndex = 37;
            this.errorLabel.Text = "Введен некорректный логин или пароль.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorLabel.Visible = false;
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(520, 564);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homepageButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullyLogButton);
            this.Controls.Add(this.pwdShowCheckbox);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "logForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.logForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullyLogButton;
        private System.Windows.Forms.CheckBox pwdShowCheckbox;
        private System.Windows.Forms.TextBox pwdTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
    }
}