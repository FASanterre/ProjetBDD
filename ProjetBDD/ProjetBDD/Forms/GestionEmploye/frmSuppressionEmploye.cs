using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDD.Forms.GestionEmploye
{
    public partial class frmSuppressionEmploye : Form
    {
        DataClassProjetBDDDataContext context = new DataClassProjetBDDDataContext();
        public frmSuppressionEmploye()
        {
            InitializeComponent();
        }

        private void frmSuppressionEmploye_Load(object sender, EventArgs e)
        {
            employeDataGridView.DataSource = from unEmploye in context.Employes
                                             select unEmploye;
        }
    }
}
