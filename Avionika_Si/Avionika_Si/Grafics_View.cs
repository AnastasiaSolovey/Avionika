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
    public partial class Grafics_View : Form
    {
        public Grafics_View()
        {
            InitializeComponent();
            LoadDate();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        private void LoadDate()
        {
            BD ConnDB = new BD();
            ConnDB.openConnection();
            string request = "Select naimenovanie, tip, invent_nomer, zavod_nomer, prinadlejnost, periodichnost, journals.data,(Select mesto_provedenia from mesto_provedenia where mesto_provedenia_id = mesto_proved_old), graphic.data, (Select mesto_provedenia from mesto_provedenia where mesto_provedenia_id = mesto_proved_new),  zakluchenie, vid_rabot From si_card join journals on si_card.id_si=journals.id_si join graphic on si_card.id_si=graphic.id_si join mesto_provedenia on mesto_provedenia.mesto_provedenia_id = graphic.mesto_proved_new where graphic.data>='" + DateTime.Now+"' Order By graphic.data";
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
                Graphic_GridView.Rows.Add(s);

        }
        private void Grafics_View_Load(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Graphic_GridView.Rows.Clear();
            BD ConnDB = new BD();
            ConnDB.openConnection();
            string request = "Select naimenovanie, tip, invent_nomer, zavod_nomer, prinadlejnost, periodichnost, journals.data, (Select mesto_provedenia from mesto_provedenia where mesto_provedenia_id = mesto_proved_old), graphic.data, (Select mesto_provedenia from mesto_provedenia where mesto_provedenia_id = mesto_proved_new),  zakluchenie, vid_rabot From si_card join journals on si_card.id_si=journals.id_si join graphic on si_card.id_si=graphic.id_si join mesto_provedenia on mesto_provedenia.mesto_provedenia_id = graphic.mesto_proved_new where invent_nomer=@invent_nomer and zavod_nomer=@zavod_nomer and graphic.data>='" + DateTime.Now+"' Order By graphic.data ";
            MySqlCommand Nado1 = new MySqlCommand(request, ConnDB.getConnection());
            Nado1.Parameters.Add("@invent_nomer", MySqlDbType.VarChar).Value = invent_Box.Text;
            Nado1.Parameters.Add("@zavod_nomer", MySqlDbType.VarChar).Value = zavod_Box.Text;
            MySqlDataReader reader = Nado1.ExecuteReader();
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
                Graphic_GridView.Rows.Add(s);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

                this.Hide();
                MainMenu F = new MainMenu();
                F.Show();
        }
    }
}
