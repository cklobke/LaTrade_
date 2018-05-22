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
    public partial class Rechnungen : LTForm
    {
        public Rechnungen()
        {
            InitializeComponent();
        }

        private void Rechnungen_Load(object sender, EventArgs e)
        {
            gridAu.Dock = DockStyle.Fill;
        }
    }
}
