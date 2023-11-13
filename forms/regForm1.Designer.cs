
namespace GradeSystem.forms
{
    partial class regForm1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patronymicTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.patronymicCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.homepageButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.errorLabelName = new System.Windows.Forms.Label();
            this.errorLabelSurname = new System.Windows.Forms.Label();
            this.errorLabelPatronymic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(52, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 69);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проверьте, что вводите данные в правильном формате. Допустимо использовать только" +
    " кириллицу.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Личные данные";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(48, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.Azure;
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nameTextbox.Location = new System.Drawing.Point(52, 240);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(278, 35);
            this.nameTextbox.TabIndex = 7;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.surnameTextbox.Location = new System.Drawing.Point(52, 157);
            this.surnameTextbox.Multiline = true;
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(278, 35);
            this.surnameTextbox.TabIndex = 9;
            this.surnameTextbox.TextChanged += new System.EventHandler(this.surnameTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label5.Location = new System.Drawing.Point(48, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фамилия";
            // 
            // patronymicTextbox
            // 
            this.patronymicTextbox.BackColor = System.Drawing.Color.White;
            this.patronymicTextbox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.patronymicTextbox.Location = new System.Drawing.Point(54, 329);
            this.patronymicTextbox.Multiline = true;
            this.patronymicTextbox.Name = "patronymicTextbox";
            this.patronymicTextbox.Size = new System.Drawing.Size(276, 35);
            this.patronymicTextbox.TabIndex = 11;
            this.patronymicTextbox.TextChanged += new System.EventHandler(this.patronymicTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label6.Location = new System.Drawing.Point(51, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отчество";
            // 
            // patronymicCheckBox
            // 
            this.patronymicCheckBox.AutoSize = true;
            this.patronymicCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patronymicCheckBox.FlatAppearance.BorderSize = 0;
            this.patronymicCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.patronymicCheckBox.Location = new System.Drawing.Point(52, 390);
            this.patronymicCheckBox.Name = "patronymicCheckBox";
            this.patronymicCheckBox.Size = new System.Drawing.Size(104, 21);
            this.patronymicCheckBox.TabIndex = 12;
            this.patronymicCheckBox.Text = "Нет отчества";
            this.patronymicCheckBox.UseVisualStyleBackColor = true;
            this.patronymicCheckBox.CheckedChanged += new System.EventHandler(this.patronymicCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label7.Location = new System.Drawing.Point(47, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Шаг 1 из 3";
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.nextButton.Location = new System.Drawing.Point(273, 496);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(82, 38);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // homepageButton
            // 
            this.homepageButton.BackgroundImage = global::GradeSystem.Properties.Resources.white_crossed1;
            this.homepageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homepageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.ForeColor = System.Drawing.Color.Gray;
            this.homepageButton.Location = new System.Drawing.Point(12, 23);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(15, 15);
            this.homepageButton.TabIndex = 16;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // logButton
            // 
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.FlatAppearance.BorderSize = 0;
            this.logButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.logButton.Location = new System.Drawing.Point(273, 9);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(82, 38);
            this.logButton.TabIndex = 18;
            this.logButton.Text = "Войти";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // errorLabelName
            // 
            this.errorLabelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabelName.ForeColor = System.Drawing.Color.Khaki;
            this.errorLabelName.Location = new System.Drawing.Point(51, 278);
            this.errorLabelName.Name = "errorLabelName";
            this.errorLabelName.Size = new System.Drawing.Size(275, 15);
            this.errorLabelName.TabIndex = 38;
            this.errorLabelName.Text = "Заполните поле";
            this.errorLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorLabelSurname
            // 
            this.errorLabelSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabelSurname.ForeColor = System.Drawing.Color.Khaki;
            this.errorLabelSurname.Location = new System.Drawing.Point(51, 195);
            this.errorLabelSurname.Name = "errorLabelSurname";
            this.errorLabelSurname.Size = new System.Drawing.Size(275, 15);
            this.errorLabelSurname.TabIndex = 39;
            this.errorLabelSurname.Text = "Заполните поле";
            this.errorLabelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorLabelPatronymic
            // 
            this.errorLabelPatronymic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabelPatronymic.ForeColor = System.Drawing.Color.Khaki;
            this.errorLabelPatronymic.Location = new System.Drawing.Point(54, 367);
            this.errorLabelPatronymic.Name = "errorLabelPatronymic";
            this.errorLabelPatronymic.Size = new System.Drawing.Size(275, 15);
            this.errorLabelPatronymic.TabIndex = 40;
            this.errorLabelPatronymic.Text = "Заполните поле";
            this.errorLabelPatronymic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 567);
            this.Controls.Add(this.errorLabelPatronymic);
            this.Controls.Add(this.errorLabelSurname);
            this.Controls.Add(this.errorLabelName);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.homepageButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.patronymicCheckBox);
            this.Controls.Add(this.patronymicTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patronymicTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox patronymicCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label errorLabelName;
        private System.Windows.Forms.Label errorLabelSurname;
        private System.Windows.Forms.Label errorLabelPatronymic;
    }
}

