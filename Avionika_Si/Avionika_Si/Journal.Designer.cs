namespace Oborot_SI
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            this.label6 = new System.Windows.Forms.Label();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.vid_raboti_Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zakluchenie_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numJour_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Заводской номер СИ";
            // 
            // zavod_Box
            // 
            this.zavod_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zavod_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(307, 228);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.Size = new System.Drawing.Size(332, 34);
            this.zavod_Box.TabIndex = 14;
            this.zavod_Box.Text = "0";
            // 
            // invent_Box
            // 
            this.invent_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invent_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(307, 166);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.Size = new System.Drawing.Size(332, 34);
            this.invent_Box.TabIndex = 13;
            this.invent_Box.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Инвентарный номер СИ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "ЖУРНАЛ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(307, 305);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(332, 22);
            this.dateTimePicker.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата работы";
            // 
            // vid_raboti_Box
            // 
            this.vid_raboti_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vid_raboti_Box.DisplayMember = "vid_rabot";
            this.vid_raboti_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_raboti_Box.FormattingEnabled = true;
            this.vid_raboti_Box.Location = new System.Drawing.Point(307, 365);
            this.vid_raboti_Box.Name = "vid_raboti_Box";
            this.vid_raboti_Box.Size = new System.Drawing.Size(332, 34);
            this.vid_raboti_Box.TabIndex = 19;
            this.vid_raboti_Box.ValueMember = "vid_rabot";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Вид работы";
            // 
            // zakluchenie_box
            // 
            this.zakluchenie_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zakluchenie_box.DisplayMember = "zakluchenie";
            this.zakluchenie_box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zakluchenie_box.FormattingEnabled = true;
            this.zakluchenie_box.Location = new System.Drawing.Point(307, 426);
            this.zakluchenie_box.Name = "zakluchenie_box";
            this.zakluchenie_box.Size = new System.Drawing.Size(332, 34);
            this.zakluchenie_box.TabIndex = 21;
            this.zakluchenie_box.ValueMember = "zakluchenie";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Заключение";
            // 
            // Back_Button
            // 
            this.Back_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(12, 504);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(181, 57);
            this.Back_Button.TabIndex = 25;
            this.Back_Button.Text = "НАЗАД";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(272, 504);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(219, 57);
            this.Add_Button.TabIndex = 26;
            this.Add_Button.Text = "ДОБАВИТЬ ЗАПИСЬ";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(574, 504);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(181, 57);
            this.Clear_button.TabIndex = 32;
            this.Clear_button.Text = "ОЧИСТИТЬ ПОЛЯ";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Номер в журнале";
            // 
            // numJour_Box
            // 
            this.numJour_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numJour_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numJour_Box.Location = new System.Drawing.Point(307, 104);
            this.numJour_Box.Name = "numJour_Box";
            this.numJour_Box.Size = new System.Drawing.Size(332, 34);
            this.numJour_Box.TabIndex = 34;
            this.numJour_Box.Text = "0";
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(767, 582);
            this.Controls.Add(this.numJour_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zakluchenie_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vid_raboti_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zavod_Box);
            this.Controls.Add(this.invent_Box);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Journal";
            this.Text = "Заполнение журнала";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vid_raboti_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox zakluchenie_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numJour_Box;
    }
}