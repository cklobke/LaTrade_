namespace LaTrade
{
    partial class Rechnungen
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
            this.gridAu = new System.Windows.Forms.DataGridView();
            this.AU_NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_KD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_KD_NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_NETTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAu
            // 
            this.gridAu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AU_NR,
            this.AU_KD,
            this.AU_KD_NR,
            this.AU_DATE,
            this.AU_NETTO,
            this.AU_BRUTTO,
            this.AU_PLZ});
            this.gridAu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridAu.Location = new System.Drawing.Point(0, 0);
            this.gridAu.Name = "gridAu";
            this.gridAu.Size = new System.Drawing.Size(1238, 150);
            this.gridAu.TabIndex = 1;
            // 
            // AU_NR
            // 
            this.AU_NR.HeaderText = "Auftragsnummer";
            this.AU_NR.Name = "AU_NR";
            this.AU_NR.ReadOnly = true;
            // 
            // AU_KD
            // 
            this.AU_KD.HeaderText = "Kunde";
            this.AU_KD.Name = "AU_KD";
            this.AU_KD.ReadOnly = true;
            // 
            // AU_KD_NR
            // 
            this.AU_KD_NR.HeaderText = "Kundennummer";
            this.AU_KD_NR.Name = "AU_KD_NR";
            this.AU_KD_NR.ReadOnly = true;
            // 
            // AU_DATE
            // 
            this.AU_DATE.HeaderText = "Datum";
            this.AU_DATE.Name = "AU_DATE";
            this.AU_DATE.ReadOnly = true;
            // 
            // AU_NETTO
            // 
            this.AU_NETTO.HeaderText = "Netto-Summe";
            this.AU_NETTO.Name = "AU_NETTO";
            this.AU_NETTO.ReadOnly = true;
            // 
            // AU_BRUTTO
            // 
            this.AU_BRUTTO.HeaderText = "Brutto-Summe";
            this.AU_BRUTTO.Name = "AU_BRUTTO";
            this.AU_BRUTTO.ReadOnly = true;
            // 
            // AU_PLZ
            // 
            this.AU_PLZ.HeaderText = "PLZ";
            this.AU_PLZ.Name = "AU_PLZ";
            this.AU_PLZ.ReadOnly = true;
            // 
            // Rechnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.gridAu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Rechnungen";
            this.Text = "Rechnungen";
            this.Load += new System.EventHandler(this.Rechnungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_KD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_KD_NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_NETTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_PLZ;
    }
}