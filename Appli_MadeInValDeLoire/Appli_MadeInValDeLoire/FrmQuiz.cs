using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lib_MadeInValDeLoire;
using MySql.Data.MySqlClient;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmQuiz : Form
    {
        #region Variables
        /* Type simple */
        private String _theme;
        private String _difficulte;
        private String _nomquiz;
        private String questionActuel;
        private int _nbquestions;
        private int _avancement;
        private int points;
        private Boolean repondQuestion = true;

        private int quizSelection;

        /* Provenant de la librairie */
        private Quiz quiz;
        private ConnexionBDD maConnexion;
        private MySqlConnection UneConnexion;

        /* Librairie aléatoire */
        private Random random = new Random();
        #endregion

        #region Listes
        private List<String> _nomQuiz = new List<String>();
        private List<String> _questionsListe = new List<String>();
        private List<String> bonnesReponses;
        private List<String> mauvaisesReponses;
        private List<String> choix;
        private List<Button> btnReponses;
        private List<PictureBox> pbxReponses;
        #endregion

        #region coeur de code
        public FrmQuiz(String difficulte, String theme)
        {
            InitializeComponent();

            // Instanciation des variables
            _difficulte = difficulte;
            _theme = theme;
            points = 0;
            _avancement = 0;
            _nbquestions = 15;

            // Instanciation d'une connexion et d'un quiz
            maConnexion = new ConnexionBDD();
            quiz = new Quiz();

            _nomQuiz = new List<String>();

            // Ouverture de la Connexion
            UneConnexion = maConnexion.OuvertureConnexion();

            if (UneConnexion != null)
            { 
                // Récupère les questions selon le quiz
                DataSet resultatQuestion = quiz.RecupQuestions(_theme, _difficulte, UneConnexion);
                for (int i = 0; i < resultatQuestion.Tables["questions"].Rows.Count; i++)
                {
                    _questionsListe.Add(resultatQuestion.Tables["questions"].Rows[i][0].ToString());
                }

                QuestionSuivant();
            }
        }
        #endregion

        #region btn_click (Actions simples)
        // Revient à l'accueil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccueil accueil = new FrmAccueil();
            accueil.ShowDialog();
            accueil.Closed += (s, args) => this.Close();
        }
        #endregion

        #region btn_click (Actions complexes)
        // Valide les réponses sélectionnés
        private void btnValidation_Click(object sender, EventArgs e)
        {
            Boolean raison = true;

            if (repondQuestion == true)
            {
                // Compte le nombre de choix
                for (int i = 0; (choix.Count()) > i; i++)
                {
                    // si "bonne reponse" est faux
                    if (!bonnesReponses.Contains(choix[i]))
                    {
                        raison = false;
                    }
                    // si "bonne reponse" est vrai
                    else if (bonnesReponses.Contains(choix[i]))
                    {
                        bonnesReponses.Remove(choix[i]);
                    }
                }

                // Si c'est Faux 
                if (bonnesReponses.Count() != 0)
                {
                    raison = false;
                    pbxMascotte.BackgroundImage = Properties.Resources.mascotteTriste;
                }

                // Compte un point si c'est bon
                if (raison == true)
                {
                    points++;
                    pbxMascotte.BackgroundImage = Properties.Resources.mascotteHeureux;
                }
                else
                {
                    pbxMascotte.BackgroundImage = Properties.Resources.mascotteTriste;
                }

                // affiche les Bonnes/Mauvaises Réponses
                foreach (Button btnReponse in btnReponses)
                {
                    btnReponse.Enabled = false;

                    // Vérifie si le bouton est Actif
                    if (btnReponse.Tag != null)
                    {
                        // si le réponse est bonne
                        if (Boolean.Parse(btnReponse.Tag.ToString()) == true)
                        {
                            btnReponse.BackgroundImage = Properties.Resources.bouton_quiz_1_allume;
                        }
                        // si la réponse est mauvaise
                        else if (Boolean.Parse(btnReponse.Tag.ToString()) == false)
                        {
                            btnReponse.BackgroundImage = Properties.Resources.bouton_quiz_1_eteint;
                        }
                    }
                }

                repondQuestion = false;
                btnValidation.Text = "Continuer";
            }

            else if (repondQuestion == false)
            {
                // sélectionne la question suivante et modifie le style des boutons en neutre
                if (_questionsListe.Count() >= 1 && _avancement != 15)
                {
                    QuestionSuivant();
                    btnValidation.Text = "Valider";
                    repondQuestion = true;
                    pbxMascotte.BackgroundImage = Properties.Resources.mascotteQuestion;

                    // affiche les Bonnes/Mauvaises Réponses
                    foreach (Button btnReponse in btnReponses)
                    {
                        btnReponse.Enabled = true;
                    }
                }
                // Sinon il affiche le résultat
                else
                {
                    this.Hide();
                    FrmResultat resultats = new FrmResultat(points, _nbquestions);
                    resultats.ShowDialog();
                    resultats.Closed += (s, args) => this.Close();
                }
            }
        }

        // Sélectionne la réponse cliquée (Voir Méthode AjoutChoix)
        private void btnReponse1_Click(object sender, EventArgs e)
        {
            AjoutChoix(btnReponse1);
        }

        private void btnReponse2_Click(object sender, EventArgs e)
        {
            AjoutChoix(btnReponse2);
        }

        private void btnReponse3_Click(object sender, EventArgs e)
        {
            AjoutChoix(btnReponse3);
        }

        private void btnReponse4_Click(object sender, EventArgs e)
        {
            AjoutChoix(btnReponse4);
        }
        #endregion

        #region Procédures
        // Ajoute la réponses sélectionné
        private void AjoutChoix(Button button)
        {
            // ajoute ou retire le choix du joueur
            if (!choix.Contains(button.Text))
            {
                choix.Add(button.Text);
                button.BackgroundImage = Properties.Resources.bouton_quiz_1_allume;
                button.ForeColor = Color.Black;
            }
            else
            {
                choix.Remove(button.Text);
                button.BackgroundImage = Properties.Resources.bouton_quiz_1;
                button.ForeColor = Color.White;
            }

            // vérifie si il peut valider sa réponse
            if (choix.Count() == 0)
            {
                btnValidation.Enabled = false;
                btnValidation.BackgroundImage = Properties.Resources.vide_bouton_eteint;
            }
            else
            {
                btnValidation.Enabled = true;
                btnValidation.BackgroundImage = Properties.Resources.vide_bouton_allume;
            }
        }

        // Passe à la question suivante
        private void QuestionSuivant()
        {
            btnValidation.Enabled = false;

            // donne la liste des boutons réponses
            btnReponses = new List<Button>
            {
                btnReponse1,
                btnReponse2,
                btnReponse3,
                btnReponse4
            };

            // donne la liste des images réponses
            pbxReponses = new List<PictureBox>
            {
                pbxReponse1,
                pbxReponse2,
                pbxReponse3,
                pbxReponse4
            };

            // donne le numéro de la question
            _avancement++;
            lblNbQuestions.Text = $"{_avancement} / {_nbquestions}";

            // met les boutons en neutre
            foreach (Button button in btnReponses)
            {
                button.BackgroundImage = Properties.Resources.bouton_quiz_1;
                button.ForeColor = Color.White;
                button.Visible = false;
            }

            foreach (PictureBox pbxImage in pbxReponses)
            {
                pbxImage.Visible = false;
            }

            btnValidation.BackgroundImage = Properties.Resources.vide_bouton_eteint;

            // instancie les listes
            bonnesReponses = new List<String>();
            mauvaisesReponses = new List<String>();
            choix = new List<String>();

            // choisit une question
            questionActuel = _questionsListe[random.Next(_questionsListe.Count)];
            // et la supprime 
            _questionsListe.Remove(questionActuel);
            // affiche la question
            lblQuestion.Text = questionActuel;

            // récupère la question
            DataSet resultatReponses = quiz.RecupReponses(questionActuel, UneConnexion);

            for (int i = 0; i < resultatReponses.Tables["reponses"].Rows.Count; i++)
            {
                // et met dans les boutons
                btnReponses[i].Visible = true;
                pbxReponses[i].Visible = true;
                btnReponses[i].Text = resultatReponses.Tables["reponses"].Rows[i][0].ToString();

                // Tag aussi les boutons par la réponse
                if (Boolean.Parse(resultatReponses.Tables["reponses"].Rows[i][1].ToString()) == true)
                {
                    bonnesReponses.Add(resultatReponses.Tables["reponses"].Rows[i][0].ToString());
                    btnReponses[i].Tag = resultatReponses.Tables["reponses"].Rows[i][1].ToString();
                }
                else if (Boolean.Parse(resultatReponses.Tables["reponses"].Rows[i][1].ToString()) == false)
                {
                    mauvaisesReponses.Add(resultatReponses.Tables["reponses"].Rows[i][0].ToString());
                    btnReponses[i].Tag = resultatReponses.Tables["reponses"].Rows[i][1].ToString();
                }
            }
        }
        #endregion
    }
}
