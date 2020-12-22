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
        frmAbonnement frmAbonnement = new frmAbonnement();
        Forms.GestionEmploye.frmSuppressionEmploye frmSuppressionEmploye = new Forms.GestionEmploye.frmSuppressionEmploye();
        Forms.GestionEmploye.frmAjoutEmploye frmAjoutEmploye = new Forms.GestionEmploye.frmAjoutEmploye();
        Forms.GestionEmploye.frmModificationEmploye frmModificationEmploye = new Forms.GestionEmploye.frmModificationEmploye();
        Forms.ModificationPrix.modificationPrixDepenses frmModifPrixDepenses = new Forms.ModificationPrix.modificationPrixDepenses();
        Forms.InscriptionPartie.frmInscrirePartie frmInscrirePartie = new Forms.InscriptionPartie.frmInscrirePartie();
        Forms.InscriptionDepenses.frmInscrireDepenses frmInscrireDepense = new Forms.InscriptionDepenses.frmInscrireDepenses();
        Forms.Rebonnement.frmReabonnement frmReabonnements = new Forms.Rebonnement.frmReabonnement();
        frmMAJAbonne frmMAJAbonne = new frmMAJAbonne();
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();

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
                    break;
                case 2:
                    miGestionEmploye.Visible = true;
                    miModifPrixDepenses.Visible = true;
                    miInscriptionDepense.Visible = true;
                    break;
                case 3:
                    miAbonnement.Visible = true;
                    miReabonnement.Visible = true;
                    miMAJAbonnes.Visible = true;
                    miModifPrixDepenses.Visible = true;
                    miInscriptionPartie.Visible = true;
                    miInscriptionDepense.Visible = true;
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

            var employe = (from unEmploye in context.Employes
                              where unEmploye.No == frmConnexion.ID
                              select new { unEmploye.Nom, unEmploye.Prenom }).First();

            var type = (from unType in context.TypesEmployes
                        where unType.No == frmConnexion.TypeEmploye
                        select new { unType.Description }).First();

            lblBonjour.Text = $"Bonjour {employe.Prenom} {employe.Nom} ({type.Description})";
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void miAbonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbonnement.ShowDialog();
            this.Show();
        }
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
            this.Show();
        }

        private void miModifPrixDepenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModifPrixDepenses.ShowDialog();
            this.Show();
        }

        private void miInscriptionPartie_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInscrirePartie.ShowDialog();
            this.Show();
        }

        private void miInscriptionDepense_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInscrireDepense.ShowDialog();
            this.Show();
        }

        private void miReabonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReabonnements.ShowDialog();
            this.Show();
        }

        private void miMAJAbonnes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMAJAbonne.ShowDialog();
            this.Show();
        }
    }
}
