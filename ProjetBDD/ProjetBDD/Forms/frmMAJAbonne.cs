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

namespace ProjetBDD.Forms
{
    public partial class frmMAJAbonne : Form
    {
        DataClassProjetBDDDataContext context= new DataClassProjetBDDDataContext();
        bool modifDep = false;
        bool modifAbonne = false;
        public frmMAJAbonne()
        {
            InitializeComponent();
        }

        private void frmMAJAbonne_Load(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = from unAbonnement in context.Abonnements
                                                 select unAbonnement;
        }

        private void abonnementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            dependantBindingSource.DataSource = ((Abonnement)abonnementBindingSource.Current).Dependants;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            abonnementBindingSource.EndEdit();
            dependantBindingSource.EndEdit();
            using(var porteeTransaction = new TransactionScope())
            {
                try
                {
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                    MessageBox.Show("Modification effectuée.", "Modification");
                    porteeTransaction.Complete();
                }
                catch (ChangeConflictException ex)
                {
                    context.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Erreur lors de l'enregistrement des données");
                }
            }
        }


        private void abonnementDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue.ToString().Trim();
            string headerText =
            abonnementDataGridView.Columns[e.ColumnIndex].HeaderText;
            // Confirm that the cell is not empty.
            switch (headerText)
            {
                case "Sexe":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Invalide";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value != "H" && value != "F")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Invalide2";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Prenom":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs prénom ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 50)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs prenom ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Remarque":
                    modifAbonne = true;
                    if (value.Length > 50)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs remarque ne peut contenir plus de 50 caractères";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "NoCivique":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs NoCivique ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (!int.TryParse(value, out var ignore))
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs NoCivique doit être un entier.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Rue":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs rue ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 50)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs rue ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Ville":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs ville ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 50)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs ville ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "CodePostal":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs codePostal ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 6)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs ville ne peut contenir plus de 6 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Telephone":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs telephone ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 10)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs telephone ne peut contenir plus de 10 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Cellulaire":
                    modifAbonne = true;
                    if (value != "" && value.Length > 10)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs cellulaire ne peut contenir plus de 10 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "Courriel":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs courriel ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 50)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs courriel ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    break;
                case "IdProvince":
                    modifAbonne = true;
                    if (value == "")
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs IdProvince ne peut être vide.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else if (value.Length > 2)
                    {
                        abonnementDataGridView.Rows[e.RowIndex].ErrorText = "Le champs IdProvince ne peut contenir plus de 2 caractères.";
                        e.Cancel = true;
                        refreshAbonne();
                    }
                    else
                    {
                        var listeProvince = (from uneProvince in context.Provinces
                                             select uneProvince.Id).ToList();
                        if (!listeProvince.Contains(value))
                        {
                            abonnementDataGridView.Rows[e.RowIndex].ErrorText = "L'id de province inséré n'est pas un id existant.";
                            e.Cancel = true;
                            refreshAbonne();
                        }
                    }
                    break;
            }
        }

        private void dependantDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue.ToString();
            string headerText =
            dependantDataGridView.Columns[e.ColumnIndex].HeaderText;
            // Confirm that the cell is not empty.
            switch (headerText)
            {
                case "Sexe":
                    modifDep = true;
                    if(value == "")
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Invalide";
                        e.Cancel = true;
                        refreshDep();
                    }
                    else if(value != "H" && value != "F")
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Invalide2";
                        e.Cancel = true;
                        refreshDep();
                    }
                    break;
                case "Prenom":
                    modifDep = true;
                    if (value == "")
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Le champs prénom ne peut être vide.";
                        e.Cancel = true;
                        refreshDep();
                    }
                    else if(value.Length > 50)
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Le champs prenom ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshDep();
                    }
                    break;
                case "Nom":
                    modifDep = true;
                    if (value == "")
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Le champs nom ne peut être vide.";
                        e.Cancel = true;
                        refreshDep();
                    }
                    else if (value.Length > 50)
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Le champs nom ne peut contenir plus de 50 caractères.";
                        e.Cancel = true;
                        refreshDep();
                    }
                    break;
                case "Remarque":
                    modifDep = true;
                    if (value.Length > 50)
                    {
                        dependantDataGridView.Rows[e.RowIndex].ErrorText = "Le champs remarque ne peut contenir plus de 50 caractères";
                        e.Cancel = true;
                        refreshDep();
                    }
                    break;
            }
        }

        private void dependantDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modifDep = false;
            dependantDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void abonnementDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            modifAbonne = false;
            abonnementDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void frmMAJAbonne_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Focus();
            if (modifDep)
            {
                dependantDataGridView.ClearSelection();
                dependantDataGridView.CurrentCell = null;
                dependantBindingSource.CancelEdit();
                dependantDataGridView.RefreshEdit();
            }

            if (modifAbonne)
            {
                abonnementDataGridView.ClearSelection();
                abonnementDataGridView.CurrentCell = null;
                abonnementBindingSource.CancelEdit();
                abonnementDataGridView.RefreshEdit();
            }
        }

        public void refreshDep()
        {
            dependantBindingSource.CancelEdit();
            dependantDataGridView.RefreshEdit();
        }

        public void refreshAbonne()
        {
            abonnementBindingSource.CancelEdit();
            abonnementDataGridView.RefreshEdit();
        }
    }
}
