namespace Oborot_SI
{
    partial class Card_si
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card_si));
            this.naimen_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tip_Box = new System.Windows.Forms.TextBox();
            this.Diapazon_Box = new System.Windows.Forms.TextBox();
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yes_Button = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prinadl_Box = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Opisanie_Box = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.complect_Box = new System.Windows.Forms.RichTextBox();
            this.SI_GridView = new System.Windows.Forms.DataGridView();
            this.id_si = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diapazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostoyanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komplectacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.firma_Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sostoyanie_Box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SI_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // naimen_Box
            // 
            this.naimen_Box.DisplayMember = "naimenovanie";
            this.naimen_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.naimen_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naimen_Box.FormattingEnabled = true;
            this.naimen_Box.Location = new System.Drawing.Point(270, 90);
            this.naimen_Box.Name = "naimen_Box";
            this.naimen_Box.Size = new System.Drawing.Size(332, 34);
            this.naimen_Box.TabIndex = 0;
            this.naimen_Box.ValueMember = "naimenovanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "СРЕДСТВА ИЗМЕРЕНИЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование СИ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Диапазон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Инвентарный номер";
            // 
            // Tip_Box
            // 
            this.Tip_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tip_Box.Location = new System.Drawing.Point(270, 155);
            this.Tip_Box.Name = "Tip_Box";
            this.Tip_Box.Size = new System.Drawing.Size(332, 34);
            this.Tip_Box.TabIndex = 7;
            // 
            // Diapazon_Box
            // 
            this.Diapazon_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diapazon_Box.Location = new System.Drawing.Point(270, 285);
            this.Diapazon_Box.Name = "Diapazon_Box";
            this.Diapazon_Box.Size = new System.Drawing.Size(332, 34);
            this.Diapazon_Box.TabIndex = 8;
            // 
            // invent_Box
            // 
            this.invent_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(270, 349);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.Size = new System.Drawing.Size(332, 34);
            this.invent_Box.TabIndex = 9;
            this.invent_Box.Text = "0";
            // 
            // zavod_Box
            // 
            this.zavod_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(270, 409);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.Size = new System.Drawing.Size(332, 34);
            this.zavod_Box.TabIndex = 10;
            this.zavod_Box.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Заводской номер";
            // 
            // yes_Button
            // 
            this.yes_Button.AutoSize = true;
            this.yes_Button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes_Button.Location = new System.Drawing.Point(270, 478);
            this.yes_Button.Name = "yes_Button";
            this.yes_Button.Size = new System.Drawing.Size(59, 30);
            this.yes_Button.TabIndex = 12;
            this.yes_Button.TabStop = true;
            this.yes_Button.Text = "Да";
            this.yes_Button.UseVisualStyleBackColor = true;
            this.yes_Button.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Эталон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 782);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Принадлежность";
            // 
            // prinadl_Box
            // 
            this.prinadl_Box.DisplayMember = "prinadlejnost";
            this.prinadl_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prinadl_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prinadl_Box.FormattingEnabled = true;
            this.prinadl_Box.Location = new System.Drawing.Point(270, 774);
            this.prinadl_Box.Name = "prinadl_Box";
            this.prinadl_Box.Size = new System.Drawing.Size(332, 34);
            this.prinadl_Box.TabIndex = 15;
            this.prinadl_Box.ValueMember = "prinadlejnost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Комплектация";
            // 
            // Opisanie_Box
            // 
            this.Opisanie_Box.Location = new System.Drawing.Point(270, 688);
            this.Opisanie_Box.Name = "Opisanie_Box";
            this.Opisanie_Box.Size = new System.Drawing.Size(608, 57);
            this.Opisanie_Box.TabIndex = 19;
            this.Opisanie_Box.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 702);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Описание";
            // 
            // complect_Box
            // 
            this.complect_Box.Location = new System.Drawing.Point(270, 605);
            this.complect_Box.Name = "complect_Box";
            this.complect_Box.Size = new System.Drawing.Size(608, 57);
            this.complect_Box.TabIndex = 21;
            this.complect_Box.Text = "";
            // 
            // SI_GridView
            // 
            this.SI_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SI_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SI_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SI_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_si,
            this.naimenovanie,
            this.tip,
            this.firma,
            this.Diapazon,
            this.invent_nomer,
            this.zavod_nomer,
            this.etalon,
            this.sostoyanie,
            this.komplectacia,
            this.opisanie,
            this.prinadlejnost});
            this.SI_GridView.Location = new System.Drawing.Point(786, 99);
            this.SI_GridView.Name = "SI_GridView";
            this.SI_GridView.RowHeadersWidth = 51;
            this.SI_GridView.RowTemplate.Height = 24;
            this.SI_GridView.Size = new System.Drawing.Size(946, 409);
            this.SI_GridView.TabIndex = 22;
            this.SI_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_si
            // 
            this.id_si.HeaderText = "ID СИ";
            this.id_si.MinimumWidth = 6;
            this.id_si.Name = "id_si";
            this.id_si.Width = 66;
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.Width = 135;
            // 
            // tip
            // 
            this.tip.HeaderText = "Тип";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.Width = 61;
            // 
            // firma
            // 
            this.firma.HeaderText = "Фирма";
            this.firma.MinimumWidth = 6;
            this.firma.Name = "firma";
            this.firma.Width = 80;
            // 
            // Diapazon
            // 
            this.Diapazon.HeaderText = "Диапазон";
            this.Diapazon.MinimumWidth = 6;
            this.Diapazon.Name = "Diapazon";
            this.Diapazon.Width = 101;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.Width = 155;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.Width = 138;
            // 
            // etalon
            // 
            this.etalon.HeaderText = "Эталон";
            this.etalon.MinimumWidth = 6;
            this.etalon.Name = "etalon";
            this.etalon.Width = 85;
            // 
            // sostoyanie
            // 
            this.sostoyanie.HeaderText = "Состояние";
            this.sostoyanie.MinimumWidth = 6;
            this.sostoyanie.Name = "sostoyanie";
            this.sostoyanie.Width = 106;
            // 
            // komplectacia
            // 
            this.komplectacia.HeaderText = "Комплектация";
            this.komplectacia.MinimumWidth = 6;
            this.komplectacia.Name = "komplectacia";
            this.komplectacia.Width = 130;
            // 
            // opisanie
            // 
            this.opisanie.HeaderText = "Описание";
            this.opisanie.MinimumWidth = 6;
            this.opisanie.Name = "opisanie";
            this.opisanie.Width = 101;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.Width = 148;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(270, 835);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(219, 57);
            this.Add_Button.TabIndex = 23;
            this.Add_Button.Text = "ДОБАВИТЬ НОВОЕ СИ";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(21, 835);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(181, 57);
            this.Back_Button.TabIndex = 24;
            this.Back_Button.Text = "НАЗАД";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // firma_Box
            // 
            this.firma_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firma_Box.Location = new System.Drawing.Point(270, 223);
            this.firma_Box.Name = "firma_Box";
            this.firma_Box.Size = new System.Drawing.Size(332, 34);
            this.firma_Box.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(18, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Фирма";
            // 
            // sostoyanie_Box
            // 
            this.sostoyanie_Box.DisplayMember = "sostoyanie";
            this.sostoyanie_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sostoyanie_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sostoyanie_Box.FormattingEnabled = true;
            this.sostoyanie_Box.Location = new System.Drawing.Point(270, 542);
            this.sostoyanie_Box.Name = "sostoyanie_Box";
            this.sostoyanie_Box.Size = new System.Drawing.Size(332, 34);
            this.sostoyanie_Box.TabIndex = 27;
            this.sostoyanie_Box.ValueMember = "sostoyanie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(18, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 26);
            this.label12.TabIndex = 28;
            this.label12.Text = "Состояние";
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Button.Location = new System.Drawing.Point(534, 835);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(219, 57);
            this.Update_Button.TabIndex = 29;
            this.Update_Button.Text = "ОБНОВИТЬ ДАННЫЕ СИ";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.Location = new System.Drawing.Point(608, 366);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(99, 57);
            this.Search_Button.TabIndex = 30;
            this.Search_Button.Text = "ПОИСК";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(813, 835);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(181, 57);
            this.Clear_button.TabIndex = 31;
            this.Clear_button.Text = "ОЧИСТИТЬ ПОЛЯ";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Card_si
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1654, 914);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sostoyanie_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.firma_Box);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.SI_GridView);
            this.Controls.Add(this.complect_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Opisanie_Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prinadl_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yes_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zavod_Box);
            this.Controls.Add(this.invent_Box);
            this.Controls.Add(this.Diapazon_Box);
            this.Controls.Add(this.Tip_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naimen_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Card_si";
            this.Text = "Средства измерения";
            this.Load += new System.EventHandler(this.Card_si_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SI_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox naimen_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tip_Box;
        private System.Windows.Forms.TextBox Diapazon_Box;
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton yes_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox prinadl_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Opisanie_Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox complect_Box;
        private System.Windows.Forms.DataGridView SI_GridView;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_si;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diapazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn etalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostoyanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn komplectacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.TextBox firma_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sostoyanie_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Clear_button;
    }
}