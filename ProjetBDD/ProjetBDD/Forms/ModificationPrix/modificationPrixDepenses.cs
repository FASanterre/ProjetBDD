using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetBDD.Forms.ModificationPrix
{
    public partial class modificationPrixDepenses : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        bool modif = false;
        public modificationPrixDepenses()
        {
            InitializeComponent();
        }

        private void modificationPrixDepenses_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = from unType in context.TypesAbonnements
                                                      select unType;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            prixDepensesAbonnementBindingSource.EndEdit();
            var newPrixDepense = new PrixDepensesAbonnement
            {
                NoTypeAbonnement = ((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current).NoTypeAbonnement,
                Annee = DateTime.Now,
                Prix = ((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current).Prix,
                DepensesObligatoires = ((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current).DepensesObligatoires,
                Remarques = ((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current).Remarques
            };
            context.PrixDepensesAbonnements.InsertOnSubmit(newPrixDepense);
            context.PrixDepensesAbonnements.DeleteOnSubmit((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current);
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
            context = new DataClassProjetBDDDataContext();
            prixDepensesAbonnementDataGridView.Enabled = false;
            btnEnregistrer.Enabled = false;
            lblErreur.Text = "Le prix et le coût des dépenses ne peuvent être modifiés deux fois dans la même année.";
        }

        private void typesAbonnementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (typesAbonnementBindingSource.Current != null)
            {
                if(((TypesAbonnement)typesAbonnementBindingSource.Current).PrixDepensesAbonnements.Count > 0)
                {
                    prixDepensesAbonnementBindingSource.DataSource = ((TypesAbonnement)typesAbonnementBindingSource.Current).PrixDepensesAbonnements;
                    if (((PrixDepensesAbonnement)prixDepensesAbonnementBindingSource.Current).Annee.Year == DateTime.Now.Year)
                    {
                        prixDepensesAbonnementDataGridView.Enabled = false;
                        btnEnregistrer.Enabled = false;
                        lblErreur.Text = "Le prix et le coût des dépenses ne peuvent être modifiés deux fois dans la même année.";
                    }
                    else
                    {
                        prixDepensesAbonnementDataGridView.Enabled = true;
                        btnEnregistrer.Enabled = true;
                        lblErreur.Text = "";
                    }
                }
                else
                {
                    typesAbonnementBindingSource.DataSource = from unType in context.TypesAbonnements
                                                              select unType;
                }
            }
        }

        private void prixDepensesAbonnementDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
            prixDepensesAbonnementDataGridView.Columns[e.ColumnIndex].HeaderText;
            // Confirm that the cell is not empty.
            switch (headerText)
            {
                case "Prix":
                    modif = true;
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        prixDepensesAbonnementDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le salaire horaire ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!double.TryParse(e.FormattedValue.ToString(), out var result))
                    {
                        prixDepensesAbonnementDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le prix doit être un nombre.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "DepensesObligatoires":
                    modif = true;
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        prixDepensesAbonnementDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le coût des dépenses ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!double.TryParse(e.FormattedValue.ToString(), out var result))
                    {
                        prixDepensesAbonnementDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le coût des dépenses doit être un nombre.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
            }
        }

        public void refresh()
        {
            prixDepensesAbonnementBindingSource.CancelEdit();
            prixDepensesAbonnementDataGridView.RefreshEdit();
        }

        private void modificationPrixDepenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnEnregistrer.Focus();
            if (modif)
            {
                prixDepensesAbonnementDataGridView.ClearSelection();
                prixDepensesAbonnementDataGridView.CurrentCell = null;
                prixDepensesAbonnementBindingSource.CancelEdit();
                prixDepensesAbonnementDataGridView.RefreshEdit();
            }
        }

        private void prixDepensesAbonnementDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modif = false;
            prixDepensesAbonnementDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }
    }
}
