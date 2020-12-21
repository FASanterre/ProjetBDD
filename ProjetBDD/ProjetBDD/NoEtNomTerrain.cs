using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class NoEtNomTerrain
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }

        public NoEtNomTerrain(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
    }
}
