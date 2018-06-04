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
using LaTrade;

namespace LaTrade
{
    public partial class Auftraege : LTForm
    {
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        private Main main;
        DataSet DS;
        private string mode;
        public string Kunde;
        String connectionString;
        int currentRow;
        public int KDID;

        public Auftraege(Main parent)
        {
            main = parent;
            InitializeComponent();
        }

        private void Auftraege_Load(object sender, EventArgs e)
        {
            gridAu.Dock = DockStyle.Fill;
            gridAu.Font = new Font("Bahnschrift Light", 20);
            gridAu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml(main.Side_Menu_Color);
            tbSearch.BackColor = System.Drawing.ColorTranslator.FromHtml(main.Side_Menu_Color);
            gridAu.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(main.Btn_Color);
            gridAu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(main.Back_Color);
            gridAu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(main.Side_Menu_Color);
            gridAu.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(main.Side_Menu_Color);
            gridAu.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml(main.Btn_Alt_Color);
            gridAu.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml(main.Btn_Alt_Color);
            connectionString = "Server=192.168.178.59;Port=3306;" +
           "Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ";

            LoadAuftraege();
        }

        private void LoadAuftraege() {
            connection = new MySqlConnection(connectionString);
            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "CALL AU_GET (@STR)";
                cmd.Parameters.AddWithValue("@STR", tbSearch.Text);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

                DS = new DataSet();
                mySqlDataAdapter.SelectCommand = cmd;
                mySqlDataAdapter.Fill(DS);


                gridAu.DataSource = DS.Tables[0];

                this.CloseConnection();
            }
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
                ChangeEditMode("New");
                AddAu();             
            }
        }

        private void AddAu() {
            int newRowIndex;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
               
                cmd.Connection = connection;
                cmd.CommandText = "CALL AU_INSERT (@AUNR, @AUKDID, @AUTYPE)";
                cmd.Parameters.AddWithValue("@AUNR", "");
                cmd.Parameters.AddWithValue("@AUKDID", "");
                cmd.Parameters.AddWithValue("@AUTYPE", "");
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            LoadAuftraege();
            gridAu.ReadOnly = false;
            newRowIndex = gridAu.Rows.Count - 2;
            pbNew.Load("icons/icons8-hinzufügen-50.png");
            gridAu.FirstDisplayedScrollingRowIndex = newRowIndex;
            gridAu.Refresh();
            gridAu.CurrentCell = gridAu.Rows[newRowIndex].Cells[4];
            gridAu.Rows[newRowIndex].Selected = true;
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (mode != "New" && mode != "Delete" && mode != "Save" && mode != "Edit")
            {
                ChangeEditMode("Edit");      
                gridAu.ReadOnly = false;
                Kunde = gridAu.Rows[currentRow].Cells["KD_NAME"].FormattedValue.ToString();
            }            
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (mode != "Save" && mode != "Edit" && mode != "New")
            ChangeEditMode("Delete");
            DeleteAu();
            ChangeEditMode("None");
            LoadAuftraege();
        }

        private void DeleteAu() {
            connection = new MySqlConnection(connectionString);

            if (DialogResult.Yes == MessageBox.Show("Auftrag wirklich löschen?", "Datensatz löschen", MessageBoxButtons.YesNoCancel))
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "CALL AU_DELETE (@AU_ID)";
                    cmd.Parameters.AddWithValue("@AU_ID", gridAu.CurrentRow.Cells["AU_ID"].Value);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();

                    this.CloseConnection();
                }
            }
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (mode == "Edit" | mode == "New") {
                Save();
                ChangeEditMode("Save");
                gridAu.ReadOnly = true;
                ChangeEditMode("None");  
            }            
        }

        private void gridAu_SelectionChanged(object sender, EventArgs e)
        {
            string oldMode;
            DialogResult dResult;
            currentRow = gridAu.CurrentRow.Index;
            if (mode == "Edit" | mode == "New")
            {
                oldMode = mode;
                dResult = MessageBox.Show("Änderungen Speichern?", "Sie wechseln den Datensatz!", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Cancel == dResult)
                {
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                    gridAu.Rows[currentRow].Selected = true;
                    gridAu.CurrentRow.Selected = false;
                    mode = oldMode;
                    pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
                }
                else if (DialogResult.Yes == dResult)
                {
                    Save();
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                    gridAu.ReadOnly = true;
                }
                else if (DialogResult.No == dResult)
                {
                    mode = "None";
                    pbEdit.Load("icons/icons8-bearbeiten-50.png");
                    gridAu.ReadOnly = true;
                }
            }
            
        }

        private int CheckCustomer(string s) {
            connection = new MySqlConnection(connectionString);
            int result = 0;
            if (this.OpenConnection() == true)
            {

                mySqlDataAdapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "CALL KD_FIND (@NAME)";
                cmd.Parameters.AddWithValue("@NAME", s);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

                DS = new DataSet();
                mySqlDataAdapter.SelectCommand = cmd;
                mySqlDataAdapter.Fill(DS);

                if ((DS.Tables[0].Rows.Count > 1) || (DS.Tables[0].Rows.Count == 0))
                {
                    KDAuswahl kDAuswahl = new KDAuswahl(s, this);
                    kDAuswahl.ShowDialog();
                    result = KDID;
                }
                else
                {
                    KDID = Convert.ToInt32(DS.Tables[0].Rows[0]["KD_ID"]);
                    result = KDID;
                }
                
                this.CloseConnection();
                
            }
            return KDID;
        }

        private void Save() {
            connection = new MySqlConnection(connectionString);

            
                if (Kunde != gridAu.Rows[currentRow].Cells["KD_NAME"].EditedFormattedValue.ToString())
                {
                    CheckCustomer(gridAu.Rows[currentRow].Cells["KD_NAME"].EditedFormattedValue.ToString());
                }
            if (mode == "New")
            {
                if (DialogResult.Yes == MessageBox.Show("Datensatz anlegen??", "Speichern", MessageBoxButtons.YesNoCancel))
                {
                    if (this.OpenConnection() == true)
                    {

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "CALL AU_UPDATE (@AU_ID, @AU_NR, @AU_KD_ID, @AU_DATE)";
                        cmd.Parameters.AddWithValue("@AU_ID", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_ID"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@AU_NR", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_NR"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@AU_KD_ID", gridAu.Rows[gridAu.CurrentRow.Index].Cells["KD_FIRMA"].Value);
                        cmd.Parameters.AddWithValue("@AU_DATE", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_DATE"].EditedFormattedValue);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
            }
            else if (mode == "Edit")
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "CALL AU_UPDATE (@AU_ID, @AU_NR, @AU_KD_ID, @AU_DATE)";
                    cmd.Parameters.AddWithValue("@AU_ID", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_ID"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@AU_NR", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_NR"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@AU_KD_ID", KDID);
                    cmd.Parameters.AddWithValue("@AU_DATE", gridAu.Rows[gridAu.CurrentRow.Index].Cells["AU_DATE"].EditedFormattedValue);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
        }

        private void ChangeEditMode(string newMode) {
            if (newMode == "Edit" && mode != "Edit") {
                pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                mode = "Edit";
            }
            else if (newMode == "Cancel" && mode != "Cancel")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-filled-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                mode = "Cancel";
            }
            else if (newMode == "Save" && mode != "Save")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-filled-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                mode = "Save";
            }
            else if (newMode == "Delete" && mode != "Delete")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-filled-50.png");
                mode = "Delete";
            }
            else if (newMode == "New" && mode != "New")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-filled-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                mode = "New";
            }
            else if (newMode == "None" && mode != "None")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                pbDelete.Load("icons/icons8-unwiederuflich-löschen-50.png");
                mode = "None";
            }
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
            LoadAuftraege();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAuftraege();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pbCancel.Load("icons/icons8-löschen-filled-50.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbCancel.Load("icons/icons8-löschen-50.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeEditMode("Cancel");
            gridAu.ReadOnly = true;
            LoadAuftraege();
            ChangeEditMode("None");
        }

    }

    public class Kunde {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PLZ { get; set; }
        public string Firma { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Wohnort { get; set; }
        public string Adresse { get; set; }
        public DateTime Geburtsdatum { get; set; }
    }
}
