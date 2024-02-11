namespace Appli_MadeInValDeLoire
{
    partial class FrmResultat
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCompte = new System.Windows.Forms.Button();
            this.pbxMascotte = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.lblGraphisme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(1060, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(389, 94);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Ton résultat : ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.reveniraccueil_bouton;
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.Location = new System.Drawing.Point(1182, 838);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(250, 50);
            this.btnAccueil.TabIndex = 10;
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScore.Location = new System.Drawing.Point(1043, 232);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(404, 152);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "100%";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCompte
            // 
            this.btnCompte.BackColor = System.Drawing.Color.Transparent;
            this.btnCompte.Enabled = false;
            this.btnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompte.ForeColor = System.Drawing.Color.White;
            this.btnCompte.Location = new System.Drawing.Point(1626, 42);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(176, 36);
            this.btnCompte.TabIndex = 15;
            this.btnCompte.Text = "Se connecter / S\'incrire";
            this.btnCompte.UseVisualStyleBackColor = false;
            this.btnCompte.Visible = false;
            // 
            // pbxMascotte
            // 
            this.pbxMascotte.BackColor = System.Drawing.Color.Transparent;
            this.pbxMascotte.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.mascotte;
            this.pbxMascotte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMascotte.Location = new System.Drawing.Point(60, 88);
            this.pbxMascotte.Name = "pbxMascotte";
            this.pbxMascotte.Size = new System.Drawing.Size(800, 800);
            this.pbxMascotte.TabIndex = 18;
            this.pbxMascotte.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.avatar1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1808, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.quitter_bouton;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1438, 838);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(150, 50);
            this.btnQuitter.TabIndex = 19;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCredits.Location = new System.Drawing.Point(1125, 403);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(252, 65);
            this.lblCredits.TabIndex = 20;
            this.lblCredits.Text = "Crédits";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProg
            // 
            this.lblProg.BackColor = System.Drawing.Color.Transparent;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProg.Location = new System.Drawing.Point(889, 483);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(384, 65);
            this.lblProg.TabIndex = 21;
            this.lblProg.Text = "Programmation";
            this.lblProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGraphisme
            // 
            this.lblGraphisme.BackColor = System.Drawing.Color.Transparent;
            this.lblGraphisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphisme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGraphisme.Location = new System.Drawing.Point(1241, 483);
            this.lblGraphisme.Name = "lblGraphisme";
            this.lblGraphisme.Size = new System.Drawing.Size(290, 65);
            this.lblGraphisme.TabIndex = 22;
            this.lblGraphisme.Text = "Graphisme";
            this.lblGraphisme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(956, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 65);
            this.label1.TabIndex = 23;
            this.label1.Text = "Petit Kalvin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(956, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 65);
            this.label2.TabIndex = 24;
            this.label2.Text = "Al Galmash Yahya";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1261, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 65);
            this.label3.TabIndex = 25;
            this.label3.Text = "Leïla Bayonne\r\n(Mascotte)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1261, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 65);
            this.label4.TabIndex = 26;
            this.label4.Text = "Elise Moreau\r\n(Logo et Icône)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1244, 711);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 111);
            this.label5.TabIndex = 27;
            this.label5.Text = "Natacha Boudin\r\n(Fond et Boutons)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGraphisme);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxMascotte);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResultat";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbxMascotte;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label lblGraphisme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}