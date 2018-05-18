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
        int LoginStep;


        public Login()
        {
            InitializeComponent();
        }




        private string getUserPasswort() {
            string UserPasswort = "";

            dbconnection = new MySqlConnection("Server=192.168.178.59;Port=3306;" +
           "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ");

            dbconnection.Open();

            string query = "select USER_PASSWORT from USER where USER_NUTZERNAME = '" + tbNutzer.Text + "'";

            MySqlCommand command = new MySqlCommand(query, dbconnection);

            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                UserPasswort = reader.GetString("USER_PASSWORT");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }

            reader.Close();

            return UserPasswort;
        }

        private bool CheckUserName()
        {
            bool NutzerVorhanden = false;
            
             dbconnection = new MySqlConnection("Server=192.168.178.59;Port=3306;" +
            "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ");

            dbconnection.Open();

            string query = "select USER_NUTZERNAME from USER where USER_NUTZERNAME = '" + tbNutzer.Text + "'";

            MySqlCommand command = new MySqlCommand(query, dbconnection);

            command.ExecuteNonQuery();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                NutzerVorhanden = (reader.FieldCount>0);// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }

            reader.Close();

            return NutzerVorhanden;
        }
        public void RefreshData()
        {
            dbconnection = new MySqlConnection("Server=192.168.178.59;Port=3306;" +
           "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ");

            dbconnection.Open();
        }

        private void DoLogin()
        {
            if (getUserPasswort() == AESCrypt.Encrypt(tbPasswort.Text))
            {
                Main Main = new Main(this);
                Main.Owner = this;
                Main.Show();
                dbconnection.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falsches Passwort. Bitte versuchen Sie es erneut!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RefreshData();
            LoginStep = 1;
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            tbNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml("#4d80d1");
            tbPasswort.BackColor = System.Drawing.ColorTranslator.FromHtml("#4d80d1");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
        }

        private void cbShowPasswort_CheckedChanged(object sender, EventArgs e)
        {
       
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F5395");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ShowPasswortHover();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ShowPasswortLeave();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            ButtonWeiterHover();
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            ButtonWeiterLeave();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            ButtonBenutzerHover();
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            ButtonBenutzerLeave();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ButtonWeiterHover();
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ButtonWeiterLeave();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ButtonBenutzerHover();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            ButtonBenutzerLeave();
        }

        private void ButtonWeiterHover() {
            pictureBox2.Load("icons/icons8-winkel-rechts-filled-50.png");
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
        }
        private void ButtonBenutzerHover() {
            pictureBox3.Load("icons/icons8-benutzer-filled-50.png");
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
        }
        private void ShowPasswortHover(){
            pictureBox1.Load("icons/icons8-sichtbar-filled-50.png");
            if (tbPasswort.Text != "Passwort") {
                tbPasswort.UseSystemPasswordChar = false; ;
            }
        }
        private void ButtonWeiterLeave()
        {
            pictureBox2.Load("icons/icons8-winkel-rechts-50.png");
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
        }
        private void ButtonBenutzerLeave()
        {
            pictureBox3.Load("icons/icons8-benutzer-50.png");
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
        }
        private void ShowPasswortLeave()
        {
            pictureBox1.Load("icons/icons8-sichtbar-50.png");
            tbPasswort.UseSystemPasswordChar = true; ;
        }

        private void WeiterClick() {
            if (LoginStep == 1)
            {
                if (CheckUserName())
                {
                    tbPasswort.Enabled = true;
                    tbPasswort.Visible = true;
                    tbNutzer.Enabled = false;
                    tbNutzer.Visible = false;
                    pictureBox1.Visible = true;
                    lblWeiter.Text = "Anmelden";
                    pictureBox4.Visible = true;
                    LoginStep = 2;
                }
                else
                {
                    MessageBox.Show("Es ist uns leider kein Benutzer mit diesem Namen bekannt.");
                }
            }
            else 
            {
                DoLogin();
            }
        }
        private void BenutzerClick() {
            Register register = new Register(dbconnection, this);
            register.Show();
        }

        private void lblNutzer_Click(object sender, EventArgs e)
        {
            BenutzerClick();
        }

        private void pnlWeiter_Click(object sender, EventArgs e)
        {
            WeiterClick();
        }

        private void lblWeiter_Click(object sender, EventArgs e)
        {
            WeiterClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WeiterClick();
        }

        private void pnlNutzer_Click(object sender, EventArgs e)
        {
            BenutzerClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BenutzerClick();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ButtonWeiterHover();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ButtonWeiterLeave();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ButtonBenutzerHover();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ButtonBenutzerLeave();
        }

        private void tbNutzer_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbNutzer.Text == "Benutzer")
            {
                tbNutzer.Text = "";
            }
            if (e.KeyCode == Keys.Enter)
            {
                WeiterClick();
            }
        }
    
        private void tbPasswort_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPasswort.Text == "") {
                
                tbPasswort.Text = "Passwort";  
            }
            if (tbPasswort.Text == "Passwort")
            {
                tbPasswort.UseSystemPasswordChar = false;                
            }
            else {
                tbPasswort.UseSystemPasswordChar = true;
                tbPasswort.SelectionStart = tbPasswort.Text.Length;
            }

        }

        private void tbPasswort_KeyDown(object sender, KeyEventArgs e)
        {

            if (tbPasswort.Text == "Passwort")
            {
                tbPasswort.Text = "";
            }

            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Load("icons/icons8-winkel-links-filled-50.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Load("icons/icons8-winkel-links-50.png");
        }

        private void tbNutzer_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbNutzer.Text == "")
            {
                tbNutzer.Text = "Benutzer";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginStep = 1;
            tbPasswort.Text = "";
            tbPasswort.Enabled = false;
            tbPasswort.Visible = false;
            tbNutzer.Enabled = true;
            tbNutzer.Visible = true;
            lblWeiter.Text = "Weiter";
        }
    }
}
