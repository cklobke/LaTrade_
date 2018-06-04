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
    public partial class KDAuswahl : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        String connectionString;
        String SearchString;
        Auftraege ParentForm;
        string mode;
        public KDAuswahl(string KDSearch, Auftraege parent)
        {
            InitializeComponent();
            ParentForm = parent;
            SearchString = KDSearch;

        }

        private void KDAuswahl_Load(object sender, EventArgs e)
        {
            this.TopLevel = true;
            
            connectionString = "Server=192.168.178.59;Port=3306;" +
"Database=LaTrade; UID = LaTrade; Password =LaTrad3;SslMode=none ";
            GetKunden();
        }

        private void GetKunden()
        {
            connection = new MySqlConnection(connectionString);
            if (this.OpenConnection() == true)
            {

                mySqlDataAdapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "CALL KD_FIND (@STR)";
                cmd.Parameters.AddWithValue("@STR", SearchString);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

                DataSet DS = new DataSet();
                mySqlDataAdapter.SelectCommand = cmd;
                mySqlDataAdapter.Fill(DS);


                gridKd.DataSource = DS.Tables[0];

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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchString = tbSearch.Text;
            GetKunden();
        }

        private void gridKd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ParentForm.KDID = Convert.ToInt32(gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_ID"].EditedFormattedValue);
            this.Close();
        }

        private void pbNew_Click(object sender, EventArgs e)
        {
            if (mode != "Edit" && mode != "Delete" && mode != "Save" && mode != "New")
            {
                ChangeEditMode("New");
                AddKd();
            }
        }

        private void AddKd()
        {
            int newRowIndex;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "CALL KD_INSERT (@FIRMA, @NAME, @ADRESSE, @PLZ, @GEBURTSDATUM, @WOHNORT)";
                cmd.Parameters.AddWithValue("@FIRMA", "");
                cmd.Parameters.AddWithValue("@NAME", "");
                cmd.Parameters.AddWithValue("@ADRESSE", "");
                cmd.Parameters.AddWithValue("@PLZ", "");
                cmd.Parameters.AddWithValue("@GEBURTSDATUM", "");
                cmd.Parameters.AddWithValue("@WOHNORT", "");
                cmd.ExecuteNonQuery();
                this.CloseConnection();               
            }
            GetKunden();
            gridKd.ReadOnly = false;
            newRowIndex = gridKd.Rows.Count - 2;
            pbNew.Load("icons/icons8-hinzufügen-50.png");
            gridKd.FirstDisplayedScrollingRowIndex = newRowIndex;
            gridKd.Refresh();
            gridKd.CurrentCell = gridKd.Rows[newRowIndex].Cells[4];
            gridKd.Rows[newRowIndex].Selected = true;
        }

        private void ChangeEditMode(string newMode)
        {
            if (newMode == "Edit" && mode != "Edit")
            {
                pbEdit.Load("icons/icons8-bearbeiten-filled-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                mode = "Edit";
            }
            else if (newMode == "Cancel" && mode != "Cancel")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-filled-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                mode = "Cancel";
            }
            else if (newMode == "Save" && mode != "Save")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-filled-50.png");
                mode = "Save";
            }
            else if (newMode == "New" && mode != "New")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-filled-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                mode = "New";
            }
            else if (newMode == "None" && mode != "None")
            {
                pbEdit.Load("icons/icons8-bearbeiten-50.png");
                pbCancel.Load("icons/icons8-löschen-50.png");
                pbNew.Load("icons/icons8-hinzufügen-50.png");
                pbSave.Load("icons/icons8-speichern-50.png");
                mode = "None";
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (mode != "New" && mode != "Delete" && mode != "Save" && mode != "Edit")
            {
                ChangeEditMode("Edit");
                gridKd.ReadOnly = false;
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            ChangeEditMode("Cancel");
            gridKd.ReadOnly = true;
            GetKunden();
            ChangeEditMode("None");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (mode == "Edit" | mode == "New")
            {
                Save();
                ChangeEditMode("Save");
                gridKd.ReadOnly = true;
                ChangeEditMode("None");
            }
        }

        private void Save()
        {
            connection = new MySqlConnection(connectionString);
            if (mode == "New")
            {
                if (DialogResult.Yes == MessageBox.Show("Datensatz anlegen??", "Speichern", MessageBoxButtons.YesNoCancel))
                {
                    if (this.OpenConnection() == true)
                    {

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "CALL KD_UPDATE (@ID, @FIRMA, @NAME, @ADRESSE, @PLZ, @GEBURTSDATUM, @WOHNORT)";
                        cmd.Parameters.AddWithValue("@ID", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_ID"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@FIRMA", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_FIRMA"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@NAME", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_NAME"].Value);
                        cmd.Parameters.AddWithValue("@ADRESSE", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_ADRESSE"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@PLZ", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_PLZ"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@GEBURTSDATUM", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_GEBURTSDATUM"].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@WOHNORT", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_WOHNORT"].EditedFormattedValue);
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
                    cmd.CommandText = "CALL KD_UPDATE (@ID, @FIRMA, @NAME, @ADRESSE, @PLZ, @GEBURTSDATUM, @WOHNORT)";
                    cmd.Parameters.AddWithValue("@ID", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_ID"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@FIRMA", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_FIRMA"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@NAME", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_NAME"].Value);
                    cmd.Parameters.AddWithValue("@ADRESSE", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_ADRESSE"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@PLZ", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_PLZ"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@GEBURTSDATUM", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_GEBURTSDATUM"].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@WOHNORT", gridKd.Rows[gridKd.CurrentRow.Index].Cells["KD_WOHNORT"].EditedFormattedValue);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
        }
    }

    }
