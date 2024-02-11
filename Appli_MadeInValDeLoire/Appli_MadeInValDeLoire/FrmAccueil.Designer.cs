namespace Appli_MadeInValDeLoire
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.pbxTitre = new System.Windows.Forms.PictureBox();
            this.btnRegles = new System.Windows.Forms.Button();
            this.pbxMascotte = new System.Windows.Forms.PictureBox();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.PanelAccueil = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.PanelAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxTitre
            // 
            this.pbxTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxTitre.BackColor = System.Drawing.Color.Transparent;
            this.pbxTitre.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.CyberSafe_titre_accueil;
            this.pbxTitre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.pbxTitre, 4);
            this.pbxTitre.Location = new System.Drawing.Point(240, 446);
            this.pbxTitre.Name = "pbxTitre";
            this.PanelAccueil.SetRowSpan(this.pbxTitre, 2);
            this.pbxTitre.Size = new System.Drawing.Size(492, 86);
            this.pbxTitre.TabIndex = 15;
            this.pbxTitre.TabStop = false;
            // 
            // btnRegles
            // 
            this.btnRegles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegles.BackColor = System.Drawing.Color.Transparent;
            this.btnRegles.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.regles_bouton;
            this.btnRegles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.btnRegles, 2);
            this.btnRegles.FlatAppearance.BorderSize = 0;
            this.btnRegles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegles.ForeColor = System.Drawing.Color.White;
            this.btnRegles.Location = new System.Drawing.Point(240, 753);
            this.btnRegles.Name = "btnRegles";
            this.btnRegles.Size = new System.Drawing.Size(234, 89);
            this.btnRegles.TabIndex = 4;
            this.btnRegles.UseVisualStyleBackColor = false;
            this.btnRegles.Click += new System.EventHandler(this.btnRegles_Click);
            // 
            // pbxMascotte
            // 
            this.pbxMascotte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMascotte.BackColor = System.Drawing.Color.Transparent;
            this.pbxMascotte.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.mascotte;
            this.pbxMascotte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.pbxMascotte, 3);
            this.pbxMascotte.Location = new System.Drawing.Point(738, 106);
            this.pbxMascotte.Name = "pbxMascotte";
            this.PanelAccueil.SetRowSpan(this.pbxMascotte, 7);
            this.pbxMascotte.Size = new System.Drawing.Size(859, 791);
            this.pbxMascotte.TabIndex = 13;
            this.pbxMascotte.TabStop = false;
            // 
            // btnCommencer
            // 
            this.btnCommencer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommencer.BackColor = System.Drawing.Color.Transparent;
            this.btnCommencer.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.jouer_bouton_allume;
            this.btnCommencer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.btnCommencer, 2);
            this.btnCommencer.FlatAppearance.BorderSize = 0;
            this.btnCommencer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCommencer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommencer.ForeColor = System.Drawing.Color.White;
            this.btnCommencer.Location = new System.Drawing.Point(304, 597);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(350, 150);
            this.btnCommencer.TabIndex = 2;
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.pbxLogo, 2);
            this.pbxLogo.Location = new System.Drawing.Point(304, 106);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(350, 334);
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.quitter_bouton;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAccueil.SetColumnSpan(this.btnQuitter, 2);
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(480, 753);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(252, 89);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvatar.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.avatar1;
            this.pbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAvatar.Location = new System.Drawing.Point(1486, 3);
            this.pbxAvatar.Name = "pbxAvatar";
            this.PanelAccueil.SetRowSpan(this.pbxAvatar, 2);
            this.pbxAvatar.Size = new System.Drawing.Size(111, 97);
            this.pbxAvatar.TabIndex = 16;
            this.pbxAvatar.TabStop = false;
            // 
            // PanelAccueil
            // 
            this.PanelAccueil.AutoSize = true;
            this.PanelAccueil.BackColor = System.Drawing.Color.Transparent;
            this.PanelAccueil.ColumnCount = 9;
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40759F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 574F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.PanelAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.PanelAccueil.Controls.Add(this.pbxAvatar, 8, 0);
            this.PanelAccueil.Controls.Add(this.btnQuitter, 4, 7);
            this.PanelAccueil.Controls.Add(this.pbxLogo, 3, 2);
            this.PanelAccueil.Controls.Add(this.pbxMascotte, 6, 2);
            this.PanelAccueil.Controls.Add(this.btnRegles, 2, 7);
            this.PanelAccueil.Controls.Add(this.pbxTitre, 2, 3);
            this.PanelAccueil.Controls.Add(this.btnCommencer, 3, 6);
            this.PanelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAccueil.Location = new System.Drawing.Point(0, 0);
            this.PanelAccueil.Name = "PanelAccueil";
            this.PanelAccueil.RowCount = 9;
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.71844F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.28156F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.PanelAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelAccueil.Size = new System.Drawing.Size(1600, 900);
            this.PanelAccueil.TabIndex = 17;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PanelAccueil);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenu à notre quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.PanelAccueil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxTitre;
        private System.Windows.Forms.TableLayoutPanel PanelAccueil;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.PictureBox pbxMascotte;
        private System.Windows.Forms.Button btnRegles;
    }
}

