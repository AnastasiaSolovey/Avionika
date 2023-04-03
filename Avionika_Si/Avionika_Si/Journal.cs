using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using Avionika_Si;

namespace Oborot_SI
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Journal_Load(object sender, EventArgs e) //вывод на экран следующего номера в журнале
        {
           
            BD ConnDB1 = new BD();
            ConnDB1.openConnection();
            string request1 = "Select id_raboti from journals order by id_raboti DESC Limit 1";
            MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
            MySqlDataReader sqlData1 = Nado1.ExecuteReader();
            sqlData1.Read();
            if (sqlData1.HasRows)
            {
                Authorization.ID_SI = Convert.ToInt32(sqlData1[0].ToString());
                Authorization.ID_SI = Authorization.ID_SI + 1;
                numJour_Box.Text = Convert.ToString(Authorization.ID_SI);
            }


            DataTable zakluchenie = new DataTable();
            BD ConnDB2 = new BD();
            ConnDB2.openConnection();
            string request2 = "Select zakluchenie from zakluchenie Order by zakluchenie";
            MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
            ConnDB2.getConnection();
            MySqlDataAdapter sqlData2 = new MySqlDataAdapter(Nado2);
            sqlData2.Fill(zakluchenie);
            for (int i = 0; i < zakluchenie.Rows.Count; i++)
            {
                zakluchenie_box.Items.Add(zakluchenie.Rows[i]["zakluchenie"].ToString());

            }


            DataTable vid_rabot = new DataTable();
            BD ConnDB3 = new BD();
            ConnDB3.openConnection();
            string request3 = "Select vid_rabot from vid_rabot Order by vid_rabot";
            MySqlCommand Nado3 = new MySqlCommand(request3, ConnDB3.getConnection());
            ConnDB3.getConnection();
            MySqlDataAdapter sqlData3 = new MySqlDataAdapter(Nado3);
            sqlData3.Fill(vid_rabot);
            for (int i = 0; i < vid_rabot.Rows.Count; i++)
            {
                vid_raboti_Box.Items.Add(vid_rabot.Rows[i]["vid_rabot"].ToString());

            }


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            invent_Box.Text = "0";
            zavod_Box.Text = "0";
            dateTimePicker.Value = DateTime.Now;
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text) &&
                   !string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text))
            {
                if (dateTimePicker.Value > DateTime.Now)
                {
                    MessageBox.Show("Выберите другую дату работы");
                }
                else
                {

                    BD bb = new BD();
                    MySqlCommand Komand = new MySqlCommand("INSERT INTO journals VALUES (@id_raboti, @data, @id_si,@zakluchenie, @vid_rabot)", bb.getConnection());
                    Komand.Parameters.Add("@id_raboti", MySqlDbType.Int64).Value = numJour_Box.Text;
                    Komand.Parameters.Add("@data", MySqlDbType.Date).Value = dateTimePicker.Value.Date;
                    BD ConnDB1 = new BD();
                    ConnDB1.openConnection();
                    string request1 = "Select id_si from si_card where invent_nomer= '" + invent_Box.Text + "' and zavod_nomer='" + zavod_Box.Text + "'";
                    MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                    Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = zavod_Box.Text;
                    Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = invent_Box.Text;
                    MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                    sqlData1.Read();
                    if (sqlData1.HasRows)
                    {
                        Authorization.ID_SI = Convert.ToInt32(sqlData1[0].ToString()); 
                    }
                    else MessageBox.Show("Такого СИ нет в базе данных");
                    Komand.Parameters.Add("@id_si", MySqlDbType.Int64).Value = Authorization.ID_SI;
                    Komand.Parameters.Add("@zakluchenie", MySqlDbType.VarChar).Value = zakluchenie_box.Text;
                    Komand.Parameters.Add("@vid_rabot", MySqlDbType.VarChar).Value = vid_raboti_Box.Text;

                    bb.openConnection();
                    if (Komand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена");
                        BD ConnDB2 = new BD();
                        ConnDB2.openConnection();
                        string request2 = "Select id_raboti from journals order by id_raboti DESC LIMIT 1";
                        MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
                        MySqlDataReader sqlData2 = Nado2.ExecuteReader();
                        sqlData2.Read();
                        if (sqlData2.HasRows)
                        {
                            Authorization.ID_SI = Convert.ToInt32(sqlData2[0].ToString());
                            Authorization.ID_SI = Authorization.ID_SI + 1;
                            numJour_Box.Text = Convert.ToString(Authorization.ID_SI);
                        }
                    }
                    else MessageBox.Show("Запись не добавлена");
                    bb.CloseConnection();
                }
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }
    }
}
