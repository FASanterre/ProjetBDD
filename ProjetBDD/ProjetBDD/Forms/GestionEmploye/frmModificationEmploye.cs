using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace ProjetBDD.Forms.GestionEmploye
{
    public partial class frmModificationEmploye : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmModificationEmploye()
        {
            InitializeComponent();
        }

        private void frmModificationEmploye_Load(object sender, EventArgs e)
        {
            employeDataGridView.DataSource = from employe in context.Employes
                                             select employe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeBindingSource.EndEdit();
            using (var porteeTransaction = new TransactionScope())
            {
                try
                {
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                    MessageBox.Show("Modification complétée avec succès", "Modification");
                    porteeTransaction.Complete();
                }
                catch (ChangeConflictException ex)
                {
                    context.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                }
            }
        }

        private void employeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
            employeDataGridView.Columns[e.ColumnIndex].HeaderText;


            // Confirm that the cell is not empty.
            if(headerText == "Nom")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    employeDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le nom ne doit pas être vide.";
                    e.Cancel = true;
                }
            }
            else if(headerText == "Prenom")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    employeDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le prénom en doit pas être vide.";
                    e.Cancel = true;
                }
            }
        }

        private void employeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            employeDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }
    }
}
