using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Operation
    {
        private static int cmp = 0;
        private int Num;
        private DateTime date;
        private MAD montant;
        private string libelle;

        public Operation(MAD mt,string lb)
        {
            this.Num = ++cmp;
            this.date = DateTime.Now;
            this.montant = mt;
            this.libelle = lb;
        }
        public void afficher()
        {
            Console.Write(this.date + "|" + this.Num + "|" + this.libelle);
            this.montant.print();
        }

    }
}
