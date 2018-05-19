namespace LaTrade
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlWeiter = new System.Windows.Forms.Panel();
            this.lblWeiter = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pnlNutzer = new System.Windows.Forms.Panel();
            this.lblNutzer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbNutzer = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlWeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.pnlNutzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Willkommen bei LaTrade!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPasswort
            // 
            this.tbPasswort.Enabled = false;
            this.tbPasswort.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswort.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbPasswort.Location = new System.Drawing.Point(46, 59);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(227, 27);
            this.tbPasswort.TabIndex = 2;
            this.tbPasswort.Text = "Passwort";
            this.tbPasswort.Visible = false;
            this.tbPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPasswort_KeyDown);
            this.tbPasswort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPasswort_KeyUp);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 49);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::LaTrade.Properties.Resources.icons8_winkel_links_50;
            this.pictureBox4.Location = new System.Drawing.Point(10, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pnlWeiter
            // 
            this.pnlWeiter.Controls.Add(this.lblWeiter);
            this.pnlWeiter.Controls.Add(this.pictureBox2);
            this.pnlWeiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlWeiter.Location = new System.Drawing.Point(46, 92);
            this.pnlWeiter.Name = "pnlWeiter";
            this.pnlWeiter.Size = new System.Drawing.Size(227, 33);
            this.pnlWeiter.TabIndex = 25;
            this.pnlWeiter.Click += new System.EventHandler(this.pnlWeiter_Click);
            this.pnlWeiter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.pnlWeiter.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.pnlWeiter.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // lblWeiter
            // 
            this.lblWeiter.AutoSize = true;
            this.lblWeiter.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWeiter.Location = new System.Drawing.Point(9, 6);
            this.lblWeiter.Name = "lblWeiter";
            this.lblWeiter.Size = new System.Drawing.Size(56, 19);
            this.lblWeiter.TabIndex = 28;
            this.lblWeiter.Text = "Weiter";
            this.lblWeiter.Click += new System.EventHandler(this.lblWeiter_Click);
            this.lblWeiter.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblWeiter.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::LaTrade.Properties.Resources.icons8_winkel_rechts_50;
            this.pictureBox2.Location = new System.Drawing.Point(189, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pnlNutzer
            // 
            this.pnlNutzer.Controls.Add(this.lblNutzer);
            this.pnlNutzer.Controls.Add(this.pictureBox3);
            this.pnlNutzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNutzer.Location = new System.Drawing.Point(46, 131);
            this.pnlNutzer.Name = "pnlNutzer";
            this.pnlNutzer.Size = new System.Drawing.Size(228, 33);
            this.pnlNutzer.TabIndex = 27;
            this.pnlNutzer.Click += new System.EventHandler(this.pnlNutzer_Click);
            this.pnlNutzer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.pnlNutzer.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.pnlNutzer.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // lblNutzer
            // 
            this.lblNutzer.AutoSize = true;
            this.lblNutzer.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutzer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNutzer.Location = new System.Drawing.Point(9, 6);
            this.lblNutzer.Name = "lblNutzer";
            this.lblNutzer.Size = new System.Drawing.Size(137, 19);
            this.lblNutzer.TabIndex = 29;
            this.lblNutzer.Text = "Benutzer anlegen";
            this.lblNutzer.Click += new System.EventHandler(this.lblNutzer_Click);
            this.lblNutzer.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.lblNutzer.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::LaTrade.Properties.Resources.icons8_benutzer_50;
            this.pictureBox3.Location = new System.Drawing.Point(189, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // tbNutzer
            // 
            this.tbNutzer.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNutzer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tbNutzer.Location = new System.Drawing.Point(45, 59);
            this.tbNutzer.Name = "tbNutzer";
            this.tbNutzer.Size = new System.Drawing.Size(228, 27);
            this.tbNutzer.TabIndex = 28;
            this.tbNutzer.Text = "Benutzer";
            this.tbNutzer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNutzer_KeyDown);
            this.tbNutzer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNutzer_KeyUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::LaTrade.Properties.Resources.icons8_sperren_2_50;
            this.pictureBox5.Location = new System.Drawing.Point(279, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LaTrade.Properties.Resources.icons8_sichtbar_50;
            this.pictureBox1.Location = new System.Drawing.Point(279, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(313, 179);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tbNutzer);
            this.Controls.Add(this.pnlNutzer);
            this.Controls.Add(this.pnlWeiter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPasswort);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaTrade - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlWeiter.ResumeLayout(false);
            this.pnlWeiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.pnlNutzer.ResumeLayout(false);
            this.pnlNutzer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Data.DataSet dataSet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlWeiter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel pnlNutzer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblWeiter;
        private System.Windows.Forms.Label lblNutzer;
        private System.Windows.Forms.TextBox tbNutzer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

