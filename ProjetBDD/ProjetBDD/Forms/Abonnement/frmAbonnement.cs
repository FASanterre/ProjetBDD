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
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public int nbrDependantsAjoute = 0;
        public int nbDependants = -1;
        public string idAbonnement = "";
        public int type = 1;
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
            var typeAbonnement = (from type in context.TypesAbonnements
                                  where type.Description == (string)cbTypeAbonnement.SelectedItem
                                  select type).SingleOrDefault();

            if(typeAbonnement != null)
            {
                if (typeAbonnement.No == 2)
                {
                    lblNbEnfants.Visible = false;
                    nudNbEnfants.Visible = false;
                    dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-60);
                }
                else if (typeAbonnement.No == 6)
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
            else
            {
                lblNbEnfants.Visible = false;
                nudNbEnfants.Visible = false;
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
            }
        }

        private void frmAbonnement_Load(object sender, EventArgs e)
        {
            nbrDependantsAjoute = 0;
            nbDependants = 0;
            tbNom.Clear();
            tbPrenom.Clear();
            cbSexe.SelectedItem = null;
            tbNoCivique.Clear();
            tbCodePostal.Clear();
            tbCell.Clear();
            tbCourriel.Clear();
            tbRemarque.Clear();
            tbTelephone.Clear();
            tbVille.Clear();
            tbRue.Clear();

            var provinces = from prov in context.Provinces
                            select prov;

            if(cbProvince.Items.Count == 0)
            {
                foreach(var prov in provinces)
                {
                    cbProvince.Items.Add(prov.Id);
                }
            }

            var typeAbonnements = from type in context.TypesAbonnements
                            select type;

            if (cbTypeAbonnement.Items.Count == 0)
            {
                foreach (var type in typeAbonnements)
                {
                    cbTypeAbonnement.Items.Add(type.Description);
                }
            }

            dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
            cbProvince.SelectedIndex = 0;
            cbSexe.SelectedIndex = 0;
            cbSexeDep.SelectedIndex = 0;
            cbTypeAbonnement.SelectedIndex = 0;
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
            if (ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                var abonnements = from abon in context.Abonnements
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
                type = (from typ in context.TypesAbonnements
                            where typ.Description == cbTypeAbonnement.SelectedItem.ToString()
                            select typ.No).SingleOrDefault();
                
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
                        nbDependants = (int)nudNbEnfants.Value + 1;
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
                context.Abonnements.InsertOnSubmit(abonnement);
                idAbonnement = abonnement.Id;
                if (nbDependants == 0)
                {
                    using (var porteeTransaction = new TransactionScope())
                    {
                        try
                        {
                            context.SubmitChanges();
                            MessageBox.Show($"Ajout réussi.", "Ajout de l'abonnement");
                            porteeTransaction.Complete();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                        }
                    }
                }
                else
                {

                    gbAjoutAbonnement.Enabled = false;
                    gbAjoutAbonnement.Visible = false;
                    if (nbDependants > 0)
                    {
                        lblDependantNb.Text = "Ajout conjoin/conjointe";
                        gbDependants.Enabled = true;
                        gbDependants.Visible = true;
                        dtpDateNaissanceDep.MaxDate = DateTime.Now.AddYears(-18);
                        dtpDateNaissanceDep.MinDate = DateTime.Parse("1753-01-01");
                        
                    }
                }
            }
        }

        private void btnAjouterDep_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(tbNomDep.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Erreur, le champs nom est vide");
            }
            else if(tbPrenomDep.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Erreur, le champs prénom est vide");
            }
            if (isValid)
            {
                nbrDependantsAjoute++;
                lblDependantNb.Text = "Ajout du dépendant " + nbrDependantsAjoute;
                var lien = idAbonnement.Substring(0, idAbonnement.Length - 1);

                char sexe;
                if (cbSexeDep.SelectedItem.ToString() == "Homme")
                {
                    sexe = 'H';
                }
                else
                {
                    sexe = 'F';
                }

                string id;
                if (nbrDependantsAjoute - 1 == 0)
                {
                    id = lien + sexe + (nbrDependantsAjoute - 1);
                }
                else
                {
                    id = lien + "E" + (nbrDependantsAjoute - 1);
                }

                Dependant dep = new Dependant()
                {
                    Id = id,
                    Nom = tbNomDep.Text.Trim(),
                    Prenom = tbPrenomDep.Text.Trim(),
                    Sexe = sexe,
                    DateNaissance = dtpDateNaissanceDep.Value,
                    IdAbonnement = idAbonnement,
                    Remarque = tbRemarqueDep.Text.Trim()
                };
                context.Dependants.InsertOnSubmit(dep);
            }
            tbNomDep.Clear();
            tbPrenomDep.Clear();
            cbSexeDep.SelectedIndex= 0;
            tbRemarqueDep.Clear();

            if (nbrDependantsAjoute == nbDependants)
            {
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        context.SubmitChanges();
                        MessageBox.Show($"Ajout réussi.", "Ajout de l'abonnement");
                        porteeTransaction.Complete();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                    }
                }
            }
            else if (nbrDependantsAjoute > 0)
            {
                dtpDateNaissanceDep.MaxDate = DateTime.Now.AddYears(-1);
                dtpDateNaissanceDep.MinDate = DateTime.Now.AddYears(-18);
            }
        }

    }
}
