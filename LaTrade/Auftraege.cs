using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LaTrade
{
    public partial class Auftraege : LTForm
    {
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;
        private string where = "";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        DataSet DS;
        private string mode;
        String connectionString;
        int currentRow;

        public Auftraege()
        {
            InitializeComponent();
        }

        private void Auftraege_Load(object sender, EventArgs e)
        {
            gridAu.Dock = DockStyle.Fill;
            gridAu.Font = new Font("Bahnschrift Light", 20);
            gridAu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            tbSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#497BB4");
            connectionString = "Server=192.168.178.59;Port=3306;" +
           "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ";

            LoadAuftraege();
        }

        private void LoadAuftraege() {
            connection = new MySqlConnection(connectionString);
            if (this.OpenConnection() == true)
            { 
                mySqlDataAdapter = new MySqlDataAdapter("select AU.*, KD_FIRMA, KD_VORNAME, KD_NACHNAME, KD_NR, KD_PLZ, ROUND((AUP_MENGE * ART_NETTO_PREIS),2) as NETTO, ROUND((AUP_MENGE * ART_NETTO_PREIS * ((100+ART_MWST)/100)), 2) as BRUTTO  "
                    + " from AU left join KD on AU_KD_ID = KD_ID left join AUP on AUP_AU_ID = AU_ID left join ART on AUP_ART_ID = ART_ID " + where, connection);

                DS = new DataSet();

                mySqlDataAdapter.Fill(DS, "AU");

                gridAu.DataSource = DS.Tables[0];

                this.CloseConnection();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void pbAuftraege_MouseHover(object sender, EventArgs e)
        {
            pbNew.Load("icons/icons8-hinzufügen-filled-50.png");
        }

        private void pbNew_MouseLeave(object sender, EventArgs e)
        {
            if (mode != "New")
            {
                pbNew.Load("icons/icons8-hinzufügen-50.png");
            }            
        }

        private void pbEdit_MouseHover(object sender, EventArgs e)
        {
            pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
        }

        private void pbEdit_MouseLeave(object sender, EventArgs e)
        {
            if (mode != "Edit")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
            }
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Load("icons/icons8-unwiederuflich-löschen-filled-50.png");
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            if (mode != "Delete")
            {
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
            }
        }

        private void pbSave_MouseHover(object sender, EventArgs e)
        {
            pbSave.Load("icons/icons8-speichern-filled-50.png");
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            if (mode != "Save")
            {
                pbSave.Load("icons/icons8-speichern-50.png");
            }
        }

        private void pbNew_Click(object sender, EventArgs e)
        {
            if (mode != "Edit" && mode != "Delete" && mode != "Save" && mode != "New") {
                mode = "New";
                pbNew.Load("icons/icons8-hinzufügen-filled-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");

            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (mode != "New" && mode != "Delete" && mode != "Save" && mode != "Edit")
            {
                mode = "Edit";
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");

                currentRow = gridAu.CurrentRow.Index;
                gridAu.ReadOnly = false;

            }            
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (mode != "Save" && mode != "Edit" && mode != "New" && mode != "Delete")
            mode = "Delete";
            pbNew.Load("icons/icons8-hinzufügen-50.png");
            pbSave.Load("icons/icons8-speichern-50.png");
            pbEdit.Load("icons/icons8-bearbeiten-50.png");
            pbDelete.Load("icons/icons8-unwiederuflich-löschen-filled-50.png");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (mode == "Edit" | mode == "New" && mode != "Save") {
                mode = "Save";
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-filled-50.png");
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                Save();
                pbSave.Load("icons/icons8-speichern-50.png");
                mode = "None";
                gridAu.ReadOnly = true;
            }            
        }

        private void gridAu_SelectionChanged(object sender, EventArgs e)
        {
            if (mode == "Edit")
            {
                if (DialogResult.Cancel == MessageBox.Show("Änderungen Speichern?", "Sie wechseln den Datensatz!", MessageBoxButtons.YesNoCancel))
                {
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                    gridAu.Rows[currentRow].Selected = true;
                    gridAu.CurrentRow.Selected = false;
                    mode = "Edit";
                    pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
                }
                else if (DialogResult.Yes == MessageBox.Show("Änderungen Speichern?", "Sie wechseln den Datensatz!", MessageBoxButtons.YesNoCancel))
                {
                    Save();
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                }
                else if (DialogResult.No == MessageBox.Show("Änderungen Speichern?", "Sie wechseln den Datensatz!", MessageBoxButtons.YesNoCancel))
                {
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                }
            }
            
        }

        private void Save() {
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "call AU_UPDATE(" +
                    gridAu.Rows[currentRow].Cells["AU_ID"].EditedFormattedValue
                    + ",'" +
                    gridAu.Rows[currentRow].Cells["AU_NR"].EditedFormattedValue
                    + "'," +
                    gridAu.Rows[currentRow].Cells["AU_KD_ID"].EditedFormattedValue
                    + ",'" +
                    gridAu.Rows[currentRow].Cells["AU_DATE"].EditedFormattedValue
                    + "')";


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSearch_MouseHover(object sender, EventArgs e)
        {
            pbSearch.Load("icons/icons8-suche-filled-50.png");
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Load("icons/icons8-suche-50.png");
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            where = " where AU_NR like '%" + tbSearch.Text + "%'" + " or KD_NR like '%" + tbSearch.Text + "%'" + " or KD_FIRMA like '%" + tbSearch.Text + "%'" + " or KD_VORNAME like '%" + tbSearch.Text + "%'" + " or KD_NACHNAME like '%" + tbSearch.Text + "%'";
            LoadAuftraege();
        }
    }
}
