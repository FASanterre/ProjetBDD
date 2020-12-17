using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDD
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            switch (frmConnexion.TypeEmploye)
            {
                case 1:
                    miGestionEmploye.Visible = true;
                    miAbonnement.Visible = true;
                    miReabonnement.Visible = true;
                    miMAJAbonnes.Visible = true;
                    miModifPrixDepenses.Visible = true;
                    miInscriptionDepense.Visible = true;
                    miInscriptionPartie.Visible = true;
                    miVisualisation.Visible = true;
                    break;
                case 2:
                    miGestionEmploye.Visible = true;
                    miModifPrixDepenses.Visible = true;
                    miInscriptionDepense.Visible = true;
                    miVisualisation.Visible = true;
                    break;
                case 3:
                    miAbonnement.Visible = true;
                    miReabonnement.Visible = true;
                    miMAJAbonnes.Visible = true;
                    miModifPrixDepenses.Visible = true;
                    miInscriptionPartie.Visible = true;
                    miInscriptionDepense.Visible = true;
                    miVisualisation.Visible = true;
                    break;
                case 4:
                    miAbonnement.Visible = true;
                    miReabonnement.Visible = true;
                    miMAJAbonnes.Visible = true;
                    miInscriptionPartie.Visible = true;
                    break;
                case 5:
                    miInscriptionPartie.Visible = true;
                    miInscriptionDepense.Visible = true;
                    break;
                case 6:
                    miInscriptionPartie.Visible = true;
                    miInscriptionDepense.Visible = true;
                    break;
                case 7:
                    miInscriptionPartie.Visible = true;
                    miInscriptionDepense.Visible = true;
                    break;
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
