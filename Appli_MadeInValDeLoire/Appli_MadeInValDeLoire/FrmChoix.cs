using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Lib_MadeInValDeLoire;
using MySql.Data.MySqlClient;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmChoix : Form
    {
        #region variables
        // Variables simples
        private String _difficulte;
        private String _theme;

        // Variables pour la BDD
        ConnexionBDD maConnexion;
        MySqlConnection uneConnexion;

        // Variables de la librairie
        Quiz quiz;
        #endregion

        #region Liste
        private List<Button> boutonsTheme;
        private List<Button> boutonsDifficulte;
        #endregion

        #region coeur de code
        public FrmChoix()
        {
            InitializeComponent();

            // Instanciation d'une connexion et d'un quiz
            maConnexion = new ConnexionBDD();
            quiz = new Quiz();

            // Préparation des listes
            boutonsTheme = new List<Button>()
            {
                btnTheme1,
                btnTheme2,
                btnTheme3,
                btnTheme4,
                btnTheme5,
                btnTheme6
            };

            boutonsDifficulte = new List<Button>()
            {
                btnDifficile,
                btnFacile,
                btnMoyen,
            };

            // Ouverture de la Connexion
            uneConnexion = maConnexion.OuvertureConnexion();

            if (uneConnexion != null)
            {
                // Récupère les thèmes
                DataSet resultatTheme = quiz.RecupThemes(uneConnexion);

                for (int i = 0; i < resultatTheme.Tables["theme"].Rows.Count; i++)
                {
                    // et met dans les boutons
                    boutonsTheme[i].Visible = true;
                    boutonsTheme[i].Text = resultatTheme.Tables["theme"].Rows[i][0].ToString();
                }

                // Récupère les difficultés
                DataSet resultatDifficute = quiz.RecupNiveauDifficulte(uneConnexion);

                for (int i = 0; i < resultatDifficute.Tables["niveaudifficulte"].Rows.Count; i++)
                {
                    // et met dans les boutons
                    boutonsDifficulte[i].Visible = true;
                    boutonsDifficulte[i].Tag = resultatDifficute.Tables["niveaudifficulte"].Rows[i][0].ToString();
                }
            }

            maConnexion.FermetureConnexion(uneConnexion);
        }
        #endregion

        #region btn_click (Actions simples)
        // Choisit la difficulté facile
        private void btnFacile_Click(object sender, EventArgs e)
        {
            RecupDifficulte(btnFacile);

            btnFacile.BackgroundImage = Properties.Resources.facile_bouton_allume;
            btnMoyen.BackgroundImage = Properties.Resources.moyen_bouton_eteint;
            btnDifficile.BackgroundImage = Properties.Resources.difficile_bouton_eteint;
        }

        // Choisit la difficulté moyenne
        private void btnMoyen_Click(object sender, EventArgs e)
        {
            RecupDifficulte(btnMoyen);

            btnFacile.BackgroundImage = Properties.Resources.facile_bouton_eteint;
            btnMoyen.BackgroundImage = Properties.Resources.moyen_bouton_allume;
            btnDifficile.BackgroundImage = Properties.Resources.difficile_bouton_eteint;
        }

        // Choisit la difficulté difficile
        private void btnDifficile_Click(object sender, EventArgs e)
        {
            RecupDifficulte(btnDifficile);

            btnFacile.BackgroundImage = Properties.Resources.facile_bouton_eteint;
            btnMoyen.BackgroundImage = Properties.Resources.moyen_bouton_eteint;
            btnDifficile.BackgroundImage = Properties.Resources.difficile_bouton_allume;
        }

        // Choisit le thème selon le bouton clické
        private void btnTheme1_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme1);
        }

        private void btnTheme2_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme2);
        }

        private void btnTheme3_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme3);
        }

        private void btnTheme4_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme4);
        }

        private void btnTheme5_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme5);
        }

        private void btnTheme6_Click(object sender, EventArgs e)
        {
            RecupTheme(btnTheme6);
        }

        // Commence le quiz avec les infos demandés
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuiz quiz = new FrmQuiz(_difficulte, _theme);
            quiz.ShowDialog();
            quiz.Closed += (s, args) => this.Close();
        }

        // Revient à l'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccueil accueil = new FrmAccueil();
            accueil.ShowDialog();
            accueil.Closed += (s, args) => this.Close();
        }
        #endregion

        #region Procédures
        // vérifie si l'utilisateur a bien choisi une difficulté et un thème
        private void VerifSelectionInfos()
        {
            if (_difficulte != null && _theme != null)
            {
                btnCommencer.Enabled = true;
                btnCommencer.BackgroundImage = Properties.Resources.jouer_bouton_allume;
            }
        }

        // Récupère le thème sélectionné et affiche le choix
        private void RecupTheme(Button boutonSelectionne)
        {
            _theme = boutonSelectionne.Text;

            foreach (Button boutonTheme in boutonsTheme) 
            {
                if (boutonTheme.Text == _theme)
                {
                    boutonTheme.BackgroundImage = Properties.Resources.vide_bouton_allume;
                }
                else
                {
                    boutonTheme.BackgroundImage = Properties.Resources.vide_bouton_eteint;
                }
            }

            VerifSelectionInfos();
        }

        // modifie la difficulté sélectionnée
        private void RecupDifficulte(Button boutonSelectionne)
        {
            _difficulte = boutonSelectionne.Tag.ToString();

            VerifSelectionInfos();
        }
        #endregion
    }
}
