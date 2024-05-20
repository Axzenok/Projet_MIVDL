using System;
using System.Windows.Forms;
using Lib_MadeInValDeLoire;
using MySql.Data.MySqlClient;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmConnexion : Form
    {
        #region Variables
        // Variables pour la BDD
        ConnexionBDD maConnexion;
        MySqlConnection uneConnexion;

        // Variables pour l'utilisateur
        User utilisateur;
        #endregion

        #region Coeur de code
        public FrmConnexion()
        {
            InitializeComponent();

            // Instanciation des classes
            maConnexion = new ConnexionBDD();
            utilisateur = new User();

            // Ouverture de la Connexion
            uneConnexion = maConnexion.OuvertureConnexion();
        }
        #endregion

        #region btn_Click
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLogin.Text) ||
                !String.IsNullOrEmpty(txtMdp.Text) ||
                utilisateur.VerifierJoueur(uneConnexion, txtLogin.Text, txtMdp.Text) == 1)
            {
                this.Hide();
                FrmChoix choix = new FrmChoix();
                choix.ShowDialog();
                choix.Closed += (s, args) => this.Close();
            }
            else
            {
                lblTitre.Text = "Erreur Connexion";
            }
        }
        #endregion

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
