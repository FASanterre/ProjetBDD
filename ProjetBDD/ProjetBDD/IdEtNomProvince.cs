using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class IdEtNomProvince
    {
        public string id { get; private set; }
        public string nom { get; private set; }

        public IdEtNomProvince(string id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}
