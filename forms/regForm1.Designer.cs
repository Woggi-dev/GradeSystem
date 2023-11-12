
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Создайте единый личный кабинет для получения услуг и электронных сервисов Москвы\r" +
    "\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Личные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(49, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(52, 262);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(275, 35);
            this.nameTextbox.TabIndex = 7;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(52, 339);
            this.surnameTextbox.Multiline = true;
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(275, 35);
            this.surnameTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label5.Location = new System.Drawing.Point(49, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фамилия";
            // 
            // patronymicTextbox
            // 
            this.patronymicTextbox.Location = new System.Drawing.Point(53, 414);
            this.patronymicTextbox.Multiline = true;
            this.patronymicTextbox.Name = "patronymicTextbox";
            this.patronymicTextbox.Size = new System.Drawing.Size(275, 35);
            this.patronymicTextbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label6.Location = new System.Drawing.Point(50, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отчество";
            // 
            // patronymicCheckBox
            // 
            this.patronymicCheckBox.AutoSize = true;
            this.patronymicCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.patronymicCheckBox.Location = new System.Drawing.Point(52, 455);
            this.patronymicCheckBox.Name = "patronymicCheckBox";
            this.patronymicCheckBox.Size = new System.Drawing.Size(109, 21);
            this.patronymicCheckBox.TabIndex = 12;
            this.patronymicCheckBox.Text = "Нет отчества";
            this.patronymicCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.label7.Location = new System.Drawing.Point(47, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Шаг 1 из 3";
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.nextButton.Location = new System.Drawing.Point(273, 483);
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
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(136)))), ((int)(((byte)(222)))));
            this.logButton.Location = new System.Drawing.Point(273, 9);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(82, 38);
            this.logButton.TabIndex = 18;
            this.logButton.Text = "Войти";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // regForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 544);
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
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
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
    }
}

