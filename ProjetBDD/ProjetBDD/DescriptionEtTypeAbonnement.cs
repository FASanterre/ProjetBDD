using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class DescriptionEtTypeAbonnement
    {
        public string Description { get; set; }
        public double Prix { get; set; }
        public double Depenses { get; set; }

        public DescriptionEtTypeAbonnement(string description, double prix, double depenses)
        {
            this.Description = description;
            this.Prix = prix;
            this.Depenses = depenses;
        }
    }
}
