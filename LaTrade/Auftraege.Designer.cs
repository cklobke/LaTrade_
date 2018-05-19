namespace LaTrade
{
    partial class Auftraege
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AU_NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_KD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_KD_NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_NETTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AU_PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AU_NR,
            this.AU_KD,
            this.AU_KD_NR,
            this.AU_DATE,
            this.AU_NETTO,
            this.AU_BRUTTO,
            this.AU_PLZ});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1383, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Auftraege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 560);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Auftraege";
            this.Text = "Auftraege";
            this.Load += new System.EventHandler(this.Auftraege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_KD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_KD_NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_NETTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AU_PLZ;
    }
}