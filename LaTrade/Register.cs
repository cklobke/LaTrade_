using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDenc;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Web;
using LoginForm;

namespace LoginForm
{
    public partial class Register : Form
    {
        MySqlConnection connection;
        Login Parent;
        public Register(MySqlConnection dbconnection, Login ParentClass)
        {
            Parent = ParentClass;
            connection = dbconnection;
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswort.UseSystemPasswordChar =! cbShowPasswort.Checked;
        }

        private void DoRegister()
        {
            string CryptedAdminPasswort = "";
            string DecryptedAdminPasswort;

            string AdminQuery = "select USER_PASSWORT from USER where USER_VORNAME = 'Admin'";

            MySqlCommand AdminCommand = new MySqlCommand(AdminQuery, connection);

            AdminCommand.ExecuteNonQuery();

            MySqlDataReader reader = AdminCommand.ExecuteReader();

            while (reader.Read())
            {
                CryptedAdminPasswort = reader.GetString("USER_PASSWORT");
            }
            reader.Close();

            DecryptedAdminPasswort = AESCrypt.Decrypt(CryptedAdminPasswort);

            if ((tbPasswort.Text.Length > 0) & (tbAdminPasswort.Text == DecryptedAdminPasswort))
            {
                string vorname = tbVorname.Text;
                string nachname = tbNachname.Text;
                string kurz = vorname.ToUpper().Substring(0, 1) + nachname.ToUpper().Substring(0, 2);
                int recht = 3;
                string encpass = AESCrypt.Encrypt(tbPasswort.Text);

                string query = "INSERT INTO USER (`USER_KURZ` ,`USER_VORNAME` ,`USER_NACHNAME` ,`USER_RECHTEGRUPPE` ,`USER_PASSWORT`) " +
                "VALUES('" + kurz + "','" + vorname + "','" + nachname + "'," + recht + ",'" + encpass + "')";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Der Nutzer wurde erfolgreich angelegt.");
                Parent.RefreshData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim Anlegen des Benutzers!");
            }
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            DoRegister();
        }

        private void tbAdminPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoRegister();
            }
        }

        private void tbVorname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoRegister();
            }
        }

        private void tbNachname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoRegister();
            }
        }

        private void tbPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoRegister();
            }
        }
    }
}
