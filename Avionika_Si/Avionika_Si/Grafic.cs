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
using MySql.Data.MySqlClient;
using Avionika_Si;

namespace Oborot_SI
{
    public partial class Grafic : Form
    {
        public Grafic()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Grafic_Load(object sender, EventArgs e)
        {

            DataTable old = new DataTable();
            BD ConnDB2 = new BD();
            ConnDB2.openConnection();
            string request2 = "Select mesto_provedenia from mesto_provedenia Order by mesto_provedenia";
            MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
            ConnDB2.getConnection();
            MySqlDataAdapter sqlData2 = new MySqlDataAdapter(Nado2);
            sqlData2.Fill(old);
            for (int i = 0; i < old.Rows.Count; i++)
            {
                old_place_Box.Items.Add(old.Rows[i]["mesto_provedenia"].ToString());

            }


            DataTable neew = new DataTable();
            BD ConnDB3 = new BD();
            ConnDB3.openConnection();
            string request3 = "Select mesto_provedenia from mesto_provedenia Order by mesto_provedenia";
            MySqlCommand Nado3 = new MySqlCommand(request3, ConnDB3.getConnection());
            ConnDB3.getConnection();
            MySqlDataAdapter sqlData3 = new MySqlDataAdapter(Nado3);
            sqlData3.Fill(neew);
            for (int i = 0; i < neew.Rows.Count; i++)
            {
                new_place_Box.Items.Add(neew.Rows[i]["mesto_provedenia"].ToString());

            }

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text) &&
  !string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text))

            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select data from journals join si_card on journals.id_si=si_card.id_si where zavod_nomer='" + zavod_Box.Text + "' and invent_nomer= '" + invent_Box.Text + "' order by data DESC LIMIT 1";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    var newdata = DateTime.Parse(sqlDataReader[0].ToString());
                    if (!string.IsNullOrEmpty(periodichnost_Box.Text) && !string.IsNullOrWhiteSpace(periodichnost_Box.Text))
                    {
                        Authorization.periodichnost = Convert.ToInt32(periodichnost_Box.Text);
                        newdata= newdata.AddMonths(Authorization.periodichnost);
                        newdata = newdata.AddDays(-1);
                        new_date.Text = newdata.ToString();
                        old_place_Box.Visible = true;
                        new_place_Box.Visible = true;
                    }
                    
                }

                else

                    MessageBox.Show("Такого средства измерения нет. Проверьте, есть ли запись о данном СИ в журнале", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();
            }


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text) &&
                  !string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text)
                  &&
                  !string.IsNullOrEmpty(old_place_Box.Text) && !string.IsNullOrWhiteSpace(old_place_Box.Text)
                   &&
                  !string.IsNullOrEmpty(new_place_Box.Text) && !string.IsNullOrWhiteSpace(new_place_Box.Text))
            {


                BD bb = new BD();
                MySqlCommand Komand = new MySqlCommand("INSERT INTO graphic VALUES (0, @id_si, @periodichnost, (SELECT mesto_provedenia_id FROM mesto_provedenia where mesto_provedenia=@mesto_proved_old), @data, (SELECT mesto_provedenia_id FROM mesto_provedenia where mesto_provedenia=@mest_proved_new))", bb.getConnection());
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
                Komand.Parameters.Add("@periodichnost", MySqlDbType.VarChar).Value = periodichnost_Box.Text;
                Komand.Parameters.Add("@mesto_proved_old", MySqlDbType.VarChar).Value = old_place_Box.Text;
                Komand.Parameters.Add("@data", MySqlDbType.Date).Value = new_date.Value.Date;
                Komand.Parameters.Add("@mest_proved_new", MySqlDbType.VarChar).Value = new_place_Box.Text;
                bb.openConnection();
                if (Komand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");

                }
                else MessageBox.Show("Запись не добавлена");
                bb.CloseConnection();
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            invent_Box.Text = "0";
            zavod_Box.Text = "0";
            new_date.Value = DateTime.Now;
            new_place_Box.Items.Clear();
            old_place_Box.Items.Clear();

            old_place_Box.Visible = false;
            new_place_Box.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Не забудьте сохранить данные. Вы хотите перейти к просмотру графика?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Grafics_View F = new Grafics_View();
                F.Show();
            }
        }
    }
}
