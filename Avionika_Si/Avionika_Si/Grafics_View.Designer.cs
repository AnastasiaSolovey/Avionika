namespace Oborot_SI
{
    partial class Grafics_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafics_View));
            this.invent_Box = new System.Windows.Forms.TextBox();
            this.zavod_Box = new System.Windows.Forms.TextBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Graphic_GridView = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invent_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavod_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prinadlejnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakluch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invent_Box
            // 
            this.invent_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invent_Box.Location = new System.Drawing.Point(295, 114);
            this.invent_Box.Name = "invent_Box";
            this.invent_Box.Size = new System.Drawing.Size(332, 34);
            this.invent_Box.TabIndex = 50;
            this.invent_Box.Text = "0";
            // 
            // zavod_Box
            // 
            this.zavod_Box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavod_Box.Location = new System.Drawing.Point(295, 184);
            this.zavod_Box.Name = "zavod_Box";
            this.zavod_Box.Size = new System.Drawing.Size(332, 34);
            this.zavod_Box.TabIndex = 49;
            this.zavod_Box.Text = "0";
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.Location = new System.Drawing.Point(29, 788);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(181, 57);
            this.Back_Button.TabIndex = 47;
            this.Back_Button.Text = "НАЗАД";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(295, 247);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(205, 67);
            this.Add_Button.TabIndex = 46;
            this.Add_Button.Text = "ПРОСМОТРЕТЬ ДАННЫЕ";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Заводской номер";
            // 
            // Graphic_GridView
            // 
            this.Graphic_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Graphic_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.dataGridViewTextBoxColumn1,
            this.invent_nomer,
            this.zavod_nomer,
            this.prinadlejnost,
            this.Column3,
            this.Column1,
            this.Jh,
            this.Column4,
            this.Column5,
            this.Zakluch,
            this.Column2});
            this.Graphic_GridView.Location = new System.Drawing.Point(29, 352);
            this.Graphic_GridView.Name = "Graphic_GridView";
            this.Graphic_GridView.RowHeadersWidth = 51;
            this.Graphic_GridView.RowTemplate.Height = 24;
            this.Graphic_GridView.Size = new System.Drawing.Size(1063, 430);
            this.Graphic_GridView.TabIndex = 44;
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "Наименование";
            this.naimenovanie.MinimumWidth = 6;
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // invent_nomer
            // 
            this.invent_nomer.HeaderText = "Инвентарный номер";
            this.invent_nomer.MinimumWidth = 6;
            this.invent_nomer.Name = "invent_nomer";
            this.invent_nomer.Width = 125;
            // 
            // zavod_nomer
            // 
            this.zavod_nomer.HeaderText = "Заводской номер";
            this.zavod_nomer.MinimumWidth = 6;
            this.zavod_nomer.Name = "zavod_nomer";
            this.zavod_nomer.Width = 125;
            // 
            // prinadlejnost
            // 
            this.prinadlejnost.HeaderText = "Принадлежность";
            this.prinadlejnost.MinimumWidth = 6;
            this.prinadlejnost.Name = "prinadlejnost";
            this.prinadlejnost.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Периодичность";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Jh
            // 
            this.Jh.HeaderText = "Место проведения";
            this.Jh.MinimumWidth = 6;
            this.Jh.Name = "Jh";
            this.Jh.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата следующей работы";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Следующее место проведения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Zakluch
            // 
            this.Zakluch.HeaderText = "Заключение";
            this.Zakluch.MinimumWidth = 6;
            this.Zakluch.Name = "Zakluch";
            this.Zakluch.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вид работы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 39);
            this.label2.TabIndex = 48;
            this.label2.Text = "ВЫБЕРИТЕ УСТРОЙСТВО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, -41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "ПАСПОРТ";
            // 
            // Grafics_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1121, 868);
            this.Controls.Add(this.invent_Box);
            this.Controls.Add(this.zavod_Box);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Graphic_GridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grafics_View";
            this.Text = "Просмотр графика";
            this.Load += new System.EventHandler(this.Grafics_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox invent_Box;
        private System.Windows.Forms.TextBox zavod_Box;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Graphic_GridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invent_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavod_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn prinadlejnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zakluch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}