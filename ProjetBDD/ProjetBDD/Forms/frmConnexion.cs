using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDD
{
    public partial class frmConnexion : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        frmMenuPrincipal frmMenu = new frmMenuPrincipal();
        public static int ID = 0;
        public static int TypeEmploye = 0;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            var listeEmploye = from unEmploye in context.Employes
                               select new { unEmploye.No, unEmploye.MotDePasse, unEmploye.NoTypeEmploye };

            foreach(var unEmp in listeEmploye)
            {
                if(unEmp.No.ToString() == tbID.Text.Trim() && unEmp.MotDePasse == tbMotDePasse.Text.Trim())
                {
                    ID = unEmp.No;
                    TypeEmploye = unEmp.NoTypeEmploye;
                }
            }
            if(ID != 0)
            {
                //Changer de formulaire
                lblErreur.Text = "";
                this.Hide();
                frmMenu.ShowDialog();
                this.Show();
                tbID.Text = "";
                tbMotDePasse.Text = "";
            }
            else
            {
                //Montrer erreur
                lblErreur.Text = "Erreur : Authentification";
            }
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            tbID.Text = "1";
            tbMotDePasse.Text = "Password1$";
        }
    }
}
