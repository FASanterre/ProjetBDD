using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDD.Forms.InscriptionDepenses
{
    public partial class frmFacture : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public string nomAbonnement;
        public string noAbonnement;
        public DateTime date;
        public decimal montant;
        public string typeService;
        public int noEmploye;

        public frmFacture(string nom, string noAbonnement, DateTime date, decimal montant, string typeService, int noEmploye)
        {
            InitializeComponent();
            this.nomAbonnement = nom;
            this.noAbonnement = noAbonnement;
            this.date = date;
            this.montant = montant;
            this.typeService = typeService;
            this.noEmploye = noEmploye;
        }

        private void frmFacture_Load(object sender, EventArgs e)
        {
            tbNomAbonne.Text = nomAbonnement;
            tbDate.Text = date.Year + "-" + date.Month + "-" + date.Day;
            tbMontant.Text = montant.ToString();
            tbTypeService.Text = typeService;

            var nomCompletEmploye = from unEmploye in context.Employes
                                    where unEmploye.No == noEmploye
                                    select unEmploye;
            string nomComplet = nomCompletEmploye.First().Prenom + " " + nomCompletEmploye.First().Nom;
            tbNomCompletEmploye.Text = nomComplet;

            var depenses = from uneDepense in context.Depenses
                           where uneDepense.IdAbonnement == noAbonnement
                           select uneDepense;

            decimal sum = 0;
            foreach(var x in depenses)
            {
                sum += x.Montant;
            }
            tbTotalDepenses.Text = sum.ToString();

            var abonnement = (from unAbonnement in context.Abonnements
                              where unAbonnement.Id == noAbonnement
                              select unAbonnement).First();

            var typeAbonnement = (from unType in context.TypesAbonnements
                                  join unPrix in context.PrixDepensesAbonnements
                                  on unType.No equals unPrix.NoTypeAbonnement
                                    into listePrix
                                  select new { listePrix }).First();

            decimal montant1 = (typeAbonnement.listePrix.First().DepensesObligatoires - sum);
            if(montant1 < 0)
            {
                tbMontantNecessaire.Text = 0.ToString();
            }
            else
            {
                tbMontantNecessaire.Text = montant1.ToString();
            }
        }
    }
}
