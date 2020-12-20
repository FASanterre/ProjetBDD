using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDD.Forms.ModificationPrix
{
    public partial class modificationPrixDepenses : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public modificationPrixDepenses()
        {
            InitializeComponent();
        }

        private void modificationPrixDepenses_Load(object sender, EventArgs e)
        {
            descriptionEtTypeAbonnementDataGridView.DataSource = from unType in context.TypesAbonnements
                                                                 join unPrix in context.PrixDepensesAbonnements
                                                                 on unType.No equals unPrix.NoTypeAbonnement
                                                                 select new { unType.Description, unPrix.Prix, unPrix.DepensesObligatoires };

        }
    }
}
