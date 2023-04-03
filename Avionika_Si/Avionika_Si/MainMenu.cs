using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avionika_Si;
using MySql.Data.MySqlClient;

namespace Oborot_SI
{
    public partial class MainMenu : Form
    {
        private void MainMenu_Load(object sender, EventArgs e)
        {


        }
        public MainMenu()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Card_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Card_si F = new Card_si();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void toPasp_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pasport F = new Pasport();
            F.Show();
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grafic F = new Grafic();
            F.Show();
        }

        private void Journal_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Journal F = new Journal();
            F.Show();
        }

        private void Protocol_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Protocol F = new Protocol();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Attestat F = new Attestat();
            F.Show();
        }
    }
}
