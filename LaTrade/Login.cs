using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Web;
using AesEncDenc;
using System.IO;

namespace LoginForm
{
    public partial class Login : Form
    {
        String EncryptedUserPasswort;
        MySqlConnection dbconnection;

        public Login()
        {
            InitializeComponent();
        }

        private string GetCBVorname()
        {
            int i = cbUsers.Text.IndexOf(" ");


            return cbUsers.Text.Substring(0, i);
        }

        private string GetCBNachname()
        {
            int i = cbUsers.Text.IndexOf(" ");

            return cbUsers.Text.Substring(i+1, cbUsers.Text.Length - (i+1));
        }

        public void RefreshData()
        {
            cbUsers.Items.Clear();

            dbconnection = new MySqlConnection("Server=192.168.178.59;Port=3306;" +
            "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ");

            dbconnection.Open();

            string query = "select USER_VORNAME, USER_NACHNAME from USER where USER_RECHTEGRUPPE > 0";

            MySqlCommand command = new MySqlCommand(query, dbconnection);

            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbUsers.Items.Add(reader.GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME"));
            }

            reader.Close();

        }

        private void DoLogin()
        {
            if (EncryptedUserPasswort == AESCrypt.Encrypt(tbPasswort.Text))
            {
                Main Main = new Main(this);
                Main.Owner = this;
                Main.Show();
                dbconnection.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falsches Passwort. Versuchen Sie es erneut!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(dbconnection, this);
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RefreshData();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
        }

        private void cbShowPasswort_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswort.UseSystemPasswordChar = !cbShowPasswort.Checked;
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vorname = GetCBVorname();
            string nachname = GetCBNachname();


            string query = "select USER_PASSWORT from USER where USER_VORNAME = '" + vorname + "' and USER_NACHNAME = '" + nachname + "'";

            MySqlCommand command = new MySqlCommand(query, dbconnection);

            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                EncryptedUserPasswort = (reader.GetString("USER_PASSWORT"));
            }
                 
            reader.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }
    }
}
