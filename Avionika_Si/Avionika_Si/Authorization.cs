using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avionika_Si;
using System.Data.SqlClient;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Oborot_SI
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        public static string Role = "";
        public int Attestacia;
        public static int Etalon;
        public static int ID_SI;
        public static int periodichnost;
        private void Authoriz_Button_Click(object sender, EventArgs e) //авторизация пользователя
        {
            if (!string.IsNullOrEmpty(Login_Box.Text) && !string.IsNullOrWhiteSpace(Login_Box.Text) &&
    !string.IsNullOrEmpty(Password_Box.Text) && !string.IsNullOrWhiteSpace(Password_Box.Text))
            {
                BD ConnDB = new BD();
                ConnDB.openConnection();
                string request = "Select role.role from role join sotrudnik On role.role=sotrudnik.role where login=@Login and password=@Password";
                MySqlCommand Nado = new MySqlCommand(request, ConnDB.getConnection());
                Nado.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login_Box.Text;
                Nado.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password_Box.Text;
                MySqlDataReader sqlData = Nado.ExecuteReader();
                sqlData.Read();
                if (sqlData.HasRows)
                {
                    BD ConnDB1 = new BD();
                    ConnDB1.openConnection();
                    string request1 = "SELECT (YEAR(CURDATE()) - (SELECT YEAR(date_attestacia) FROM sotrudnik where login=@Login and password=@Password))";
                    MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                    Nado1.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login_Box.Text;
                    Nado1.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password_Box.Text;
                    MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                    sqlData1.Read();
                    if (sqlData1.HasRows)
                    {
                        Attestacia = Convert.ToInt32(sqlData1[0].ToString());
                        if (Attestacia <= 5)
                        {
                            Role = sqlData[0].ToString();
                            this.Hide();
                            MainMenu F = new MainMenu();
                            F.Show();
                        }
                        else
                            MessageBox.Show("Вход не выполнен. Продлите вашу аттестацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConnDB1.CloseConnection();
                    }
                }

                else
                    MessageBox.Show("Вход не выполнен. Проверьте корректность введеных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnDB.CloseConnection();
            }
            else
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void Authoriz_Button_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Password_Box_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(Login_Box.Text) && !string.IsNullOrWhiteSpace(Login_Box.Text) &&
   !string.IsNullOrEmpty(Password_Box.Text) && !string.IsNullOrWhiteSpace(Password_Box.Text))
                {
                    BD ConnDB = new BD();
                    ConnDB.openConnection();
                    string request = "Select role.role from role join sotrudnik On role.role=sotrudnik.role where login=@Login and password=@Password";
                    MySqlCommand Nado = new MySqlCommand(request, ConnDB.getConnection());
                    Nado.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login_Box.Text;
                    Nado.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password_Box.Text;
                    MySqlDataReader sqlData = Nado.ExecuteReader();
                    sqlData.Read();
                    if (sqlData.HasRows)
                    {
                        BD ConnDB1 = new BD();
                        ConnDB1.openConnection();
                        string request1 = "SELECT (YEAR(CURDATE()) - (SELECT YEAR(date_attestacia) FROM sotrudnik where login=@Login and password=@Password))";
                        MySqlCommand Nado1 = new MySqlCommand(request1, ConnDB1.getConnection());
                        Nado1.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login_Box.Text;
                        Nado1.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password_Box.Text;
                        MySqlDataReader sqlData1 = Nado1.ExecuteReader();
                        sqlData1.Read();
                        if (sqlData1.HasRows)
                        {
                            Attestacia = Convert.ToInt32(sqlData1[0].ToString());
                            if (Attestacia <= 5)
                            {
                                Role = sqlData[0].ToString();
                                this.Hide();
                                MainMenu F = new MainMenu();
                                F.Show();
                            }
                            else
                                MessageBox.Show("Вход не выполнен. Продлите вашу аттестацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ConnDB1.CloseConnection();
                        }
                    }

                    else
                        MessageBox.Show("Вход не выполнен. Проверьте корректность введеных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnDB.CloseConnection();
                }
                else
                    MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
