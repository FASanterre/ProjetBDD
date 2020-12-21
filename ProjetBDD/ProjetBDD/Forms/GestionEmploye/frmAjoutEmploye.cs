using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace ProjetBDD.Forms.GestionEmploye
{
    public partial class frmAjoutEmploye : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmAjoutEmploye()
        {
            InitializeComponent();
        }

        private void frmAjoutEmploye_Load(object sender, EventArgs e)
        {
            noEtTypeEmployeBindingSource.DataSource = from unTypeEmploye in context.TypesEmployes
                                                      where unTypeEmploye.No != 1
                                                      select new { NoType = unTypeEmploye.No, Description = unTypeEmploye.Description };
            idEtNomProvinceBindingSource.DataSource = from uneProvince in context.Provinces
                                                      select new { id = uneProvince.Id, nom = uneProvince.Nom };
            cbSexe.SelectedIndex = 0;
        }

        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            if (tbNom.Text.Trim() == "" || tbNom.Text.Trim().Length > 50)
            {
                errMessage.SetError(tbNom, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbNom, "");
        }

        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenom.Text.Trim() == "" || tbPrenom.Text.Trim().Length > 50)
            {
                errMessage.SetError(tbPrenom, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbPrenom, "");
        }

        private void tbMDP_Validating(object sender, CancelEventArgs e)
        {
            if (tbMDP.Text.Trim() == "" || tbMDP.Text.Trim().Length > 50)
            {
                errMessage.SetError(tbMDP, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else if(!Regex.Match(tbMDP.Text.Trim(), "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$").Success)
            {
                errMessage.SetError(tbMDP, "Le mot de passe doit avoir une lettre, un chiffre, un caractère spécial et avoir un minimum de 8 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbMDP, "");
        }

        private void tbNumeroCivique_Validating(object sender, CancelEventArgs e)
        {
            var noCivique = 0;
            if (tbNumeroCivique.Text.Trim() == "")
            {
                errMessage.SetError(tbNumeroCivique, "Ce champs ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!int.TryParse(tbNumeroCivique.Text.Trim(), out noCivique))
            {
                errMessage.SetError(tbNumeroCivique, "Le numéro civique doit être un numéro entier");
                e.Cancel = true;
            }
            else errMessage.SetError(tbNumeroCivique, "");
        }

        private void tbRue_Validating(object sender, CancelEventArgs e)
        {
            if (tbRue.Text.Trim() == "" || tbRue.Text.Trim().Length > 50)
            {
                errMessage.SetError(tbRue, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbRue, "");
        }

        private void tbVille_Validating(object sender, CancelEventArgs e)
        {
            if (tbVille.Text.Trim() == "")
            {
                errMessage.SetError(tbVille, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbVille, "");
        }

        private void tbCodePostal_Validating(object sender, CancelEventArgs e)
        {
            if (tbCodePostal.Text.Trim() == "")
            {
                errMessage.SetError(tbCodePostal, "Ce champs ne peut pas être vide");
                e.Cancel = true;
            }
            else if (tbCodePostal.Text.Trim().Replace(" ","").Length < 6)
            {
                errMessage.SetError(tbCodePostal, "Le code postal doit contenir 6 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbCodePostal, "");
        }

        private void tbTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() == "")
            {
                errMessage.SetError(tbTelephone, "Ce champs ne peut pas être vide");
                e.Cancel = true;
            }
            else if (tbTelephone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 10)
            {
                errMessage.SetError(tbTelephone, "Le numéro de téléphone doit contenir 10 chiffres.");
                e.Cancel = true;
            }
            else errMessage.SetError(tbTelephone, "");
        }

        private void tbCellulaire_Validating(object sender, CancelEventArgs e)
        {
            if(tbCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "")
            {
                if (tbCellulaire.Text.Replace(" ", "").Replace("(","").Replace(")","").Replace("-","").Trim().Length < 10)
                {
                    errMessage.SetError(tbCellulaire, "Le numéro de cellulaire doit contenir 10 chiffres.");
                    e.Cancel = true;
                }
                else errMessage.SetError(tbCellulaire, "");
            }
        }

        private void tbCourriel_Validating(object sender, CancelEventArgs e)
        {
            if (tbCourriel.Text.Trim() == "" || tbCourriel.Text.Trim().Length > 50)
            {
                errMessage.SetError(tbCourriel, "Ce champs ne peut pas être vide et ne doit pas contenir plus de 50 caractères");
                e.Cancel = true;
            }
            else errMessage.SetError(tbCourriel, "");
        }

        private void btnAjouterEmp_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                var tousLesEmploye = from employe in context.Employes select employe.No;
                int noID = tousLesEmploye.Max() + 1;
                char sexe = 'H';
                if(cbSexe.SelectedItem.ToString().Trim() == "Homme")
                {
                    sexe = 'H';
                }
                else
                {
                    sexe = 'F';
                }
                var nouvelEmploye = new Employe
                {
                    No = noID,
                    MotDePasse = tbMDP.Text.Trim(),
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = sexe,
                    Age = (int)nudAge.Value,
                    NoCivique = int.Parse(tbNumeroCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = tbCodePostal.Text.Trim().Replace(" ", ""),
                    Telephone = tbTelephone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Cellulaire = tbCellulaire.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Courriel = tbCourriel.Text.Trim(),
                    SalaireHoraire = nudSalaire.Value,
                    NoTypeEmploye = (int)cbTypeEmploye.SelectedValue,
                    Remarque = tbRemarque.Text.Trim()
                };

                context.Employes.InsertOnSubmit(nouvelEmploye);

                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        context.SubmitChanges();
                        MessageBox.Show($"L'employé {noID} a été ajouté. ", "Ajout de l'employé");
                        porteeTransaction.Complete();
                        tbNom.Text = "";
                        tbPrenom.Text = "";
                        tbMDP.Text = "";
                        nudAge.Value = 16;
                        tbNumeroCivique.Text = "";
                        tbRue.Text = "";
                        tbVille.Text = "";
                        tbCellulaire.Text = "";
                        tbCodePostal.Text = "";
                        tbTelephone.Text = "";
                        tbCourriel.Text = "";
                        nudSalaire.Value = 10;
                        tbRemarque.Text = "";
                        this.Hide();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                    }
                }
            }
        }

        private void frmAjoutEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbMDP.Text = "";
            nudAge.Value = 16;
            tbNumeroCivique.Text = "";
            tbRue.Text = "";
            tbVille.Text = "";
            tbCellulaire.Text = "";
            tbCodePostal.Text = "";
            tbTelephone.Text = "";
            tbCourriel.Text = "";
            nudSalaire.Value = 10;
            tbRemarque.Text = "";
        }
    }
}
