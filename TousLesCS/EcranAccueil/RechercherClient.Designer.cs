namespace EcranAccueil
{
    partial class RechercherClient
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxFixe = new System.Windows.Forms.TextBox();
            this.textBoxCommercial = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.CritèreRecherche = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.TelephoneFixe = new System.Windows.Forms.Label();
            this.TelephoneMobile = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.DateAjout = new System.Windows.Forms.Label();
            this.Commercial = new System.Windows.Forms.Label();
            this.dateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.buttonVendeur = new System.Windows.Forms.Button();
            this.buttonAcheteur = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(25, 59);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(25, 118);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenom.TabIndex = 1;
            // 
            // textBoxFixe
            // 
            this.textBoxFixe.Location = new System.Drawing.Point(25, 218);
            this.textBoxFixe.Name = "textBoxFixe";
            this.textBoxFixe.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixe.TabIndex = 2;
            // 
            // textBoxCommercial
            // 
            this.textBoxCommercial.Location = new System.Drawing.Point(25, 407);
            this.textBoxCommercial.Name = "textBoxCommercial";
            this.textBoxCommercial.Size = new System.Drawing.Size(100, 22);
            this.textBoxCommercial.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(25, 308);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(25, 263);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(100, 22);
            this.textBoxMobile.TabIndex = 6;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(25, 173);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodePostal.TabIndex = 7;
            // 
            // CritèreRecherche
            // 
            this.CritèreRecherche.AutoSize = true;
            this.CritèreRecherche.Location = new System.Drawing.Point(22, 9);
            this.CritèreRecherche.Name = "CritèreRecherche";
            this.CritèreRecherche.Size = new System.Drawing.Size(138, 17);
            this.CritèreRecherche.TabIndex = 8;
            this.CritèreRecherche.Text = "Critère de recherche";
            this.CritèreRecherche.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(48, 39);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(41, 17);
            this.Nom.TabIndex = 9;
            this.Nom.Text = "Nom:";
            this.Nom.Click += new System.EventHandler(this.label2_Click);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(48, 98);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(65, 17);
            this.Prenom.TabIndex = 10;
            this.Prenom.Text = "Prenom :";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Location = new System.Drawing.Point(32, 153);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(88, 17);
            this.CodePostal.TabIndex = 11;
            this.CodePostal.Text = "Code Postal:";
            this.CodePostal.Click += new System.EventHandler(this.label4_Click);
            // 
            // TelephoneFixe
            // 
            this.TelephoneFixe.AutoSize = true;
            this.TelephoneFixe.Location = new System.Drawing.Point(22, 198);
            this.TelephoneFixe.Name = "TelephoneFixe";
            this.TelephoneFixe.Size = new System.Drawing.Size(109, 17);
            this.TelephoneFixe.TabIndex = 12;
            this.TelephoneFixe.Text = "Telephone Fixe:";
            // 
            // TelephoneMobile
            // 
            this.TelephoneMobile.AutoSize = true;
            this.TelephoneMobile.Location = new System.Drawing.Point(12, 243);
            this.TelephoneMobile.Name = "TelephoneMobile";
            this.TelephoneMobile.Size = new System.Drawing.Size(125, 17);
            this.TelephoneMobile.TabIndex = 13;
            this.TelephoneMobile.Text = "Telephone Mobile:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(48, 288);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.label7_Click);
            // 
            // DateAjout
            // 
            this.DateAjout.AutoSize = true;
            this.DateAjout.Location = new System.Drawing.Point(30, 342);
            this.DateAjout.Name = "DateAjout";
            this.DateAjout.Size = new System.Drawing.Size(88, 17);
            this.DateAjout.TabIndex = 15;
            this.DateAjout.Text = "Date d\'ajout:";
            this.DateAjout.Click += new System.EventHandler(this.label8_Click);
            // 
            // Commercial
            // 
            this.Commercial.AutoSize = true;
            this.Commercial.Location = new System.Drawing.Point(22, 387);
            this.Commercial.Name = "Commercial";
            this.Commercial.Size = new System.Drawing.Size(118, 17);
            this.Commercial.TabIndex = 16;
            this.Commercial.Text = "Commercial affilié";
            this.Commercial.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimeAjout
            // 
            this.dateTimeAjout.Location = new System.Drawing.Point(25, 362);
            this.dateTimeAjout.Name = "dateTimeAjout";
            this.dateTimeAjout.Size = new System.Drawing.Size(200, 22);
            this.dateTimeAjout.TabIndex = 17;
            // 
            // buttonVendeur
            // 
            this.buttonVendeur.Location = new System.Drawing.Point(332, 39);
            this.buttonVendeur.Name = "buttonVendeur";
            this.buttonVendeur.Size = new System.Drawing.Size(273, 26);
            this.buttonVendeur.TabIndex = 18;
            this.buttonVendeur.Text = "Vendeur";
            this.buttonVendeur.UseVisualStyleBackColor = true;
            this.buttonVendeur.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAcheteur
            // 
            this.buttonAcheteur.Location = new System.Drawing.Point(602, 39);
            this.buttonAcheteur.Name = "buttonAcheteur";
            this.buttonAcheteur.Size = new System.Drawing.Size(316, 26);
            this.buttonAcheteur.TabIndex = 19;
            this.buttonAcheteur.Text = "Acheteur";
            this.buttonAcheteur.UseVisualStyleBackColor = true;
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(332, 98);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(586, 420);
            this.listBoxClient.TabIndex = 20;
            // 
            // RechercherClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 556);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.buttonAcheteur);
            this.Controls.Add(this.buttonVendeur);
            this.Controls.Add(this.dateTimeAjout);
            this.Controls.Add(this.Commercial);
            this.Controls.Add(this.DateAjout);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelephoneMobile);
            this.Controls.Add(this.TelephoneFixe);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.CritèreRecherche);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCommercial);
            this.Controls.Add(this.textBoxFixe);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "RechercherClient";
            this.Text = "RechercherClient";
            this.Load += new System.EventHandler(this.RechercherClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxFixe;
        private System.Windows.Forms.TextBox textBoxCommercial;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label CritèreRecherche;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label TelephoneFixe;
        private System.Windows.Forms.Label TelephoneMobile;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label DateAjout;
        private System.Windows.Forms.Label Commercial;
        private System.Windows.Forms.DateTimePicker dateTimeAjout;
        private System.Windows.Forms.Button buttonVendeur;
        private System.Windows.Forms.Button buttonAcheteur;
        private System.Windows.Forms.ListBox listBoxClient;
    }
}