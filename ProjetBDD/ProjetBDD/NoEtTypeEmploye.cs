using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDD
{
    class NoEtTypeEmploye
    {
        public int NoType { get; private set; }
        public string Description { get; private set; }

        public NoEtTypeEmploye(int no, string descr)
        {
            this.NoType = no;
            this.Description = descr;
        }
    }
}
