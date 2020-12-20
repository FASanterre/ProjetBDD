using ProjetBDD.Forms;
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
<<<<<<< HEAD
<<<<<<< HEAD
        frmAbonnement frmAbonnement = new frmAbonnement();
=======
        Forms.GestionEmploye.frmSuppressionEmploye frmSuppressionEmploye = new Forms.GestionEmploye.frmSuppressionEmploye();
        Forms.GestionEmploye.frmAjoutEmploye frmAjoutEmploye = new Forms.GestionEmploye.frmAjoutEmploye();
        Forms.GestionEmploye.frmModificationEmploye frmModificationEmploye = new Forms.GestionEmploye.frmModificationEmploye();
>>>>>>> 7349b779b0c0eb90f909c2e0e002566543ceb2f7
=======
        frmAbonnement frmAbonnement = new frmAbonnement();
        Forms.GestionEmploye.frmSuppressionEmploye frmSuppressionEmploye = new Forms.GestionEmploye.frmSuppressionEmploye();
        Forms.GestionEmploye.frmAjoutEmploye frmAjoutEmploye = new Forms.GestionEmploye.frmAjoutEmploye();
        Forms.GestionEmploye.frmModificationEmploye frmModificationEmploye = new Forms.GestionEmploye.frmModificationEmploye();
>>>>>>> f40e29522cf7fa3bf8755f9354cd59fe4abb92d5
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            miGestionEmploye.Visible = false;
            miAbonnement.Visible = false;
            miReabonnement.Visible = false;
            miMAJAbonnes.Visible = false;
            miModifPrixDepenses.Visible = false;
            miInscriptionDepense.Visible = false;
            miInscriptionPartie.Visible = false;
            miVisualisation.Visible = false;

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

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f40e29522cf7fa3bf8755f9354cd59fe4abb92d5
        private void miAbonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbonnement.ShowDialog();
<<<<<<< HEAD
=======
=======
            this.Show();
        }
>>>>>>> f40e29522cf7fa3bf8755f9354cd59fe4abb92d5
        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjoutEmploye.ShowDialog();
            this.Show();
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppressionEmploye.ShowDialog();
            this.Show();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificationEmploye.ShowDialog();
<<<<<<< HEAD
>>>>>>> 7349b779b0c0eb90f909c2e0e002566543ceb2f7
=======
>>>>>>> f40e29522cf7fa3bf8755f9354cd59fe4abb92d5
            this.Show();
        }
    }
}
