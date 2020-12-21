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

namespace ProjetBDD.Forms
{
    public partial class frmAjoutDependant : Form
    {
        public string lblTitre = "";
        public bool majeur = false;
        public string idAbonnement = "";
        public int numDependant = -1;
        bool fermer = false;
        DataClassProjetBDDDataContext contexte = new DataClassProjetBDDDataContext();
        public frmAbonnement frmAbon = null;
        public frmAjoutDependant()
        {
            InitializeComponent();
        }

        private void frmAjoutDependant_Load(object sender, EventArgs e)
        {
            lblDependant.Text = lblTitre;
            if (majeur)
            {
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-18);
                dtpDateNaissance.MinDate = DateTime.Parse("1753-01-01");
            }
            else
            {
                dtpDateNaissance.MaxDate = DateTime.Now.AddYears(-1);
                dtpDateNaissance.MinDate = DateTime.Now.AddYears(-18);
            }
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

        private void frmAjoutDependant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fermer)
            {
                e.Cancel = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var lien = idAbonnement.Substring(0, idAbonnement.Length - 1);

                char sexe;
                if (cbSexe.SelectedItem.ToString() == "Homme")
                {
                    sexe = 'H';
                }
                else
                {
                    sexe = 'F';
                }

                string id;
                if (numDependant == 0)
                {
                    id = lien + sexe + numDependant;
                }
                else
                {
                    id = lien + "E" + numDependant;
                }

                Dependant dep = new Dependant()
                {
                    Id = id,
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = sexe,
                    DateNaissance = dtpDateNaissance.Value,
                    IdAbonnement = idAbonnement,
                    Remarque = tbRemarques.Text.Trim()
                };
                //contexte.Dependants.InsertOnSubmit(dep);

                //using (var maTransac = new TransactionScope())
                //{
                //    try
                //    {
                //        contexte.SubmitChanges();
                //        MessageBox.Show("Le dépendant " + dep.Id + " a été ajouté avec success", "Ajout Dépendant");
                //        maTransac.Complete();
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message, "Erreur");
                //    }
                //}
                tbNom.Clear();
                tbPrenom.Clear();
                cbSexe.SelectedItem = null;
                dtpDateNaissance.Value = dtpDateNaissance.MaxDate;
                tbRemarques.Clear();
                fermer = true;
                this.Close();
            }
        }
    }
}
