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
using Avionika_Si;
using MySql.Data.MySqlClient;


namespace Oborot_SI
{
    public partial class Card_si : Form
    {
        public Card_si()
        {
            InitializeComponent();
            LoadDate();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        public static int isEtalon = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isEtalon = 1;
        }

        private void LoadDate()
        {
            BD ConnDB = new BD();
            ConnDB.openConnection();
            string request = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
            MySqlCommand Reader = new MySqlCommand(request, ConnDB.getConnection());
            MySqlDataReader reader = Reader.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[12]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();


            }
            reader.Close();
            ConnDB.CloseConnection();
            foreach (string[] s in data)
                SI_GridView.Rows.Add(s);

        }
        private void Card_si_Load(object sender, EventArgs e)
        {
            DataTable Naimen = new DataTable();
            BD ConnDB1 = new BD();
            ConnDB1.openConnection();
            string request1 = "Select naimenovanie from naimenovanie_si Order by naimenovanie";
            MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
            ConnDB1.getConnection();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(Nado1);
            sqlData.Fill(Naimen);
            for (int i = 0; i < Naimen.Rows.Count; i++)
            {
                naimen_Box.Items.Add(Naimen.Rows[i]["naimenovanie"].ToString());

            }

            DataTable Sostoyanie = new DataTable();
            BD ConnDB2 = new BD();
            ConnDB2.openConnection();
            string request2 = "Select sostoyanie from sostoyanie Order by sostoyanie";
            MySqlCommand Nado2 = new MySqlCommand(request2, ConnDB2.getConnection());
            ConnDB2.getConnection();
            MySqlDataAdapter sqlData2 = new MySqlDataAdapter(Nado2);
            sqlData2.Fill(Sostoyanie);
            for (int i = 0; i < Sostoyanie.Rows.Count; i++)
            {
                sostoyanie_Box.Items.Add(Sostoyanie.Rows[i]["sostoyanie"].ToString());

            }


            DataTable Prinadl = new DataTable();
            BD ConnDB3 = new BD();
            ConnDB3.openConnection();
            string request3 = "Select prinadlejnost from prinadlejnost Order by prinadlejnost";
            MySqlCommand Nado3 = new MySqlCommand(request3, ConnDB3.getConnection());
            ConnDB3.getConnection();
            MySqlDataAdapter sqlData3 = new MySqlDataAdapter(Nado3);
            sqlData3.Fill(Prinadl);
            for (int i = 0; i < Prinadl.Rows.Count; i++)
            {
                prinadl_Box.Items.Add(Prinadl.Rows[i]["prinadlejnost"].ToString());

            }


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
  
                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(naimen_Box.Text) && !string.IsNullOrWhiteSpace(naimen_Box.Text) &&
!string.IsNullOrEmpty(Tip_Box.Text) && !string.IsNullOrWhiteSpace(Tip_Box.Text)
&&
!string.IsNullOrEmpty(firma_Box.Text) && !string.IsNullOrWhiteSpace(firma_Box.Text)
&&
!string.IsNullOrEmpty(Diapazon_Box.Text) && !string.IsNullOrWhiteSpace(Diapazon_Box.Text)
&&
!string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text)
&&
!string.IsNullOrEmpty(sostoyanie_Box.Text) && !string.IsNullOrWhiteSpace(sostoyanie_Box.Text)
&&
!string.IsNullOrEmpty(complect_Box.Text) && !string.IsNullOrWhiteSpace(complect_Box.Text)
&&
!string.IsNullOrEmpty(Opisanie_Box.Text) && !string.IsNullOrWhiteSpace(Opisanie_Box.Text)
&&
!string.IsNullOrEmpty(prinadl_Box.Text) && !string.IsNullOrWhiteSpace(prinadl_Box.Text))

            {

                BD ConnDB = new BD();
                using (MySqlCommand Komand = new MySqlCommand("INSERT INTO si_card VALUES (0, @naimenovanie, @tip,@firma,@diapazon,@invent_nomer,@zavod_nomer,@etalon,@sostoyanie,@komplectacia,@opisanie,@prinadlejnost)", ConnDB.getConnection()))
                {

                    Komand.Parameters.Add("@naimenovanie", MySqlDbType.VarChar).Value = naimen_Box.Text;
                    Komand.Parameters.Add("@tip", MySqlDbType.VarChar).Value = Tip_Box.Text;
                    Komand.Parameters.Add("@firma", MySqlDbType.VarChar).Value = firma_Box.Text;
                    Komand.Parameters.Add("@diapazon", MySqlDbType.VarChar).Value = Diapazon_Box.Text;
                    Komand.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = invent_Box.Text;
                    Komand.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = zavod_Box.Text;
                    Komand.Parameters.Add("@etalon", MySqlDbType.Bit).Value = isEtalon;
                    Komand.Parameters.Add("@sostoyanie", MySqlDbType.VarChar).Value = sostoyanie_Box.Text;
                    Komand.Parameters.Add("@komplectacia", MySqlDbType.Text).Value = complect_Box.Text;
                    Komand.Parameters.Add("@opisanie", MySqlDbType.Text).Value = Opisanie_Box.Text;
                    Komand.Parameters.Add("@prinadlejnost", MySqlDbType.VarChar).Value = prinadl_Box.Text;

                    ConnDB.openConnection();

                    Komand.ExecuteNonQuery();
                    MessageBox.Show("Средство измерения было добавлено в Базу данных");
                    try
                    {
                        SI_GridView.Rows.Clear();
                        BD ConnDB1 = new BD();
                        ConnDB1.openConnection();
                        string request1 = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
                        MySqlCommand Reader = new MySqlCommand(request1, ConnDB1.getConnection());
                        MySqlDataReader reader = Reader.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (reader.Read())
                        {
                            data.Add(new string[12]);
                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                            data[data.Count - 1][2] = reader[2].ToString();
                            data[data.Count - 1][3] = reader[3].ToString();
                            data[data.Count - 1][4] = reader[4].ToString();
                            data[data.Count - 1][5] = reader[5].ToString();
                            data[data.Count - 1][6] = reader[6].ToString();
                            data[data.Count - 1][7] = reader[7].ToString();
                            data[data.Count - 1][8] = reader[8].ToString();
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();


                        }
                        reader.Close();
                        ConnDB1.CloseConnection();
                        foreach (string[] s in data)
                            SI_GridView.Rows.Add(s);
                    }
                    catch (MySqlException isq)
                    {
                        MessageBox.Show(isq.Message);
                    }


                }
                ConnDB.CloseConnection();
            }
            else
                MessageBox.Show("Все обязательные поля должны быть заполнены!");

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            BD ConnDB = new BD();
            MySqlCommand Izmenenie = new MySqlCommand("UPDATE si_card SET naimenovanie=@naimenovanie, tip=@tip,firma=@firma,diapazon=@diapazon,invent_nomer=@invent_nomer,zavod_nomer=@zavod_nomer,etalon=@etalon,sostoyanie=@sostoyanie,komplectacia=@komplectacia,opisanie=@opisanie,prinadlejnost=@prinadlejnost Where invent_nomer=@invent_nomer and zavod_nomer=@zavod_nomer", ConnDB.getConnection());
            Izmenenie.Parameters.Add("@naimenovanie", MySqlDbType.VarChar).Value = naimen_Box.Text;
            Izmenenie.Parameters.Add("@tip", MySqlDbType.VarChar).Value = Tip_Box.Text;
            Izmenenie.Parameters.Add("@firma", MySqlDbType.VarChar).Value = firma_Box.Text;
            Izmenenie.Parameters.Add("@diapazon", MySqlDbType.VarChar).Value = Diapazon_Box.Text;
            Izmenenie.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = invent_Box.Text;
            Izmenenie.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = zavod_Box.Text;
            Izmenenie.Parameters.Add("@etalon", MySqlDbType.Bit).Value = isEtalon;
            Izmenenie.Parameters.Add("@sostoyanie", MySqlDbType.VarChar).Value = sostoyanie_Box.Text;
            Izmenenie.Parameters.Add("@komplectacia", MySqlDbType.Text).Value = complect_Box.Text;
            Izmenenie.Parameters.Add("@opisanie", MySqlDbType.Text).Value = Opisanie_Box.Text;
            Izmenenie.Parameters.Add("@prinadlejnost", MySqlDbType.VarChar).Value = prinadl_Box.Text;

            ConnDB.openConnection();

            if (Izmenenie.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения сохранены");
                try
                {
                    SI_GridView.Rows.Clear();
                    BD ConnDB1 = new BD();
                    ConnDB1.openConnection();
                    string request1 = "Select id_si, naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer,etalon,sostoyanie,komplectacia,opisanie,prinadlejnost From si_card Order By naimenovanie";
                    MySqlCommand Reader = new MySqlCommand(request1, ConnDB1.getConnection());
                    MySqlDataReader reader = Reader.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[12]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                        data[data.Count - 1][8] = reader[8].ToString();
                        data[data.Count - 1][9] = reader[9].ToString();
                        data[data.Count - 1][10] = reader[10].ToString();
                        data[data.Count - 1][11] = reader[11].ToString();


                    }
                    reader.Close();
                    ConnDB1.CloseConnection();
                    foreach (string[] s in data)
                        SI_GridView.Rows.Add(s);
                }
                catch (MySqlException isq)
                {
                    MessageBox.Show(isq.Message);
                }

            }
            else MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConnDB.CloseConnection();


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(Search_Button, "Введите заводской и/или инвентарный номер чтобы найти прибор");
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zavod_Box.Text) && !string.IsNullOrWhiteSpace(zavod_Box.Text) &&
   !string.IsNullOrEmpty(invent_Box.Text) && !string.IsNullOrWhiteSpace(invent_Box.Text))

            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select naimenovanie, tip, firma, diapazon, invent_nomer, zavod_nomer, sostoyanie,komplectacia,opisanie,prinadlejnost From si_card where zavod_nomer='" + zavod_Box.Text + "' and invent_nomer= '" + invent_Box.Text + "'";
                MySqlCommand Poisk = new MySqlCommand(request, ConnDB.getConnection());
                MySqlDataReader sqlDataReader = Poisk.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    naimen_Box.Text = sqlDataReader[0].ToString();
                    Tip_Box.Text = sqlDataReader[1].ToString();
                    firma_Box.Text = sqlDataReader[2].ToString();
                    Diapazon_Box.Text = sqlDataReader[3].ToString();
                    invent_Box.Text = sqlDataReader[4].ToString();
                    zavod_Box.Text = sqlDataReader[5].ToString();
                    BD ConnDB1 = new BD();
                    ConnDB1.openConnection();
                    string request1 = "Select si_card.etalon from si_card where zavod_nomer=@zavod_nomer and invent_nomer=@invent_nomer";
                    MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                    Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = zavod_Box.Text;
                    Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = invent_Box.Text;
                    MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                    sqlData1.Read();
                    if (sqlData1.HasRows)
                    {

                        if (sqlData1[0].ToString() == "True")
                        {
                            yes_Button.Checked = true;
                        }
                        else yes_Button.Checked = false;
                    }
                    sostoyanie_Box.Text = sqlDataReader[6].ToString();
                    complect_Box.Text = sqlDataReader[7].ToString();
                    Opisanie_Box.Text = sqlDataReader[8].ToString();
                    prinadl_Box.Text = sqlDataReader[9].ToString();

                }

                else

                    MessageBox.Show("Такого средства измерения нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnDB.CloseConnection();

            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Tip_Box.Clear();
            firma_Box.Clear();
            Diapazon_Box.Clear();
            invent_Box.Text = "0";
            zavod_Box.Text = "0";
            yes_Button.Checked = false;
            complect_Box.Clear();
            Opisanie_Box.Clear();

        }
    }
}
