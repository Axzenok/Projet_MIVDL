namespace Appli_MadeInValDeLoire
{
    partial class FrmQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblNbQuestions = new System.Windows.Forms.Label();
            this.pbxMascotte = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValidation = new System.Windows.Forms.Button();
            this.btnReponse4 = new System.Windows.Forms.Button();
            this.btnReponse3 = new System.Windows.Forms.Button();
            this.btnReponse2 = new System.Windows.Forms.Button();
            this.btnReponse1 = new System.Windows.Forms.Button();
            this.pbxReponse1 = new System.Windows.Forms.PictureBox();
            this.pbxReponse3 = new System.Windows.Forms.PictureBox();
            this.pbxReponse2 = new System.Windows.Forms.PictureBox();
            this.pbxReponse4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestion.Location = new System.Drawing.Point(22, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1576, 116);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNbQuestions
            // 
            this.lblNbQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNbQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNbQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNbQuestions.Location = new System.Drawing.Point(601, 9);
            this.lblNbQuestions.Name = "lblNbQuestions";
            this.lblNbQuestions.Size = new System.Drawing.Size(426, 33);
            this.lblNbQuestions.TabIndex = 14;
            this.lblNbQuestions.Text = "Numéro question";
            this.lblNbQuestions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxMascotte
            // 
            this.pbxMascotte.BackColor = System.Drawing.Color.Transparent;
            this.pbxMascotte.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.mascotteQuestion;
            this.pbxMascotte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMascotte.Location = new System.Drawing.Point(12, 138);
            this.pbxMascotte.Name = "pbxMascotte";
            this.pbxMascotte.Size = new System.Drawing.Size(640, 733);
            this.pbxMascotte.TabIndex = 17;
            this.pbxMascotte.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.reveniraccueil_bouton;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Location = new System.Drawing.Point(12, 838);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(250, 50);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValidation
            // 
            this.btnValidation.BackColor = System.Drawing.Color.Transparent;
            this.btnValidation.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.vide_bouton_eteint;
            this.btnValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidation.FlatAppearance.BorderSize = 0;
            this.btnValidation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValidation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidation.ForeColor = System.Drawing.Color.White;
            this.btnValidation.Location = new System.Drawing.Point(983, 796);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(250, 75);
            this.btnValidation.TabIndex = 13;
            this.btnValidation.Text = "Valider";
            this.btnValidation.UseVisualStyleBackColor = false;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // btnReponse4
            // 
            this.btnReponse4.BackColor = System.Drawing.Color.Transparent;
            this.btnReponse4.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.bouton_quiz_1;
            this.btnReponse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReponse4.FlatAppearance.BorderSize = 0;
            this.btnReponse4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReponse4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReponse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReponse4.ForeColor = System.Drawing.Color.White;
            this.btnReponse4.Location = new System.Drawing.Point(608, 640);
            this.btnReponse4.Name = "btnReponse4";
            this.btnReponse4.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.btnReponse4.Size = new System.Drawing.Size(1000, 150);
            this.btnReponse4.TabIndex = 12;
            this.btnReponse4.Text = "Reponse 4";
            this.btnReponse4.UseVisualStyleBackColor = false;
            this.btnReponse4.Visible = false;
            this.btnReponse4.Click += new System.EventHandler(this.btnReponse4_Click);
            // 
            // btnReponse3
            // 
            this.btnReponse3.BackColor = System.Drawing.Color.Transparent;
            this.btnReponse3.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.bouton_quiz_1;
            this.btnReponse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReponse3.FlatAppearance.BorderSize = 0;
            this.btnReponse3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReponse3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReponse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReponse3.ForeColor = System.Drawing.Color.White;
            this.btnReponse3.Location = new System.Drawing.Point(608, 484);
            this.btnReponse3.Name = "btnReponse3";
            this.btnReponse3.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.btnReponse3.Size = new System.Drawing.Size(1000, 150);
            this.btnReponse3.TabIndex = 11;
            this.btnReponse3.Text = "Reponse 3";
            this.btnReponse3.UseVisualStyleBackColor = false;
            this.btnReponse3.Visible = false;
            this.btnReponse3.Click += new System.EventHandler(this.btnReponse3_Click);
            // 
            // btnReponse2
            // 
            this.btnReponse2.BackColor = System.Drawing.Color.Transparent;
            this.btnReponse2.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.bouton_quiz_1;
            this.btnReponse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReponse2.FlatAppearance.BorderSize = 0;
            this.btnReponse2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReponse2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReponse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReponse2.ForeColor = System.Drawing.Color.White;
            this.btnReponse2.Location = new System.Drawing.Point(608, 328);
            this.btnReponse2.Name = "btnReponse2";
            this.btnReponse2.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.btnReponse2.Size = new System.Drawing.Size(1000, 150);
            this.btnReponse2.TabIndex = 10;
            this.btnReponse2.Text = "Reponse 2";
            this.btnReponse2.UseVisualStyleBackColor = false;
            this.btnReponse2.Visible = false;
            this.btnReponse2.Click += new System.EventHandler(this.btnReponse2_Click);
            // 
            // btnReponse1
            // 
            this.btnReponse1.BackColor = System.Drawing.Color.Transparent;
            this.btnReponse1.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.bouton_quiz_1;
            this.btnReponse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReponse1.FlatAppearance.BorderSize = 0;
            this.btnReponse1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReponse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReponse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReponse1.ForeColor = System.Drawing.Color.White;
            this.btnReponse1.Location = new System.Drawing.Point(608, 172);
            this.btnReponse1.Name = "btnReponse1";
            this.btnReponse1.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.btnReponse1.Size = new System.Drawing.Size(1000, 150);
            this.btnReponse1.TabIndex = 9;
            this.btnReponse1.Text = "Reponse 1";
            this.btnReponse1.UseVisualStyleBackColor = false;
            this.btnReponse1.Visible = false;
            this.btnReponse1.Click += new System.EventHandler(this.btnReponse1_Click);
            // 
            // pbxReponse1
            // 
            this.pbxReponse1.BackColor = System.Drawing.Color.Transparent;
            this.pbxReponse1.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.A_questions;
            this.pbxReponse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxReponse1.Location = new System.Drawing.Point(1082, 147);
            this.pbxReponse1.Name = "pbxReponse1";
            this.pbxReponse1.Size = new System.Drawing.Size(50, 50);
            this.pbxReponse1.TabIndex = 18;
            this.pbxReponse1.TabStop = false;
            this.pbxReponse1.Tag = "btnReponse1";
            // 
            // pbxReponse3
            // 
            this.pbxReponse3.BackColor = System.Drawing.Color.Transparent;
            this.pbxReponse3.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.C_questions;
            this.pbxReponse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxReponse3.Location = new System.Drawing.Point(1082, 457);
            this.pbxReponse3.Name = "pbxReponse3";
            this.pbxReponse3.Size = new System.Drawing.Size(50, 50);
            this.pbxReponse3.TabIndex = 19;
            this.pbxReponse3.TabStop = false;
            this.pbxReponse3.Tag = "btnReponse3";
            // 
            // pbxReponse2
            // 
            this.pbxReponse2.BackColor = System.Drawing.Color.Transparent;
            this.pbxReponse2.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.B_questions;
            this.pbxReponse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxReponse2.Location = new System.Drawing.Point(1082, 301);
            this.pbxReponse2.Name = "pbxReponse2";
            this.pbxReponse2.Size = new System.Drawing.Size(50, 50);
            this.pbxReponse2.TabIndex = 20;
            this.pbxReponse2.TabStop = false;
            this.pbxReponse2.Tag = "btnReponse2";
            // 
            // pbxReponse4
            // 
            this.pbxReponse4.BackColor = System.Drawing.Color.Transparent;
            this.pbxReponse4.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.D_questions;
            this.pbxReponse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxReponse4.Location = new System.Drawing.Point(1082, 612);
            this.pbxReponse4.Name = "pbxReponse4";
            this.pbxReponse4.Size = new System.Drawing.Size(50, 50);
            this.pbxReponse4.TabIndex = 21;
            this.pbxReponse4.TabStop = false;
            this.pbxReponse4.Tag = "btnReponse4";
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appli_MadeInValDeLoire.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pbxReponse4);
            this.Controls.Add(this.pbxReponse2);
            this.Controls.Add(this.pbxReponse3);
            this.Controls.Add(this.pbxReponse1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblNbQuestions);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.btnReponse4);
            this.Controls.Add(this.btnReponse3);
            this.Controls.Add(this.btnReponse2);
            this.Controls.Add(this.btnReponse1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pbxMascotte);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascotte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReponse4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnReponse1;
        private System.Windows.Forms.Button btnReponse2;
        private System.Windows.Forms.Button btnReponse3;
        private System.Windows.Forms.Button btnReponse4;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.Label lblNbQuestions;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pbxMascotte;
        private System.Windows.Forms.PictureBox pbxReponse1;
        private System.Windows.Forms.PictureBox pbxReponse3;
        private System.Windows.Forms.PictureBox pbxReponse2;
        private System.Windows.Forms.PictureBox pbxReponse4;
    }
}