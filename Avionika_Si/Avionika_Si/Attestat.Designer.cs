namespace Oborot_SI
{
    partial class Attestat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attestat));
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.prinadl_Box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.new_date = new System.Windows.Forms.DateTimePicker();
            this.sotrudnik_Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.naimen_Box = new System.Windows.Forms.ComboBox();
            this.protocol_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(311, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "АТТЕСТАТ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(656, 84);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(99, 46);
            this.Search_Button.TabIndex = 46;
            this.Search_Button.Text = "ПОИСК";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Заводской номер";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // zavod_Box
            // 
            this.zavod_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zavod_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(289, 220);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.ReadOnly = true;
            this.zavod_Box.Size = new System.Drawing.Size(332, 34);
            this.zavod_Box.TabIndex = 44;
            this.zavod_Box.Text = "0";
            this.zavod_Box.TextChanged += new System.EventHandler(this.zavod_Box_TextChanged);
            // 
            // invent_Box
            // 
            this.invent_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invent_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(289, 155);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.ReadOnly = true;
            this.invent_Box.Size = new System.Drawing.Size(332, 34);
            this.invent_Box.TabIndex = 43;
            this.invent_Box.Text = "0";
            this.invent_Box.TextChanged += new System.EventHandler(this.invent_Box_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Инвентарный номер";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Дата работы";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(289, 420);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(332, 22);
            this.dateTimePicker.TabIndex = 47;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 26);
            this.label8.TabIndex = 50;
            this.label8.Text = "Принадлежность";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // prinadl_Box
            // 
            this.prinadl_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prinadl_Box.DisplayMember = "prinadlejnost";
            this.prinadl_Box.Enabled = false;
            this.prinadl_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prinadl_Box.FormattingEnabled = true;
            this.prinadl_Box.Location = new System.Drawing.Point(289, 343);
            this.prinadl_Box.Name = "prinadl_Box";
            this.prinadl_Box.Size = new System.Drawing.Size(332, 34);
            this.prinadl_Box.TabIndex = 49;
            this.prinadl_Box.ValueMember = "prinadlejnost";
            this.prinadl_Box.SelectedIndexChanged += new System.EventHandler(this.prinadl_Box_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 26);
            this.label7.TabIndex = 55;
            this.label7.Text = "Действителен до";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // new_date
            // 
            this.new_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_date.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_date.Enabled = false;
            this.new_date.Location = new System.Drawing.Point(289, 481);
            this.new_date.Name = "new_date";
            this.new_date.Size = new System.Drawing.Size(332, 22);
            this.new_date.TabIndex = 54;
            this.new_date.ValueChanged += new System.EventHandler(this.new_date_ValueChanged);
            // 
            // sotrudnik_Box
            // 
            this.sotrudnik_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sotrudnik_Box.DisplayMember = "surname";
            this.sotrudnik_Box.Enabled = false;
            this.sotrudnik_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sotrudnik_Box.FormattingEnabled = true;
            this.sotrudnik_Box.Location = new System.Drawing.Point(289, 541);
            this.sotrudnik_Box.Name = "sotrudnik_Box";
            this.sotrudnik_Box.Size = new System.Drawing.Size(332, 34);
            this.sotrudnik_Box.TabIndex = 57;
            this.sotrudnik_Box.ValueMember = "id_sotrudnik";
            this.sotrudnik_Box.SelectedIndexChanged += new System.EventHandler(this.sotrudnik_Box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ответственный";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Create_Button
            // 
            this.Create_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_Button.Location = new System.Drawing.Point(311, 608);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(252, 57);
            this.Create_Button.TabIndex = 58;
            this.Create_Button.Text = "СОЗДАТЬ АТТЕСТАТ";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(30, 608);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(174, 57);
            this.Back_Button.TabIndex = 59;
            this.Back_Button.Text = "НАЗАД";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Наименование СИ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // naimen_Box
            // 
            this.naimen_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naimen_Box.DisplayMember = "naimenovanie";
            this.naimen_Box.Enabled = false;
            this.naimen_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naimen_Box.FormattingEnabled = true;
            this.naimen_Box.Location = new System.Drawing.Point(289, 281);
            this.naimen_Box.Name = "naimen_Box";
            this.naimen_Box.Size = new System.Drawing.Size(332, 34);
            this.naimen_Box.TabIndex = 60;
            this.naimen_Box.ValueMember = "naimenovanie";
            this.naimen_Box.SelectedIndexChanged += new System.EventHandler(this.naimen_Box_SelectedIndexChanged);
            // 
            // protocol_num
            // 
            this.protocol_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.protocol_num.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocol_num.Location = new System.Drawing.Point(289, 90);
            this.protocol_num.Name = "protocol_num";
            this.protocol_num.Size = new System.Drawing.Size(332, 34);
            this.protocol_num.TabIndex = 63;
            this.protocol_num.TextChanged += new System.EventHandler(this.protocol_num_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 26);
            this.label9.TabIndex = 62;
            this.label9.Text = "№Протокола";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Attestat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.protocol_num);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.naimen_Box);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.sotrudnik_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.new_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prinadl_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zavod_Box);
            this.Controls.Add(this.invent_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attestat";
            this.Text = "Создание аттестата";
            this.Load += new System.EventHandler(this.Attestat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox prinadl_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker new_date;
        private System.Windows.Forms.ComboBox sotrudnik_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox naimen_Box;
        private System.Windows.Forms.TextBox protocol_num;
        private System.Windows.Forms.Label label9;
    }
}