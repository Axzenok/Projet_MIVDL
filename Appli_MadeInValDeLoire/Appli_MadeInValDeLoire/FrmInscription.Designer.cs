namespace Appli_MadeInValDeLoire
{
    partial class FrmInscription
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblConfirmMdp = new System.Windows.Forms.Label();
            this.txtConfirmMdp = new System.Windows.Forms.TextBox();
            this.mtxtDateNaisance = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin.Location = new System.Drawing.Point(98, 160);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(143, 157);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(235, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMdp.Location = new System.Drawing.Point(59, 186);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(78, 13);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de Passe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(143, 183);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(235, 20);
            this.txtMdp.TabIndex = 5;
            // 
            // lblConfirmMdp
            // 
            this.lblConfirmMdp.AutoSize = true;
            this.lblConfirmMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmMdp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConfirmMdp.Location = new System.Drawing.Point(12, 209);
            this.lblConfirmMdp.Name = "lblConfirmMdp";
            this.lblConfirmMdp.Size = new System.Drawing.Size(125, 13);
            this.lblConfirmMdp.TabIndex = 6;
            this.lblConfirmMdp.Text = "Confirmer Mot de Passe :";
            // 
            // txtConfirmMdp
            // 
            this.txtConfirmMdp.Location = new System.Drawing.Point(143, 209);
            this.txtConfirmMdp.Name = "txtConfirmMdp";
            this.txtConfirmMdp.PasswordChar = '*';
            this.txtConfirmMdp.Size = new System.Drawing.Size(235, 20);
            this.txtConfirmMdp.TabIndex = 7;
            // 
            // mtxtDateNaisance
            // 
            this.mtxtDateNaisance.Location = new System.Drawing.Point(143, 107);
            this.mtxtDateNaisance.Mask = "00/00/0000";
            this.mtxtDateNaisance.Name = "mtxtDateNaisance";
            this.mtxtDateNaisance.Size = new System.Drawing.Size(100, 20);
            this.mtxtDateNaisance.TabIndex = 8;
            this.mtxtDateNaisance.ValidatingType = typeof(System.DateTime);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(143, 133);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(235, 20);
            this.txtMail.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 81);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(235, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(143, 55);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(235, 20);
            this.txtNom.TabIndex = 11;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNom.Location = new System.Drawing.Point(102, 58);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrenom.Location = new System.Drawing.Point(88, 84);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 13;
            this.lblPrenom.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date de Naissance :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMail.Location = new System.Drawing.Point(105, 136);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail :";
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.Transparent;
            this.btnInscription.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.vide_bouton_allume;
            this.btnInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInscription.FlatAppearance.BorderSize = 0;
            this.btnInscription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInscription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInscription.Location = new System.Drawing.Point(203, 235);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(131, 64);
            this.btnInscription.TabIndex = 16;
            this.btnInscription.Text = "S\'inscrire";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.vide_bouton_allume;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 235);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(131, 64);
            this.btnRetour.TabIndex = 17;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 24);
            this.lblTitre.TabIndex = 18;
            this.lblTitre.Text = "Inscrivez-vous";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mtxtDateNaisance);
            this.Controls.Add(this.txtConfirmMdp);
            this.Controls.Add(this.lblConfirmMdp);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInscription";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblConfirmMdp;
        private System.Windows.Forms.TextBox txtConfirmMdp;
        private System.Windows.Forms.MaskedTextBox mtxtDateNaisance;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTitre;
    }
}