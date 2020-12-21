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

namespace ProjetBDD.Forms.InscriptionDepenses
{
    public partial class frmInscrireDepenses : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        bool boolFonctionne = false;
        
        public frmInscrireDepenses()
        {
            InitializeComponent();
        }

        private void frmInscrireDepenses_Load(object sender, EventArgs e)
        {
            abonnementBindingSource.DataSource = from unAbonnement in context.Abonnements
                                                 select unAbonnement;
            cbTypeService.SelectedIndex = 0;
            if(frmConnexion.TypeEmploye == 1 || frmConnexion.TypeEmploye == 2 || frmConnexion.TypeEmploye == 3)
            {
                cbTypeService.Visible = true;
                lblType.Visible = true;
            }
            else
            {
                cbTypeService.Visible = false;
                lblType.Visible = false;
            }
        }

        private void nudMontant_Validating(object sender, CancelEventArgs e)
        {
            if (nudMontant.Value == 0)
            {
                errorProvider1.SetError(nudMontant, "Le montant de la dépense ne pas être de 0.");
                e.Cancel = true;
            }
            else errorProvider1.SetError(nudMontant, "");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                if (((Abonnement)abonnementBindingSource.Current) != null)
                {
                    var touslesDepenses = from depense in context.Depenses select depense.No;
                    int noID = 1;
                    if(touslesDepenses.Count() != 0)
                    {
                        noID = touslesDepenses.Max() + 1;
                    }

                    string typeService = "";
                    switch (frmConnexion.TypeEmploye)
                    {
                        case 1:
                        case 2:
                        case 3:
                            typeService = cbTypeService.SelectedItem.ToString();
                            break;
                        case 5:
                            typeService = "Magasin Pro Shop";
                            break;
                        case 6:
                            typeService = "Restaurant";
                            break;
                        case 7:
                            typeService = "Leçon de golf";
                            break;
                    }
                    int noService = 0;
                    var serviceExist = from unService in context.Services
                                        where unService.TypeService == typeService && unService.NoEmploye == frmConnexion.ID
                                        select unService;
                    if(serviceExist.Count() == 0)
                    {
                        var tousLesServices = from services in context.Services select services.No;
                        int noID1 = 1;
                        if (tousLesServices.Count() != 0)
                        {
                            noID1 = tousLesServices.Max() + 1;
                        }
                        var newService = new Service
                        {
                            No = noID1,
                            TypeService = typeService,
                            NoEmploye = frmConnexion.ID
                        };
                        context.Services.InsertOnSubmit(newService);
                        noService = noID1;
                    }
                    else if(serviceExist.Count() == 1)
                    {
                        noService = serviceExist.First().No;
                    }

                    var newDepense = new Depense
                    {
                        No = noID,
                        IdAbonnement = ((Abonnement)abonnementBindingSource.Current).Id,
                        DateDepense = DateTime.Now,
                        Montant = nudMontant.Value,
                        NoService = noService,
                        Remarque = tbRemarque.Text.Trim()
                    };
                    context.Depenses.InsertOnSubmit(newDepense);
                    using (var porteeTransaction = new TransactionScope())
                    {
                        try
                        {
                            context.SubmitChanges();
                            MessageBox.Show($"La dépenese {noID} a été ajouté. ", "Ajout de la dépense");
                            boolFonctionne = true;
                            porteeTransaction.Complete();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, " Impossible de modifier la base de données");
                        }
                    }
                    if (boolFonctionne)
                    {
                        this.Hide();
                        frmFacture frmFacture = new frmFacture(((Abonnement)abonnementBindingSource.Current).Nom, ((Abonnement)abonnementBindingSource.Current).Id, DateTime.Now, nudMontant.Value, typeService, frmConnexion.ID);
                        frmFacture.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
