using System;
using System.Windows.Forms;

namespace Appli_MadeInValDeLoire
{
    public partial class FrmRegles : Form
    {
        #region Coeur du code
        public FrmRegles()
        {
            InitializeComponent();
        }
        #endregion

        #region btn_click (Actions simples)
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
