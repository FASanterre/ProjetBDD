using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace ProjetBDD.Forms.GestionEmploye
{
    public partial class frmSuppressionEmploye : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmSuppressionEmploye()
        {
            InitializeComponent();
        }

        private void frmSuppressionEmploye_Load(object sender, EventArgs e)
        {
            employeDataGridView.DataSource = from unEmploye in context.Employes
                                             where unEmploye.NoTypeEmploye != 1 || unEmploye.No != frmConnexion.ID
                                             select unEmploye;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(employeDataGridView.SelectedRows.Count > 0 && employeDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow row = employeDataGridView.SelectedRows[0];
                var employe = row.DataBoundItem as Employe;
                var listeServiceDeLemploye = from unEmploye in context.Employes
                                             where unEmploye.No == employe.No
                                             join unServices in context.Services
                                             on unEmploye.No equals unServices.NoEmploye
                                             into serviceEmploye
                                             select new { unEmploye.No, serviceEmploye };

                if(listeServiceDeLemploye.First().serviceEmploye.Count() == 0)
                {
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer l'employé", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        context.Employes.DeleteOnSubmit(employe);
                        using (var porteeTransaction = new TransactionScope())
                        {
                            try
                            {
                                context.SubmitChanges();
                                MessageBox.Show($"L'employé sélectionné a été supprimé. ", "Suppression de l'employé");
                                employeDataGridView.DataSource = from unEmploye in context.Employes
                                                                 where unEmploye.NoTypeEmploye != 1 || unEmploye.No != frmConnexion.ID
                                                                 select unEmploye;
                                porteeTransaction.Complete();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"La suppression de l'employe {employe.No} est impossible parce qu'il offre {listeServiceDeLemploye.First().serviceEmploye.Count()} service(s).", "Suppression impossible");
                }
                
            }
        }
    }
}
