namespace LoginForm
{
    partial class Register
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.cbShowPasswort = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdminPasswort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNutzername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(71, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Passwort anzeigen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vorname";
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(147, 49);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(113, 24);
            this.tbVorname.TabIndex = 2;
            this.tbVorname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVorname_KeyDown);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(71, 238);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(127, 31);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Registrieren";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nachname";
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(147, 88);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(113, 24);
            this.tbNachname.TabIndex = 3;
            this.tbNachname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNachname_KeyDown);
            // 
            // tbPasswort
            // 
            this.tbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswort.Location = new System.Drawing.Point(147, 130);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(113, 24);
            this.tbPasswort.TabIndex = 4;
            this.tbPasswort.UseSystemPasswordChar = true;
            this.tbPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPasswort_KeyDown);
            // 
            // cbShowPasswort
            // 
            this.cbShowPasswort.AutoSize = true;
            this.cbShowPasswort.Location = new System.Drawing.Point(196, 208);
            this.cbShowPasswort.Name = "cbShowPasswort";
            this.cbShowPasswort.Size = new System.Drawing.Size(15, 14);
            this.cbShowPasswort.TabIndex = 19;
            this.cbShowPasswort.UseVisualStyleBackColor = true;
            this.cbShowPasswort.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Admin Passwort";
            // 
            // tbAdminPasswort
            // 
            this.tbAdminPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdminPasswort.Location = new System.Drawing.Point(147, 12);
            this.tbAdminPasswort.Name = "tbAdminPasswort";
            this.tbAdminPasswort.Size = new System.Drawing.Size(113, 24);
            this.tbAdminPasswort.TabIndex = 1;
            this.tbAdminPasswort.UseSystemPasswordChar = true;
            this.tbAdminPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdminPasswort_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Passwort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nutzername";
            // 
            // tbNutzername
            // 
            this.tbNutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNutzername.Location = new System.Drawing.Point(147, 166);
            this.tbNutzername.Name = "tbNutzername";
            this.tbNutzername.Size = new System.Drawing.Size(113, 24);
            this.tbNutzername.TabIndex = 22;
            this.tbNutzername.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Registrieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNutzername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAdminPasswort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbShowPasswort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.btnReg);
            this.Name = "Register";
            this.Text = "Registrieren";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.CheckBox cbShowPasswort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAdminPasswort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNutzername;
        private System.Windows.Forms.Button button1;
    }
}