namespace Oborot_SI
{
    partial class Grafic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafic));
            this.label6 = new System.Windows.Forms.Label();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.periodichnost_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.new_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.old_place_Box = new System.Windows.Forms.ComboBox();
            this.new_place_Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Заводской номер";
            // 
            // zavod_Box
            // 
            this.zavod_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zavod_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(335, 180);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.Size = new System.Drawing.Size(395, 34);
            this.zavod_Box.TabIndex = 43;
            this.zavod_Box.Text = "0";
            // 
            // invent_Box
            // 
            this.invent_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invent_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(335, 110);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.Size = new System.Drawing.Size(395, 34);
            this.invent_Box.TabIndex = 42;
            this.invent_Box.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "Инвентарный номер";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Периодичность (в мес.)";
            // 
            // periodichnost_Box
            // 
            this.periodichnost_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.periodichnost_Box.DisplayMember = "periodichnost";
            this.periodichnost_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodichnost_Box.FormattingEnabled = true;
            this.periodichnost_Box.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "36",
            "48",
            "6"});
            this.periodichnost_Box.Location = new System.Drawing.Point(335, 247);
            this.periodichnost_Box.Name = "periodichnost_Box";
            this.periodichnost_Box.Size = new System.Drawing.Size(395, 34);
            this.periodichnost_Box.TabIndex = 46;
            this.periodichnost_Box.ValueMember = "periodichnost";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "Место проведения";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Следующее место проведения";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 39);
            this.label4.TabIndex = 51;
            this.label4.Text = "ГРАФИК";
            // 
            // new_date
            // 
            this.new_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_date.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_date.Enabled = false;
            this.new_date.Location = new System.Drawing.Point(398, 559);
            this.new_date.Name = "new_date";
            this.new_date.Size = new System.Drawing.Size(332, 22);
            this.new_date.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(40, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 26);
            this.label7.TabIndex = 53;
            this.label7.Text = "Дата следующей работы с СИ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(40, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 26);
            this.label8.TabIndex = 54;
            // 
            // Clear_button
            // 
            this.Clear_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(700, 646);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(181, 57);
            this.Clear_button.TabIndex = 58;
            this.Clear_button.Text = "ОЧИСТИТЬ ПОЛЯ";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(398, 646);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(219, 57);
            this.Add_Button.TabIndex = 57;
            this.Add_Button.Text = "ДОБАВИТЬ ЗАПИСЬ";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(138, 646);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(181, 57);
            this.Back_Button.TabIndex = 56;
            this.Back_Button.Text = "НАЗАД";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(335, 313);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(99, 57);
            this.Search_Button.TabIndex = 59;
            this.Search_Button.Text = "ПОИСК";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(347, 728);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(320, 26);
            this.linkLabel1.TabIndex = 60;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Перейти к просмотру графиков";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // old_place_Box
            // 
            this.old_place_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.old_place_Box.DisplayMember = "periodichnost";
            this.old_place_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.old_place_Box.FormattingEnabled = true;
            this.old_place_Box.Location = new System.Drawing.Point(398, 419);
            this.old_place_Box.Name = "old_place_Box";
            this.old_place_Box.Size = new System.Drawing.Size(332, 34);
            this.old_place_Box.TabIndex = 61;
            this.old_place_Box.ValueMember = "periodichnost";
            this.old_place_Box.Visible = false;
            // 
            // new_place_Box
            // 
            this.new_place_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_place_Box.DisplayMember = "periodichnost";
            this.new_place_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_place_Box.FormattingEnabled = true;
            this.new_place_Box.Location = new System.Drawing.Point(398, 483);
            this.new_place_Box.Name = "new_place_Box";
            this.new_place_Box.Size = new System.Drawing.Size(332, 34);
            this.new_place_Box.TabIndex = 62;
            this.new_place_Box.ValueMember = "periodichnost";
            this.new_place_Box.Visible = false;
            // 
            // Grafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1017, 795);
            this.Controls.Add(this.new_place_Box);
            this.Controls.Add(this.old_place_Box);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.new_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodichnost_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zavod_Box);
            this.Controls.Add(this.invent_Box);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grafic";
            this.Text = "Заполнение графика СИ";
            this.Load += new System.EventHandler(this.Grafic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox periodichnost_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker new_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox old_place_Box;
        private System.Windows.Forms.ComboBox new_place_Box;
    }
}