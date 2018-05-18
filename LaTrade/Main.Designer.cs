namespace LoginForm
{
    partial class Main
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
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAuftraege = new System.Windows.Forms.Panel();
            this.btnRechnungen = new System.Windows.Forms.Panel();
            this.btnKunden = new System.Windows.Forms.Panel();
            this.btnLieferungen = new System.Windows.Forms.Panel();
            this.btnLagerstand = new System.Windows.Forms.Panel();
            this.lblAuftraege = new System.Windows.Forms.Label();
            this.lblRechnungen = new System.Windows.Forms.Label();
            this.lblKundenstamm = new System.Windows.Forms.Label();
            this.lblLieferungen = new System.Windows.Forms.Label();
            this.lblLagerstand = new System.Windows.Forms.Label();
            this.pbSideMenu = new System.Windows.Forms.PictureBox();
            this.pbLagerstand = new System.Windows.Forms.PictureBox();
            this.pbLieferungen = new System.Windows.Forms.PictureBox();
            this.pbKunden = new System.Windows.Forms.PictureBox();
            this.pbRechnungen = new System.Windows.Forms.PictureBox();
            this.pbAuftraege = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            this.btnAuftraege.SuspendLayout();
            this.btnRechnungen.SuspendLayout();
            this.btnKunden.SuspendLayout();
            this.btnLieferungen.SuspendLayout();
            this.btnLagerstand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLagerstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLieferungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKunden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRechnungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuftraege)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(800, 52);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.pbSideMenu);
            this.pnlSideMenu.Controls.Add(this.btnLagerstand);
            this.pnlSideMenu.Controls.Add(this.btnLieferungen);
            this.pnlSideMenu.Controls.Add(this.btnKunden);
            this.pnlSideMenu.Controls.Add(this.btnRechnungen);
            this.pnlSideMenu.Controls.Add(this.btnAuftraege);
            this.pnlSideMenu.Controls.Add(this.splitter1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 52);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(236, 398);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(233, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 398);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnAuftraege
            // 
            this.btnAuftraege.Controls.Add(this.lblAuftraege);
            this.btnAuftraege.Controls.Add(this.pbAuftraege);
            this.btnAuftraege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuftraege.Location = new System.Drawing.Point(12, 64);
            this.btnAuftraege.Name = "btnAuftraege";
            this.btnAuftraege.Size = new System.Drawing.Size(210, 48);
            this.btnAuftraege.TabIndex = 1;
            this.btnAuftraege.MouseLeave += new System.EventHandler(this.btnAuftraege_MouseLeave);
            this.btnAuftraege.MouseHover += new System.EventHandler(this.btnAuftraege_MouseHover);
            // 
            // btnRechnungen
            // 
            this.btnRechnungen.Controls.Add(this.lblRechnungen);
            this.btnRechnungen.Controls.Add(this.pbRechnungen);
            this.btnRechnungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechnungen.Location = new System.Drawing.Point(12, 130);
            this.btnRechnungen.Name = "btnRechnungen";
            this.btnRechnungen.Size = new System.Drawing.Size(210, 48);
            this.btnRechnungen.TabIndex = 2;
            this.btnRechnungen.MouseLeave += new System.EventHandler(this.btnRechnungen_MouseLeave);
            this.btnRechnungen.MouseHover += new System.EventHandler(this.btnRechnungen_MouseHover);
            // 
            // btnKunden
            // 
            this.btnKunden.Controls.Add(this.lblKundenstamm);
            this.btnKunden.Controls.Add(this.pbKunden);
            this.btnKunden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKunden.Location = new System.Drawing.Point(12, 197);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(210, 48);
            this.btnKunden.TabIndex = 2;
            this.btnKunden.Paint += new System.Windows.Forms.PaintEventHandler(this.btnKunden_Paint);
            this.btnKunden.MouseLeave += new System.EventHandler(this.btnKunden_MouseLeave);
            this.btnKunden.MouseHover += new System.EventHandler(this.btnKunden_MouseHover);
            // 
            // btnLieferungen
            // 
            this.btnLieferungen.Controls.Add(this.lblLieferungen);
            this.btnLieferungen.Controls.Add(this.pbLieferungen);
            this.btnLieferungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLieferungen.Location = new System.Drawing.Point(12, 264);
            this.btnLieferungen.Name = "btnLieferungen";
            this.btnLieferungen.Size = new System.Drawing.Size(210, 48);
            this.btnLieferungen.TabIndex = 2;
            this.btnLieferungen.MouseLeave += new System.EventHandler(this.btnLieferungen_MouseLeave);
            this.btnLieferungen.MouseHover += new System.EventHandler(this.btnLieferungen_MouseHover);
            // 
            // btnLagerstand
            // 
            this.btnLagerstand.Controls.Add(this.lblLagerstand);
            this.btnLagerstand.Controls.Add(this.pbLagerstand);
            this.btnLagerstand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLagerstand.Location = new System.Drawing.Point(12, 330);
            this.btnLagerstand.Name = "btnLagerstand";
            this.btnLagerstand.Size = new System.Drawing.Size(210, 48);
            this.btnLagerstand.TabIndex = 3;
            this.btnLagerstand.MouseLeave += new System.EventHandler(this.btnLagerstand_MouseLeave);
            this.btnLagerstand.MouseHover += new System.EventHandler(this.btnLagerstand_MouseHover);
            // 
            // lblAuftraege
            // 
            this.lblAuftraege.AutoSize = true;
            this.lblAuftraege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuftraege.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuftraege.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAuftraege.Location = new System.Drawing.Point(12, 11);
            this.lblAuftraege.Name = "lblAuftraege";
            this.lblAuftraege.Size = new System.Drawing.Size(89, 24);
            this.lblAuftraege.TabIndex = 29;
            this.lblAuftraege.Text = "Aufträge";
            this.lblAuftraege.MouseLeave += new System.EventHandler(this.lblAuftraege_MouseLeave);
            this.lblAuftraege.MouseHover += new System.EventHandler(this.lblWeiter_MouseHover);
            // 
            // lblRechnungen
            // 
            this.lblRechnungen.AutoSize = true;
            this.lblRechnungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRechnungen.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechnungen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRechnungen.Location = new System.Drawing.Point(12, 10);
            this.lblRechnungen.Name = "lblRechnungen";
            this.lblRechnungen.Size = new System.Drawing.Size(121, 24);
            this.lblRechnungen.TabIndex = 30;
            this.lblRechnungen.Text = "Rechnungen";
            this.lblRechnungen.MouseLeave += new System.EventHandler(this.lblRechnungen_MouseLeave);
            this.lblRechnungen.MouseHover += new System.EventHandler(this.lblRechnungen_MouseHover);
            // 
            // lblKundenstamm
            // 
            this.lblKundenstamm.AutoSize = true;
            this.lblKundenstamm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKundenstamm.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundenstamm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKundenstamm.Location = new System.Drawing.Point(12, 10);
            this.lblKundenstamm.Name = "lblKundenstamm";
            this.lblKundenstamm.Size = new System.Drawing.Size(140, 24);
            this.lblKundenstamm.TabIndex = 31;
            this.lblKundenstamm.Text = "Kundenstamm";
            this.lblKundenstamm.MouseLeave += new System.EventHandler(this.lblKundenstamm_MouseLeave);
            this.lblKundenstamm.MouseHover += new System.EventHandler(this.lblKundenstamm_MouseHover);
            // 
            // lblLieferungen
            // 
            this.lblLieferungen.AutoSize = true;
            this.lblLieferungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLieferungen.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieferungen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLieferungen.Location = new System.Drawing.Point(12, 10);
            this.lblLieferungen.Name = "lblLieferungen";
            this.lblLieferungen.Size = new System.Drawing.Size(118, 24);
            this.lblLieferungen.TabIndex = 32;
            this.lblLieferungen.Text = "Lieferungen";
            this.lblLieferungen.MouseLeave += new System.EventHandler(this.lblLieferungen_MouseLeave);
            this.lblLieferungen.MouseHover += new System.EventHandler(this.lblLieferungen_MouseHover);
            // 
            // lblLagerstand
            // 
            this.lblLagerstand.AutoSize = true;
            this.lblLagerstand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLagerstand.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLagerstand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLagerstand.Location = new System.Drawing.Point(12, 11);
            this.lblLagerstand.Name = "lblLagerstand";
            this.lblLagerstand.Size = new System.Drawing.Size(135, 24);
            this.lblLagerstand.TabIndex = 33;
            this.lblLagerstand.Text = "Lagerbestand";
            this.lblLagerstand.MouseLeave += new System.EventHandler(this.lblLagerstand_MouseLeave);
            this.lblLagerstand.MouseHover += new System.EventHandler(this.lblLagerstand_MouseHover);
            // 
            // pbSideMenu
            // 
            this.pbSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSideMenu.Image = global::LaTrade.Properties.Resources.icons8_menü_50;
            this.pbSideMenu.Location = new System.Drawing.Point(187, 6);
            this.pbSideMenu.Name = "pbSideMenu";
            this.pbSideMenu.Size = new System.Drawing.Size(35, 34);
            this.pbSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSideMenu.TabIndex = 0;
            this.pbSideMenu.TabStop = false;
            this.pbSideMenu.MouseLeave += new System.EventHandler(this.pbSideMenu_MouseLeave);
            this.pbSideMenu.MouseHover += new System.EventHandler(this.pbSideMenu_MouseHover);
            // 
            // pbLagerstand
            // 
            this.pbLagerstand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLagerstand.Image = global::LaTrade.Properties.Resources.icons8_lagerhaus_50;
            this.pbLagerstand.Location = new System.Drawing.Point(166, 7);
            this.pbLagerstand.Name = "pbLagerstand";
            this.pbLagerstand.Size = new System.Drawing.Size(36, 34);
            this.pbLagerstand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLagerstand.TabIndex = 8;
            this.pbLagerstand.TabStop = false;
            this.pbLagerstand.MouseLeave += new System.EventHandler(this.pbLagerstand_MouseLeave);
            this.pbLagerstand.MouseHover += new System.EventHandler(this.pbLagerstand_MouseHover);
            // 
            // pbLieferungen
            // 
            this.pbLieferungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLieferungen.Image = global::LaTrade.Properties.Resources.icons8_versendet_50;
            this.pbLieferungen.Location = new System.Drawing.Point(166, 7);
            this.pbLieferungen.Name = "pbLieferungen";
            this.pbLieferungen.Size = new System.Drawing.Size(36, 34);
            this.pbLieferungen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLieferungen.TabIndex = 7;
            this.pbLieferungen.TabStop = false;
            this.pbLieferungen.MouseLeave += new System.EventHandler(this.pbLieferungen_MouseLeave);
            this.pbLieferungen.MouseHover += new System.EventHandler(this.pbLieferungen_MouseHover);
            // 
            // pbKunden
            // 
            this.pbKunden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbKunden.Image = global::LaTrade.Properties.Resources.icons8_benutzer_501;
            this.pbKunden.Location = new System.Drawing.Point(166, 7);
            this.pbKunden.Name = "pbKunden";
            this.pbKunden.Size = new System.Drawing.Size(36, 34);
            this.pbKunden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKunden.TabIndex = 6;
            this.pbKunden.TabStop = false;
            this.pbKunden.MouseLeave += new System.EventHandler(this.pbKunden_MouseLeave);
            this.pbKunden.MouseHover += new System.EventHandler(this.pbKunden_MouseHover);
            // 
            // pbRechnungen
            // 
            this.pbRechnungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRechnungen.Image = global::LaTrade.Properties.Resources.icons8_bestellung_50;
            this.pbRechnungen.Location = new System.Drawing.Point(166, 7);
            this.pbRechnungen.Name = "pbRechnungen";
            this.pbRechnungen.Size = new System.Drawing.Size(36, 34);
            this.pbRechnungen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRechnungen.TabIndex = 5;
            this.pbRechnungen.TabStop = false;
            this.pbRechnungen.MouseLeave += new System.EventHandler(this.pbRechnungen_MouseLeave);
            this.pbRechnungen.MouseHover += new System.EventHandler(this.pbRechnungen_MouseHover);
            // 
            // pbAuftraege
            // 
            this.pbAuftraege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAuftraege.Image = global::LaTrade.Properties.Resources.icons8_benutzer_menü_männlich_50;
            this.pbAuftraege.Location = new System.Drawing.Point(166, 6);
            this.pbAuftraege.Name = "pbAuftraege";
            this.pbAuftraege.Size = new System.Drawing.Size(36, 34);
            this.pbAuftraege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuftraege.TabIndex = 4;
            this.pbAuftraege.TabStop = false;
            this.pbAuftraege.MouseLeave += new System.EventHandler(this.pbAuftraege_MouseLeave);
            this.pbAuftraege.MouseHover += new System.EventHandler(this.pbAuftraege_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTopMenu);
            this.Name = "Main";
            this.Text = "LaTrade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.btnAuftraege.ResumeLayout(false);
            this.btnAuftraege.PerformLayout();
            this.btnRechnungen.ResumeLayout(false);
            this.btnRechnungen.PerformLayout();
            this.btnKunden.ResumeLayout(false);
            this.btnKunden.PerformLayout();
            this.btnLieferungen.ResumeLayout(false);
            this.btnLieferungen.PerformLayout();
            this.btnLagerstand.ResumeLayout(false);
            this.btnLagerstand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLagerstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLieferungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKunden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRechnungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuftraege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel btnLagerstand;
        private System.Windows.Forms.Panel btnLieferungen;
        private System.Windows.Forms.Panel btnKunden;
        private System.Windows.Forms.Panel btnRechnungen;
        private System.Windows.Forms.Panel btnAuftraege;
        private System.Windows.Forms.PictureBox pbSideMenu;
        private System.Windows.Forms.PictureBox pbLagerstand;
        private System.Windows.Forms.PictureBox pbLieferungen;
        private System.Windows.Forms.PictureBox pbKunden;
        private System.Windows.Forms.PictureBox pbRechnungen;
        private System.Windows.Forms.PictureBox pbAuftraege;
        private System.Windows.Forms.Label lblLagerstand;
        private System.Windows.Forms.Label lblLieferungen;
        private System.Windows.Forms.Label lblKundenstamm;
        private System.Windows.Forms.Label lblRechnungen;
        private System.Windows.Forms.Label lblAuftraege;
    }
}