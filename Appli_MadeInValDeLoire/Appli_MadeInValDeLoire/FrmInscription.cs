using System;
using System.Windows.Forms;
using Lib_MadeInValDeLoire;
using MySql.Data.MySqlClient;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmInscription : Form
    {
        #region Variables
        // Variables pour la BDD
        ConnexionBDD maConnexion;
        MySqlConnection uneConnexion;

        // Variables pour l'utilisateur
        User utilisateur;
        #endregion

        #region Coeur de code
        public FrmInscription()
        {
            InitializeComponent();

            // Instanciation des classes
            maConnexion = new ConnexionBDD();
            utilisateur = new User();

            // Ouverture de la Connexion
            uneConnexion = maConnexion.OuvertureConnexion();
        }
        #endregion

        #region btn_Click (Action Simple)
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btn_Click (Action Complexe)
        // Vérifie les champs et inscrit si tout est bon
        private void btnInscription_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation des champs
                if (String.IsNullOrWhiteSpace(txtNom.Text) ||
                String.IsNullOrWhiteSpace(txtPrenom.Text) ||
                !mtxtDateNaisance.MaskFull && mtxtDateNaisance.MaskCompleted ||
                String.IsNullOrWhiteSpace(txtMail.Text) ||
                String.IsNullOrWhiteSpace(txtLogin.Text) ||
                String.IsNullOrWhiteSpace(txtMdp.Text))
                {
                    lblTitre.Text = "Veuillez remplir tous les champs !";
                }
                else
                {
                    if (txtMdp.Text == txtConfirmMdp.Text)
                    {
                        // Inscription de l'utilisateur
                        utilisateur.Inscription(uneConnexion, txtNom.Text, txtPrenom.Text,
                            DateTime.ParseExact(mtxtDateNaisance.Text, "dd/MM/yyyy", null), txtMail.Text, txtLogin.Text, txtMdp.Text);

                        lblTitre.Text = "Inscription réussie !";
                    }
                    else
                    {
                        lblTitre.Text = "Veuillez mettre le même mot de passe !";
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception
                MessageBox.Show("Une erreur s'est produite lors de l'inscription : " + ex.Message);
            }
        }
        #endregion
    }
}
