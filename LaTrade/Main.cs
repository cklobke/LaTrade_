using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaTrade;

namespace LaTrade
{
    public partial class Main : Form
    {
        Login login;
        bool SideMenuOpen;
        string SelectedMenuPoint;
        LTForm Selected = new LTForm();
        public string Top_Color;
        public string Back_Color;
        public string Btn_Color;
        public string Btn_Alt_Color;
        public string Side_Menu_Color;

        public Main(Login parent)
        {
            login = parent;
            InitializeComponent();

            Top_Color = login.Top_Color;
            Back_Color = login.Back_Color;
            Btn_Color = login.Btn_Color;
            Btn_Alt_Color = login.Btn_Alt_Color;
            Side_Menu_Color = login.Side_Menu_Color;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            pnlKasse.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            pnlEinkauf.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            pnlStatistik.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            pnlTopMenu.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Side_Menu_Color);
            pnlSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
            SideMenuOpen = true;

            //Pfusch am Bau
            //Platzhalter für das MainPanel
            LTForm StartForm = new LTForm();
            StartForm.MdiParent = this;
            StartForm.Show();
            StartForm.WindowState = FormWindowState.Maximized;
            Selected = StartForm;
            LTForm StartForm2 = new LTForm();
            StartForm2.MdiParent = this;
            StartForm2.Show();
            StartForm2.WindowState = FormWindowState.Maximized;
            Selected.Close();
            StartForm2.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Back_Color);
            Selected = StartForm2;
        }


      

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnKunden_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWeiter_MouseHover(object sender, EventArgs e)
        {
            HoverAuftraege(true);
        }

        private void HoverAuftraege(bool hoverOk)
        {
            if (hoverOk)
            {
                btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
                pbAuftraege.Load("icons/icons8-benutzer-menü-männlich-filled-50.png");
            } else if (SelectedMenuPoint != "Auftraege")
            {
                btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
                pbAuftraege.Load("icons/icons8-benutzer-menü-männlich-50.png");
            }

        }
        private void HoverRechnungen(bool hoverOk)
        {
            if (hoverOk)
            {
                btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
                pbRechnungen.Load("icons/icons8-rechnung-filled-50.png");
            }
            else if (SelectedMenuPoint != "Rechnungen")
            {
                btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
                pbRechnungen.Load("icons/icons8-rechnung-50.png");
            }

        }
        private void HoverLieferungen(bool hoverOk)
        {
            if (hoverOk)
            {
                btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
                pbLieferungen.Load("icons/icons8-versendet-filled-50.png");
            }
            else if (SelectedMenuPoint != "Lieferungen")
            {
                btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
                pbLieferungen.Load("icons/icons8-versendet-50.png");
            }

        }
        private void HoverKunden(bool hoverOk)
        {
            if (hoverOk)
            {
                btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
                pbKunden.Load("icons/icons8-benutzer-filled-50.png");
            }
            else if (SelectedMenuPoint != "Kundenstamm")
            {
                btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
                pbKunden.Load("icons/icons8-benutzer-50.png");
            }

        }
        private void HoverLagerbestand(bool hoverOk)
        {
            if (hoverOk)
            {
                btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
                pbLagerstand.Load("icons/icons8-lagerhaus-filled-50.png");
            }
            else if (SelectedMenuPoint != "Lagerstand")
            {
                btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
                pbLagerstand.Load("icons/icons8-lagerhaus-50.png");
            }

        }
        private void HoverEinkauf(bool hoverOk) {
            if (hoverOk) {
                pbEinkauf.Load("icons/icons8-kaufen-filled-50.png");
                pnlEinkauf.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
            } else if (SelectedMenuPoint != "Einkauf"){
                pbEinkauf.Load("icons/icons8-kaufen-50.png");
                pnlEinkauf.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            }
            
        }
        private void HoverStatistik(bool hoverOk)
        {
            if (hoverOk)
            {
                pbStatistik.Load("icons/icons8-positive-dynamik-filled-50.png");
                pnlStatistik.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
            }
            else if (SelectedMenuPoint != "Statistik")
            {
                pbStatistik.Load("icons/icons8-positive-dynamik-50.png");
                pnlStatistik.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            }

        }
        private void HoverKasse(bool hoverOk)
        {
            if (hoverOk)
            {
                pbKasse.Load("icons/icons8-kasse-filled-50.png");
                pnlKasse.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Alt_Color);
            }
            else if (SelectedMenuPoint != "Kasse")
            {
                pbKasse.Load("icons/icons8-kasse-50.png");
                pnlKasse.BackColor = System.Drawing.ColorTranslator.FromHtml(login.Btn_Color);
            }

        }

        private void btnAuftraege_MouseHover(object sender, EventArgs e)
        {
            HoverAuftraege(true);
        }

        private void pbAuftraege_MouseHover(object sender, EventArgs e)
        {
            HoverAuftraege(true);
        }

        private void lblRechnungen_MouseHover(object sender, EventArgs e)
        {
            HoverRechnungen(true);
        }

        private void btnRechnungen_MouseHover(object sender, EventArgs e)
        {
            HoverRechnungen(true);
        }

        private void pbRechnungen_MouseHover(object sender, EventArgs e)
        {
            HoverRechnungen(true);
        }

        private void lblKundenstamm_MouseHover(object sender, EventArgs e)
        {
            HoverKunden(true);
        }

        private void btnKunden_MouseHover(object sender, EventArgs e)
        {
            HoverKunden(true);
        }

        private void pbKunden_MouseHover(object sender, EventArgs e)
        {
            HoverKunden(true);
        }

        private void lblLieferungen_MouseHover(object sender, EventArgs e)
        {
            HoverLieferungen(true);
        }

        private void btnLieferungen_MouseHover(object sender, EventArgs e)
        {
            HoverLieferungen(true);
        }

        private void pbLieferungen_MouseHover(object sender, EventArgs e)
        {
            HoverLieferungen(true);
        }

        private void lblLagerstand_MouseHover(object sender, EventArgs e)
        {
            HoverLagerbestand(true);
        }

        private void btnLagerstand_MouseHover(object sender, EventArgs e)
        {
            HoverLagerbestand(true);
        }

        private void pbLagerstand_MouseHover(object sender, EventArgs e)
        {
            HoverLagerbestand(true);
        }

        private void pbLagerstand_MouseLeave(object sender, EventArgs e)
        {
            HoverLagerbestand(false);
        }

        private void btnLagerstand_MouseLeave(object sender, EventArgs e)
        {
            HoverLagerbestand(false);
        }

        private void lblLagerstand_MouseLeave(object sender, EventArgs e)
        {
            HoverLagerbestand(false);
        }

        private void lblLieferungen_MouseLeave(object sender, EventArgs e)
        {
            HoverLieferungen(false);
        }

        private void btnLieferungen_MouseLeave(object sender, EventArgs e)
        {
            HoverLieferungen(false);
        }

        private void pbLieferungen_MouseLeave(object sender, EventArgs e)
        {
            HoverLieferungen(false);
        }

        private void lblKundenstamm_MouseLeave(object sender, EventArgs e)
        {
            HoverKunden(false);
        }

        private void btnKunden_MouseLeave(object sender, EventArgs e)
        {
            HoverKunden(false);
        }

        private void pbKunden_MouseLeave(object sender, EventArgs e)
        {
            HoverKunden(false);
        }

        private void lblRechnungen_MouseLeave(object sender, EventArgs e)
        {
            HoverRechnungen(false);
        }

        private void btnRechnungen_MouseLeave(object sender, EventArgs e)
        {
            HoverRechnungen(false);
        }

        private void pbRechnungen_MouseLeave(object sender, EventArgs e)
        {
            HoverRechnungen(false);
        }

        private void lblAuftraege_MouseLeave(object sender, EventArgs e)
        {
            HoverAuftraege(false);
        }

        private void btnAuftraege_MouseLeave(object sender, EventArgs e)
        {
            HoverAuftraege(false);
        }

        private void pbAuftraege_MouseLeave(object sender, EventArgs e)
        {
            HoverAuftraege(false);
        }

        private void pbSideMenu_MouseHover(object sender, EventArgs e)
        {
            pbSideMenu.Load("icons/icons8-menü-filled-50.png");
        }

        private void pbSideMenu_MouseLeave(object sender, EventArgs e)
        {
            pbSideMenu.Load("icons/icons8-menü-50.png");
        }



        private void pbSideMenu_Click(object sender, EventArgs e)
        {
            if (SideMenuOpen)
            {
                SideMenuOpen = false;
            }
            else {
                SideMenuOpen = true;
            }
        }

        private void btnAuftraege_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAuftraege_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Auftraege")
            {
                Auftraege frmAU = new Auftraege(this);
                frmAU.MdiParent = this;
                frmAU.Show();

                Selected.Close();

                HoverAuftraege(true);
                SelectedMenuPoint = "Auftraege";
                ResetBtnColors();
            }
            else {
                HoverAuftraege(false);
            }
        }

        private void lblRechnungen_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Rechnungen")
            {
                HoverRechnungen(true);
                SelectedMenuPoint = "Rechnungen";
                ResetBtnColors();

                Rechnungen rechnungen = new Rechnungen();
                rechnungen.MdiParent = this;
                rechnungen.Show();

                Selected.Close();
            }
            else
            {
                HoverRechnungen(false);
            }
        }

        private void lblKundenstamm_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Kundenstamm")
            {
                HoverKunden(true);
                SelectedMenuPoint = "Kundenstamm";
                ResetBtnColors();
                Kunden kunden = new Kunden();
                kunden.MdiParent = this;
                kunden.Show();

                Selected.Close();
            }
            else
            {
                HoverKunden(false);
            }
        }

        private void lblLieferungen_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Lieferungen")
            {
                HoverLieferungen(true);
                SelectedMenuPoint = "Lieferungen";
                ResetBtnColors();
            }
            else
            {
                HoverLieferungen(false);
            }
        }

        private void lblLagerstand_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Lagerstand")
            {
                HoverLagerbestand(true);
                SelectedMenuPoint = "Lagerstand";
                ResetBtnColors(); 
            }
            else
            {
                HoverLagerbestand(false);
            }
        }

        private void ResetBtnColors() {
            if (SelectedMenuPoint == "Lagerstand")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverRechnungen(false);
                HoverKunden(false);
                HoverStatistik(false);
                HoverEinkauf(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Rechnungen") {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
                HoverStatistik(false);
                HoverEinkauf(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Lieferungen")
            {
                HoverAuftraege(false);
                HoverRechnungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
                HoverStatistik(false);
                HoverEinkauf(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Auftraege")
            {
                HoverRechnungen(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
                HoverStatistik(false);
                HoverEinkauf(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Kundenstamm")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverRechnungen(false);
                HoverStatistik(false);
                HoverEinkauf(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Einkauf")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverRechnungen(false);
                HoverStatistik(false);
                HoverKunden(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Statistik")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverRechnungen(false);
                HoverEinkauf(false);
                HoverKunden(false);
                HoverKasse(false);
            }
            else if (SelectedMenuPoint == "Kasse")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverRechnungen(false);
                HoverEinkauf(false);
                HoverKunden(false);
                HoverStatistik(false);
            }
        }
        private void btnLagerstand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbHelp_MouseHover(object sender, EventArgs e)
        {
            pbHelp.Load("icons/icons8-hilfe-filled-50.png");
        }

        private void pbHelp_MouseLeave(object sender, EventArgs e)
        {
            pbHelp.Load("icons/icons8-hilfe-50.png");
        }

        private void pbPrint_MouseHover(object sender, EventArgs e)
        {
            pbPrint.Load("icons/icons8-drucken-filled-50.png");
        }

        private void pbPrint_MouseLeave(object sender, EventArgs e)
        {
            pbPrint.Load("icons/icons8-drucken-50.png");
        }

        private void pbDesign_MouseHover(object sender, EventArgs e)
        {
            pbDesign.Load("icons/icons8-design-filled-50.png");
        }

        private void pbDesign_MouseLeave(object sender, EventArgs e)
        {
            pbDesign.Load("icons/icons8-design-50.png");
        }

        private void pbSettings_MouseHover(object sender, EventArgs e)
        {
            pbSettings.Load("icons/icons8-einstellungen-filled-50.png");
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            pbSettings.Load("icons/icons8-einstellungen-50.png");
        }

        private void lblEinkauf_MouseHover(object sender, EventArgs e)
        {
            HoverEinkauf(true);
        }

        private void lblEinkauf_MouseLeave(object sender, EventArgs e)
        {
            HoverEinkauf(false);
        }

        private void lblStatistik_MouseHover(object sender, EventArgs e)
        {
            HoverStatistik(true);
        }

        private void lblStatistik_MouseLeave(object sender, EventArgs e)
        {
            HoverStatistik(false);
        }

        private void lblKasse_MouseHover(object sender, EventArgs e)
        {
            HoverKasse(true);
        }

        private void lblKasse_MouseLeave(object sender, EventArgs e)
        {
            HoverKasse(false);
        }

        private void lblEinkauf_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Einkauf")
            {
                HoverEinkauf(true);
                SelectedMenuPoint = "Einkauf";
                ResetBtnColors();
            }
            else
            {
                HoverEinkauf(false);
            }
        }

        private void lblStatistik_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Statistik")
            {
                HoverStatistik(true);
                SelectedMenuPoint = "Statistik";
                ResetBtnColors();
            }
            else
            {
                HoverStatistik(false);
            }
        }

        private void lblKasse_Click(object sender, EventArgs e)
        {
            if (SelectedMenuPoint != "Kasse")
            {
                HoverKasse(true);
                SelectedMenuPoint = "Kasse";
                ResetBtnColors();
            }
            else
            {
                HoverKasse(false);
            }
        }
    }

}
