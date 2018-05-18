using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Main : Form
    {
        Login login;
        public Main(Login parent)
        {
            login = parent;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
            pnlTopMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#536995");
            pnlSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#93a1ad"); 
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
            } else
            {
                btnAuftraege.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
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
            else
            {
                btnRechnungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
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
            else
            {
                btnLieferungen.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
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
            else
            {
                btnKunden.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
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
            else
            {
                btnLagerstand.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EA5D2");
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
    }
}
