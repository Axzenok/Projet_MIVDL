using System;
using System.Windows.Forms;
using Lib_MadeInValDeLoire;
using MySql.Data.MySqlClient;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmResultat : Form
    {
        #region Variables
        private Quiz quiz;
        private ConnexionBDD maConnexion;
        private MySqlConnection UneConnexion;
        private int points;
        #endregion

        #region Coeur du code
        public FrmResultat(int points, int nbquestions)
        {
            InitializeComponent();
            this.points = points;
            double pourcentage = ((double)points / nbquestions) * 100;
            lblScore.Text = $"{Math.Round(pourcentage)}%";

            if (pourcentage > 50)
            {
                pbxMascotte.BackgroundImage = Properties.Resources.mascotteHeureux;
            }
            else if (pourcentage <= 50)
            {
                pbxMascotte.BackgroundImage = Properties.Resources.mascotteTriste;
            }
        }
        #endregion

        #region btn_click (Actions simples)
        /// <summary>
        /// Evenement click pour fermer l'application
        /// </summary>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evenement click pour retourner à l'accueil
        /// </summary>
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccueil accueil = new FrmAccueil();
            accueil.ShowDialog();
            accueil.Closed += (s, args) => this.Close();
        }
        #endregion
    }
}
