using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetBDD.Forms.Rebonnement
{
    public partial class frmReabonnement : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmReabonnement()
        {
            InitializeComponent();
        }

        private void frmReabonnement_Load(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = from unAbonnement in context.Abonnements
                                                 where unAbonnement.DataAbonnement.Year != DateTime.Now.Year
                                                 && (unAbonnement.Reabonnements.Count > 0 
                                                 ? (unAbonnement.Reabonnements.OrderByDescending(x=>x.DateRenouvellement.Year)).First().DateRenouvellement.Year != DateTime.Now.Year : true)
                                                 select unAbonnement;
        }

        private void btnRenouveler_Click(object sender, EventArgs e)
        {
            if(((Abonnement)abonnementBindingSource.Current) != null)
            {
                var newReabonnement = new Reabonnement
                {
                    IdAbonnement = ((Abonnement)abonnementBindingSource.Current).Id,
                    DateRenouvellement = DateTime.Now,
                    Remarque = tbRemarque.Text.Trim()
                };
                context.Reabonnements.InsertOnSubmit(newReabonnement);
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        context.SubmitChanges();
                        MessageBox.Show("Le renouvellement a été effectué. ", "Renouvellement");
                        porteeTransaction.Complete();
                        
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                    }
                }
            }
        }
    }
}
