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

        public Main(Login parent)
        {
            login = parent;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            pnlTopMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#536995");
            pnlSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#93a1ad");
            SideMenuOpen = true;
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
                btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
                pbAuftraege.Load("icons/icons8-benutzer-menü-männlich-filled-50.png");
            } else if (SelectedMenuPoint != "Auftraege")
            {
                btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
                pbAuftraege.Load("icons/icons8-benutzer-menü-männlich-50.png");
            }

        }
        private void HoverRechnungen(bool hoverOk)
        {
            if (hoverOk)
            {
                btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
                pbRechnungen.Load("icons/icons8-rechnung-filled-50.png");
            }
            else if (SelectedMenuPoint != "Rechnungen")
            {
                btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
                pbRechnungen.Load("icons/icons8-rechnung-50.png");
            }

        }
        private void HoverLieferungen(bool hoverOk)
        {
            if (hoverOk)
            {
                btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
                pbLieferungen.Load("icons/icons8-versendet-filled-50.png");
            }
            else if (SelectedMenuPoint != "Lieferungen")
            {
                btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
                pbLieferungen.Load("icons/icons8-versendet-50.png");
            }

        }
        private void HoverKunden(bool hoverOk)
        {
            if (hoverOk)
            {
                btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
                pbKunden.Load("icons/icons8-benutzer-filled-50.png");
            }
            else if (SelectedMenuPoint != "Kundenstamm")
            {
                btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
                pbKunden.Load("icons/icons8-benutzer-50.png");
            }

        }
        private void HoverLagerbestand(bool hoverOk)
        {
            if (hoverOk)
            {
                btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml("#41CBC7");
                pbLagerstand.Load("icons/icons8-lagerhaus-filled-50.png");
            }
            else if (SelectedMenuPoint != "Lagerstand")
            {
                btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
                pbLagerstand.Load("icons/icons8-lagerhaus-50.png");
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
            Auftraege frmAU = new Auftraege();
            frmAU.MdiParent = panel2.MdiForm;
            frmAU.Show();

            if (SelectedMenuPoint != "Auftraege")
            {
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
            }
            else if (SelectedMenuPoint == "Rechnungen") {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
            }
            else if (SelectedMenuPoint == "Lieferungen")
            {
                HoverAuftraege(false);
                HoverRechnungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
            }
            else if (SelectedMenuPoint == "Auftraege")
            {
                HoverRechnungen(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverKunden(false);
            }
            else if (SelectedMenuPoint == "Kundenstamm")
            {
                HoverAuftraege(false);
                HoverLieferungen(false);
                HoverLagerbestand(false);
                HoverRechnungen(false);
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
    }

    public class MdiClientPanel : Panel
    {
        private Form mdiForm;
        private MdiClient ctlClient = new MdiClient();

        public MdiClientPanel()
        {
            base.Controls.Add(this.ctlClient);
        }

        public Form MdiForm
        {
            get
            {
                if (this.mdiForm == null)
                {
                    this.mdiForm = new Form();
                    /// set the hidden ctlClient field which is used to determine if the form is an MDI form
                    System.Reflection.FieldInfo field = typeof(Form).GetField("ctlClient", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    field.SetValue(this.mdiForm, this.ctlClient);
                }
                return this.mdiForm;
            }
        }
    }

}
