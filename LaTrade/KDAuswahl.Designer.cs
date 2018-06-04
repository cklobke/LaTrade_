namespace LaTrade
{
    partial class KDAuswahl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridKd = new System.Windows.Forms.DataGridView();
            this.KD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_FIRMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_WOHNORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_ADRESSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD_PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridKd)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKd
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(203)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.gridKd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridKd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridKd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.gridKd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridKd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridKd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridKd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridKd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KD_ID,
            this.KD_NAME,
            this.KD_NR,
            this.KD_FIRMA,
            this.KD_WOHNORT,
            this.KD_ADRESSE,
            this.KD_PLZ});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(203)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridKd.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridKd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKd.EnableHeadersVisualStyles = false;
            this.gridKd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.gridKd.Location = new System.Drawing.Point(0, 81);
            this.gridKd.Name = "gridKd";
            this.gridKd.ReadOnly = true;
            this.gridKd.RowHeadersVisible = false;
            this.gridKd.Size = new System.Drawing.Size(896, 235);
            this.gridKd.TabIndex = 1;
            this.gridKd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridKd_MouseDoubleClick);
            // 
            // KD_ID
            // 
            this.KD_ID.DataPropertyName = "KD_ID";
            this.KD_ID.HeaderText = "KD_ID";
            this.KD_ID.Name = "KD_ID";
            this.KD_ID.ReadOnly = true;
            this.KD_ID.Visible = false;
            // 
            // KD_NAME
            // 
            this.KD_NAME.DataPropertyName = "KD_NAME";
            this.KD_NAME.HeaderText = "Name";
            this.KD_NAME.Name = "KD_NAME";
            this.KD_NAME.ReadOnly = true;
            this.KD_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // KD_NR
            // 
            this.KD_NR.DataPropertyName = "KD_NR";
            this.KD_NR.HeaderText = "Kunden-Nr.";
            this.KD_NR.Name = "KD_NR";
            this.KD_NR.ReadOnly = true;
            // 
            // KD_FIRMA
            // 
            this.KD_FIRMA.DataPropertyName = "KD_FIRMA";
            this.KD_FIRMA.HeaderText = "Firma";
            this.KD_FIRMA.Name = "KD_FIRMA";
            this.KD_FIRMA.ReadOnly = true;
            // 
            // KD_WOHNORT
            // 
            this.KD_WOHNORT.DataPropertyName = "KD_WOHNORT";
            this.KD_WOHNORT.HeaderText = "Wohnort";
            this.KD_WOHNORT.Name = "KD_WOHNORT";
            this.KD_WOHNORT.ReadOnly = true;
            // 
            // KD_ADRESSE
            // 
            this.KD_ADRESSE.DataPropertyName = "KD_ADRESSE";
            this.KD_ADRESSE.HeaderText = "Adresse";
            this.KD_ADRESSE.Name = "KD_ADRESSE";
            this.KD_ADRESSE.ReadOnly = true;
            // 
            // KD_PLZ
            // 
            this.KD_PLZ.DataPropertyName = "KD_PLZ";
            this.KD_PLZ.HeaderText = "PLZ";
            this.KD_PLZ.Name = "KD_PLZ";
            this.KD_PLZ.ReadOnly = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(118)))), ((int)(((byte)(130)))));
            this.pnlTop.Controls.Add(this.pbCancel);
            this.pnlTop.Controls.Add(this.pbSearch);
            this.pnlTop.Controls.Add(this.tbSearch);
            this.pnlTop.Controls.Add(this.pbSave);
            this.pnlTop.Controls.Add(this.pbEdit);
            this.pnlTop.Controls.Add(this.pbNew);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(896, 81);
            this.pnlTop.TabIndex = 2;
            // 
            // pbCancel
            // 
            this.pbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancel.Image = global::LaTrade.Properties.Resources.icons8_löschen_50;
            this.pbCancel.Location = new System.Drawing.Point(321, 17);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(50, 49);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancel.TabIndex = 11;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::LaTrade.Properties.Resources.icons8_suche_50;
            this.pbSearch.Location = new System.Drawing.Point(620, 17);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 49);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 10;
            this.pbSearch.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(687, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(184, 32);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pbSave
            // 
            this.pbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSave.Image = global::LaTrade.Properties.Resources.icons8_speichern_50;
            this.pbSave.Location = new System.Drawing.Point(227, 17);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(50, 49);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 8;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::LaTrade.Properties.Resources.icons8_bearbeiten_50;
            this.pbEdit.Location = new System.Drawing.Point(129, 17);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(50, 49);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdit.TabIndex = 6;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pbNew
            // 
            this.pbNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNew.Image = global::LaTrade.Properties.Resources.icons8_hinzufügen_50;
            this.pbNew.Location = new System.Drawing.Point(35, 17);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(50, 49);
            this.pbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNew.TabIndex = 5;
            this.pbNew.TabStop = false;
            this.pbNew.Click += new System.EventHandler(this.pbNew_Click);
            // 
            // KDAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 316);
            this.Controls.Add(this.gridKd);
            this.Controls.Add(this.pnlTop);
            this.Name = "KDAuswahl";
            this.Text = "KDAuswahl";
            this.Load += new System.EventHandler(this.KDAuswahl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKd)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_FIRMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_WOHNORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_ADRESSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD_PLZ;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbNew;
    }
}