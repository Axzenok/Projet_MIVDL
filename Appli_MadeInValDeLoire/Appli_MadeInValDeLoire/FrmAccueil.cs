﻿using System;
using System.Windows.Forms;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmAccueil : Form
    {
        #region coeur de code
        public FrmAccueil()
        {
            InitializeComponent();

            SetDoubleBuffer(PanelAccueil, true);
        }
        #endregion

        #region btn_click (actions simples)
        // Ouvre FrmDifficulte
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChoix difficulte = new FrmChoix();
            difficulte.ShowDialog();
            difficulte.Closed += (s, args) => this.Close();
        }

        // ferme l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // affiche la fenêtre des règles
        private void btnRegles_Click(object sender, EventArgs e)
        {
            FrmRegles regle = new FrmRegles();
            regle.ShowDialog();
        }
        #endregion

        #region Procédures
        static void SetDoubleBuffer(Control control, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                    null, control, new object[] { DoubleBuffered });

            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
