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
using System.Text.RegularExpressions;

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
            switch (headerText)
            {
                case "Nom":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =  "Le champs nom ne peut pas être vide et ne doit pas contenir plus de 50 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Prenom":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs prenom ne peut pas être vide et ne doit pas contenir plus de 50 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "MotDePasse":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le mot de passe ne peut pas être vide";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!Regex.Match(e.FormattedValue.ToString().Trim(), "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$").Success)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le mot de passe doit avoir une lettre, un chiffre, un caractère spécial et avoir un minimum de 8 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Sexe":
                    if (e.FormattedValue.ToString().Trim() == "" || (e.FormattedValue.ToString().Trim() != "F" && e.FormattedValue.ToString().Trim() != "H"))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs sexe ne peut pas être vide. Les valeurs possibles sont H et F";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Age":
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'âge ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!int.TryParse(e.FormattedValue.ToString(), out var result))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'âge doit être un entier.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (int.Parse(e.FormattedValue.ToString()) < 16 || int.Parse(e.FormattedValue.ToString()) > 65)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'âge doit être dans l'intervalle de 16 à 65 ans.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "NoCivique":
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le NoCivique ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    if (e.FormattedValue.ToString().Trim() == "")
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le chammps numéro civique ne peut pas être vide";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!int.TryParse(e.FormattedValue.ToString().Trim(), out var noCivique))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le numéro civique doit être un numéro entier";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Rue":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs rue ne peut pas être vide et ne doit pas contenir plus de 50 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Ville":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs ville ne peut pas être vide et ne doit pas contenir plus de 50 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "IdProvince":
                    var listeProvinces = from province in context.Provinces
                                         select province.Id;
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le IdProvince ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!listeProvinces.Contains(e.FormattedValue.ToString().Trim()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'IdProvince entré n'existe pas.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "CodePostal":
                    if (e.FormattedValue.ToString().Trim() == "")
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs code postal ne peut pas être vide";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (e.FormattedValue.ToString().Trim().Replace(" ", "").Length < 6)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le code postal doit contenir 6 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Telephone":
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le Telephone ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if(e.FormattedValue.ToString().Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 10 && !int.TryParse(e.FormattedValue.ToString(), out var ignore))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le numéro de téléphone doit contenir 10 chiffres.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "Cellulaire":
                    if (e.FormattedValue.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "")
                    {
                        if (e.FormattedValue.ToString().Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 10 && !int.TryParse(e.FormattedValue.ToString(), out var ignore))
                        {
                            employeDataGridView.Rows[e.RowIndex].ErrorText = "Le numéro de cellulaire doit contenir 10 chiffres.";
                            e.Cancel = true;
                            refresh();
                        }
                    }
                    break;
                case "Courriel":
                    if (e.FormattedValue.ToString().Trim() == "" || e.FormattedValue.ToString().Trim().Length > 50)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText = "Le champs courriel ne peut pas être vide et ne doit pas contenir plus de 50 caractères";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
                case "SalaireHoraire":
                    if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le salaire horaire ne doit pas être vide.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (!double.TryParse(e.FormattedValue.ToString(), out var result))
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'âge doit être un nombre.";
                        e.Cancel = true;
                        refresh();
                    }
                    else if (double.Parse(e.FormattedValue.ToString()) < 10 || double.Parse(e.FormattedValue.ToString()) > 500)
                    {
                        employeDataGridView.Rows[e.RowIndex].ErrorText =
                            "L'âge doit être dans l'intervalle de 10 à 500 ans.";
                        e.Cancel = true;
                        refresh();
                    }
                    break;
            }

        }

        private void employeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            employeDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void employeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmModificationEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeDataGridView.ClearSelection();
            employeDataGridView.CurrentCell = null;
            employeBindingSource.CancelEdit();
            employeDataGridView.RefreshEdit();
        }

        public void refresh()
        {
            employeBindingSource.CancelEdit();
            employeDataGridView.RefreshEdit();
        }
    }
}
