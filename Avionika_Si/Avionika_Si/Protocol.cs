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
    public partial class Protocol : Form
    {
        public Protocol()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text) &&
  !string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text))

            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select id_raboti from journals join si_card on journals.id_si=si_card.id_si where zavod_nomer='" + zavod_Box.Text + "' and invent_nomer= '" + invent_Box.Text + "' Order by id_raboti DESC";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    numProtocol_Box.Text = sqlDataReader[0].ToString();

                }

                else

                    MessageBox.Show("Такого средства измерения нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();
            }
        }

        private void Protocol_Load(object sender, EventArgs e)
        {
            DataTable sotrudnik = new DataTable();
            BD ConnDB2 = new BD();
            ConnDB2.openConnection();
            string request2 = "Select surname, name, patronymic from sotrudnik Order by surname";
            MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
            ConnDB2.getConnection();
            MySqlDataAdapter sqlData2 = new MySqlDataAdapter(Nado2);
            sqlData2.Fill(sotrudnik);
            for (int i = 0; i < sotrudnik.Rows.Count; i++)
            {
                sotrudnik_Box.Items.Add(sotrudnik.Rows[i]["surname"].ToString() +" "+ sotrudnik.Rows[i]["name"].ToString() + " " + sotrudnik.Rows[i]["patronymic"].ToString());

            }

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text) &&
                   !string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text)
                   &&
                   !string.IsNullOrEmpty(numProtocol_Box.Text) && !string.IsNullOrWhiteSpace(numProtocol_Box.Text))
            {
               

                    BD bb = new BD();
                MySqlCommand Komand = new MySqlCommand("INSERT INTO protocol VALUES (@id_protocol, @id_si, @primechanie, (Select sotrudnik.id_sotrudnik from sotrudnik where CONCAT(surname, ' ',name, ' ',  patronymic) = @id_sotrudnik))", bb.getConnection());
                    Komand.Parameters.Add("@id_protocol", MySqlDbType.Int64).Value = numProtocol_Box.Text;
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
                    Komand.Parameters.Add("@primechanie", MySqlDbType.VarChar).Value = Primechanie_Box.Text;
                    Komand.Parameters.Add("@id_sotrudnik", MySqlDbType.VarChar).Value = sotrudnik_Box.Text;

                    bb.openConnection();
                try 
                {
                    if (Komand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена");

                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Запись не добавлена. В базу данных уже внесены данные об этом устройстве", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bb.CloseConnection();
                }
                    
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            invent_Box.Text = "0";
            zavod_Box.Text = "0";
            numProtocol_Box.Text = "0";
            Primechanie_Box.Clear();
        }
    }
}