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

namespace ProjetBDD.Forms
{
    public partial class frmAbonnement : Form
    {
        DataClassProjetBDDDataContext contexte = new DataClassProjetBDDDataContext();
        frmAjoutDependant frmDep = new frmAjoutDependant();
        public List<Dependant> listDep = new List<Dependant>();
        public frmAbonnement()
        {
            InitializeComponent();
        }

        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            if(tbNom.Text.Trim() == "")
            {
                errMessage.SetError(tbNom, "Vous devez entrer un nom");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbNom, string.Empty);
            }
        }

        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenom.Text.Trim() == "")
            {
                errMessage.SetError(tbPrenom, "Vous devez entrer un prénom");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbPrenom, string.Empty);
            }
        }

        private void cbSexe_Validating(object sender, CancelEventArgs e)
        {
            if(cbSexe.SelectedItem == null)
            {
                errMessage.SetError(cbSexe, "Vous devez sélectionner un sexe");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(cbSexe, string.Empty);
            }
        }

        private void tbNoCivique_Validating(object sender, CancelEventArgs e)
        {
            var val = 0;
            if (tbNoCivique.Text.Trim() == "")
            {
                errMessage.SetError(tbNoCivique, "Vous devez entrer un numéro civique");
                e.Cancel = true;
            }
            else if (!int.TryParse(tbNoCivique.Text.Trim(), out val))
            {
                errMessage.SetError(tbNoCivique, "Le numéro civique doit être un nombre entier");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbNoCivique, string.Empty);
            }
        }

        private void tbRue_Validating(object sender, CancelEventArgs e)
        {
            if (tbRue.Text.Trim() == "")
            {
                errMessage.SetError(tbRue, "Vous devez entrer une rue");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbRue, string.Empty);
            }
        }

        private void tbVille_Validating(object sender, CancelEventArgs e)
        {
            if (tbVille.Text.Trim() == "")
            {
                errMessage.SetError(tbVille, "Vous devez entrer une ville");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbVille, string.Empty);
            }
        }

        private void cbProvince_Validating(object sender, CancelEventArgs e)
        {
            if (cbProvince.SelectedItem == null)
            {
                errMessage.SetError(cbProvince, "Vous devez sélectionner une province");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(cbProvince, string.Empty);
            }
        }

        private void tbCodePostal_Validating(object sender, CancelEventArgs e)
        {
            if (tbCodePostal.Text.Replace(" ", "").Trim().Length < 6)
            {
                errMessage.SetError(tbCodePostal, "Le code postal doit être dans un format A9A 9A9");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbCodePostal, string.Empty);
            }
        }

        private void tbTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelephone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 10)
            {
                errMessage.SetError(tbTelephone, "Le numéro de Téléphone doit être dans un format (999)999-9999");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbTelephone, string.Empty);
            }
        }

        private void tbCourriel_Validating(object sender, CancelEventArgs e)
        {
            if (tbCourriel.Text.Trim() == "")
            {
                errMessage.SetError(tbCourriel, "Vous devez entrer une adresse courriel");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(tbCourriel, string.Empty);
            }
        }

        private void cbTypeAbonnement_Validating(object sender, CancelEventArgs e)
        {
            if (cbTypeAbonnement.SelectedItem == null)
            {
                errMessage.SetError(cbTypeAbonnement, "Vous devez sélectionner un type d'abonnement");
                e.Cancel = true;
            }
            else
            {
                errMessage.SetError(cbTypeAbonnement, string.Empty);
            }
        }

        private void cbTypeAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var typeAbonnement = (from type in contexte.TypesAbonnements
                                  where type.Description == (string)cbTypeAbonnement.SelectedItem
                                  select type).SingleOrDefault();

            if (typeAbonnement != null && typeAbonnement.No == 2)
            {
                lblNbEnfants.Visible = false;
                nudNbEnfants.Visible = false;
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-60);
            }
            else if(typeAbonnement.No == 6)
            {
                lblNbEnfants.Visible = true;
                nudNbEnfants.Visible = true;
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
            }
            else
            {
                lblNbEnfants.Visible = false;
                nudNbEnfants.Visible = false;
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
            }
        }

        private void frmAbonnement_Load(object sender, EventArgs e)
        {
            var provinces = from prov in contexte.Provinces
                            select prov;

            if(cbProvince.Items.Count == 0)
            {
                foreach(var prov in provinces)
                {
                    cbProvince.Items.Add(prov.Id);
                }
            }

            var typeAbonnements = from type in contexte.TypesAbonnements
                            select type;

            if (cbTypeAbonnement.Items.Count == 0)
            {
                foreach (var type in typeAbonnements)
                {
                    cbTypeAbonnement.Items.Add(type.Description);
                }
            }

            dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void tbCell_Validating(object sender, CancelEventArgs e)
        {
            if(tbCell.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length > 0)
            {
                if(tbCell.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 10)
                {
                    errMessage.SetError(tbCell, "Le numéro de cellulaire doit être dans un format (999)999-9999");
                    e.Cancel = true;
                }
                else
                {
                    errMessage.SetError(tbCell, string.Empty);
                }
            }
            else
            {
                errMessage.SetError(tbCell, string.Empty);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var abonnements = from abon in contexte.Abonnements
                                              select abon;

                int numId = abonnements.Count() + 1;
                string nom = tbNom.Text.Trim();
                var sexe = 'R';
                if(cbSexe.SelectedItem.ToString() == "Homme")
                {
                    sexe = 'H';
                }
                else
                {
                    sexe = 'F';
                }
                var type = (from typ in contexte.TypesAbonnements
                            where typ.Description == cbTypeAbonnement.SelectedItem.ToString()
                            select typ.No).SingleOrDefault();
                int nbDependants = -1;
                switch (type)
                {
                    case 1:
                    case 2:
                        nbDependants = 0;
                        break;
                    case 3:
                        nbDependants = 1;
                        break;
                    case 4:
                        nbDependants = 2;
                        break;
                    case 5:
                        nbDependants = 3;
                        break;
                    case 6:
                        nbDependants = (int)nudNbEnfants.Value;
                        break;
                    default:
                        break;

                }
                Abonnement abonnement = new Abonnement()
                {
                    Id = nom + numId + "P",
                    DataAbonnement = DateTime.Now,
                    Nom = nom,
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = sexe,
                    DateNaissance = dtpDateNaissance.Value,
                    NoCivique = int.Parse(tbNoCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedItem.ToString(),
                    CodePostal = tbCodePostal.Text.Replace(" ", "").Trim(),
                    Telephone = tbTelephone.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Cellulaire = tbCell.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    Courriel = tbCourriel.Text.Trim(),
                    NoTypeAbonnement = type,
                    Remarque = tbRemarque.Text.Trim()
                };
                contexte.Abonnements.InsertOnSubmit(abonnement);

                using (var transac = new TransactionScope())
                {
                    try
                    {
                        contexte.SubmitChanges();
                        MessageBox.Show("L'abonnement " + abonnement.Id + " a été ajouté avec success", "Ajout abonnement");
                        for (var i = 0; i < nbDependants; i++)
                        {
                            if(i == 0)
                            {
                                frmDep.majeur = true;
                                frmDep.lblTitre = "Ajout dépendant (conjoint/conjointe)";
                            }
                            else
                            {
                                frmDep.majeur = false;
                                frmDep.lblTitre = "Ajout dépendant (enfant)";
                            }
                            frmDep.idAbonnement = abonnement.Id;
                            frmDep.numDependant = i;
                            this.Hide();
                            frmDep.ShowDialog();
                            this.Show();
                        }
                        foreach (var dep in listDep)
                        {
                            contexte.Dependants.InsertOnSubmit(dep);
                        }
                        contexte.SubmitChanges();
                        MessageBox.Show("Les dépendants pour l'abonnement " + abonnement.Id + " ont été ajoutés avec succès", "Ajout abonnement");
                        transac.Complete();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur");
                    }
                }
            }
        }
    }
}
