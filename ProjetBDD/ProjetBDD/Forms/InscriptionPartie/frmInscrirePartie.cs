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

namespace ProjetBDD.Forms.InscriptionPartie
{
    public partial class frmInscrirePartie : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmInscrirePartie()
        {
            InitializeComponent();
        }

        private void frmInscrirePartie_Load(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = from unAbonnement in context.Abonnements
                                                 select unAbonnement;
            noEtNomTerrainBindingSource.DataSource = from unTerrain in context.Terrains
                                   select new  NoEtNomTerrain(unTerrain.No, unTerrain.Nom);


        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                if(((Abonnement)abonnementBindingSource.Current) != null)
                {
                    var listeAbonnement = from unAbonnement in context.Abonnements
                                          where unAbonnement.Id == ((Abonnement)abonnementBindingSource.Current).Id
                                          join unReabonnement in context.Reabonnements
                                    on unAbonnement.Id equals unReabonnement.IdAbonnement
                                     into listeReabonnement
                                    select new { unAbonnement.DataAbonnement, listeReabonnement };
                    bool estAbonne = false;
                    foreach(var x in listeAbonnement)
                    {
                        if (x.DataAbonnement.Year == DateTime.Now.Year)
                            estAbonne = true;
                        foreach(var y in x.listeReabonnement)
                        {
                            if (y.DateRenouvellement.Year == DateTime.Now.Year)
                                estAbonne = true;
                        }
                    }
                    if (estAbonne)
                    {
                        var unePartieDeGolf = new PartiesJouee
                        {
                            IdAbonnement = ((Abonnement)abonnementBindingSource.Current).Id,
                            NoTerrain = (int)cbTerrain.SelectedValue,
                            DatePartie = DateTime.Now,
                            Pointage = tbPointage.Text.Trim(),
                            Remarque = tbRemarque.Text.Trim()
                        };
                        context.PartiesJouees.InsertOnSubmit(unePartieDeGolf);

                        using (var porteeTransaction = new TransactionScope())
                        {
                            try
                            {
                                context.SubmitChanges();
                                MessageBox.Show($"La partie pour l'abonnement {unePartieDeGolf.IdAbonnement} a été ajouté. ", "Ajout de la partie");
                                porteeTransaction.Complete();
                                tbRemarque.Text = "";
                                tbPointage.Text = "";
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
                        MessageBox.Show("L'abonnement choisi est désabonné.", " Impossible d'ajouter la partie");
                        tbPointage.Text = "";
                        tbRemarque.Text = "";
                    }
                }
            }
        }

        private void tbPointage_Validating(object sender, CancelEventArgs e)
        {
            if (tbPointage.Text.Trim() == "")
            {
                errorProvider1.SetError(tbPointage, "Le pointage ne peut être vide.");
                e.Cancel = true;
            }else if(tbPointage.Text.Trim().Length > 50)
            {
                errorProvider1.SetError(tbPointage, "Le pointage ne peut prendre plus de 50 caractères.");
                e.Cancel = true;
            }
            else errorProvider1.SetError(tbPointage, "");
        }

        private void tbRemarque_Validating(object sender, CancelEventArgs e)
        {
            if (tbRemarque.Text.Trim().Length > 50)
            {
                errorProvider1.SetError(tbRemarque, "La remarque ne peut prendre plus de 50 caractères.");
                e.Cancel = true;
            }
            else errorProvider1.SetError(tbRemarque, "");
        }

        private void frmInscrirePartie_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbPointage.Text = "";
            tbRemarque.Text = "";
        }
    }
}
