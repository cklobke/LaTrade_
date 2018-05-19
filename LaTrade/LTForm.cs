using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTrade
{
    public partial class LTForm : Form
    {
        public LTForm()
        {
            InitializeComponent();
        }

        private void LTForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#93a1ad");
            //this.WindowState = FormWindowState.Maximized;
            
        }
    }
}
