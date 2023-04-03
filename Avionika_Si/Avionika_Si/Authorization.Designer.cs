namespace Oborot_SI
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.Authoriz_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Authoriz_Button
            // 
            this.Authoriz_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Authoriz_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authoriz_Button.Location = new System.Drawing.Point(315, 355);
            this.Authoriz_Button.Name = "Authoriz_Button";
            this.Authoriz_Button.Size = new System.Drawing.Size(202, 67);
            this.Authoriz_Button.TabIndex = 0;
            this.Authoriz_Button.Text = "ВХОД";
            this.Authoriz_Button.UseVisualStyleBackColor = true;
            this.Authoriz_Button.Click += new System.EventHandler(this.Authoriz_Button_Click);
            this.Authoriz_Button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Authoriz_Button_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // Login_Box
            // 
            this.Login_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Box.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Box.Location = new System.Drawing.Point(182, 172);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(524, 39);
            this.Login_Box.TabIndex = 4;
            // 
            // Password_Box
            // 
            this.Password_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_Box.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_Box.Location = new System.Drawing.Point(182, 280);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.Size = new System.Drawing.Size(524, 39);
            this.Password_Box.TabIndex = 5;
            this.Password_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_Box_KeyPress);
            // 
            // Error_label
            // 
            this.Error_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Error_label.AutoSize = true;
            this.Error_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.ForeColor = System.Drawing.Color.Red;
            this.Error_label.Location = new System.Drawing.Point(388, 441);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(48, 21);
            this.Error_label.TabIndex = 6;
            this.Error_label.Text = "Error";
            this.Error_label.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Login_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Authoriz_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authoriz_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label Error_label;
    }
}

