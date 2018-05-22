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
using IniUnit;

namespace LaTrade
{


    public partial class Login : Form
    {
        String EncryptedUserPasswort;
        MySqlConnection dbconnection;
        int LoginStep;
        bool savedPasswort;
        IniFile LoginIni;
        public string Top_Color;
        public string Back_Color;
        public string Btn_Color;
        public string Btn_Alt_Color;
        public string Side_Menu_Color;


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

        private void GetColors()
        {
            dbconnection = new MySqlConnection("Server=192.168.178.59;Port=3306;" +
           "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ");

            dbconnection.Open();

            string query_top = "select COLOR_VALUE as COLOR from COLORS where COLOR_NAME = 'Main_Top'";
            string query_back = "select COLOR_VALUE as COLOR from COLORS where COLOR_NAME = 'Background'";
            string query_btn = "select COLOR_VALUE as COLOR from COLORS where COLOR_NAME = 'Alternative'";
            string query_btn_alt = "select COLOR_VALUE as COLOR from COLORS where COLOR_NAME = 'Front_Color'";
            string query_side_menu = "select COLOR_VALUE as COLOR from COLORS where COLOR_NAME = 'Side_Menu'";

            MySqlCommand command_top = new MySqlCommand(query_top, dbconnection);
            MySqlCommand command_back = new MySqlCommand(query_back, dbconnection);
            MySqlCommand command_btn = new MySqlCommand(query_btn, dbconnection);
            MySqlCommand command_btn_alt = new MySqlCommand(query_btn_alt, dbconnection);
            MySqlCommand command_side_menu = new MySqlCommand(query_side_menu, dbconnection);

            command_top.ExecuteNonQuery();
            command_back.ExecuteNonQuery();
            command_btn.ExecuteNonQuery();
            command_btn_alt.ExecuteNonQuery();
            command_side_menu.ExecuteNonQuery();

            MySqlDataReader reader_top = command_top.ExecuteReader();
            while (reader_top.Read())
            {
                Top_Color = "#"+ reader_top.GetString("COLOR");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }
            reader_top.Close();

            MySqlDataReader reader_back = command_back.ExecuteReader();
            while (reader_back.Read())
            {
                Back_Color = "#" + reader_back.GetString("COLOR");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }
            reader_back.Close();

            MySqlDataReader reader_btn = command_btn.ExecuteReader();
            while (reader_btn.Read())
            {
                Btn_Color = "#" + reader_btn.GetString("COLOR");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }
            reader_btn.Close();

            MySqlDataReader reader_btn_alt = command_btn_alt.ExecuteReader();
            while (reader_btn_alt.Read())
            {
                Btn_Alt_Color = "#" + reader_btn_alt.GetString("COLOR");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }
            reader_btn_alt.Close();

            MySqlDataReader reader_side_menu = command_side_menu.ExecuteReader();
            while (reader_side_menu.Read())
            {
                Side_Menu_Color = "#" + reader_side_menu.GetString("COLOR");// GetString("USER_VORNAME") + ' ' + reader.GetString("USER_NACHNAME")
            }
            reader_side_menu.Close();

            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(Back_Color);
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
            tbNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
            tbPasswort.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
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
                LoginIni.Write("Username", tbNutzer.Text);
                if (savedPasswort) {
                    LoginIni.Write("Passwort", AESCrypt.Encrypt(tbPasswort.Text));
                }
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

            GetColors();

            LoginIni = new IniFile("Login.ini");
            savedPasswort = (LoginIni.Read("Passwort").Length > 0);
            if (savedPasswort)
            {
                pictureBox5.Load("icons/icons8-sperren-2-filled-50.png");
            }
            tbNutzer.Text = LoginIni.Read("Username");
            tbPasswort.Text = AESCrypt.Decrypt(LoginIni.Read("Passwort"));
            if (tbNutzer.Text == null | tbNutzer.Text == "") {
                tbNutzer.Text = "Benutzer";
            }
            if (tbPasswort.Text == null | tbPasswort.Text == "")
            {
                tbPasswort.Text = "Passwort";
            }
            if (tbPasswort.Text != "Passwort")
            {
                tbPasswort.UseSystemPasswordChar = true;
            }
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
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Alt_Color);
        }
        private void ButtonBenutzerHover() {
            pictureBox3.Load("icons/icons8-benutzer-filled-50.png");
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Alt_Color);
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
            pnlWeiter.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
        }
        private void ButtonBenutzerLeave()
        {
            pictureBox3.Load("icons/icons8-benutzer-50.png");
            pnlNutzer.BackColor = System.Drawing.ColorTranslator.FromHtml(Btn_Color);
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
                    pictureBox5.Visible = true;
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
            tbPasswort.Enabled = false;
            tbPasswort.Visible = false;
            tbNutzer.Enabled = true;
            tbNutzer.Visible = true;
            pictureBox5.Visible = false;
            lblWeiter.Text = "Weiter";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Load("icons/icons8-sperren-2-filled-50.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (!savedPasswort) {
                pictureBox5.Load("icons/icons8-sperren-2-50.png");
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (savedPasswort)
            {
                savedPasswort = false;
                pictureBox5.Load("icons/icons8-sperren-2-50.png");
            }
            else {
                savedPasswort = true;
                pictureBox5.Load("icons/icons8-sperren-2-filled-50.png");
            }
            
        }
    }
}
