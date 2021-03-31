using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CompteCourant : Compte
    {
        private MAD decouvert;

        public CompteCourant(Client c1, MAD solde, MAD decouvert): base(solde,c1)
        {
            // MAD dv = new MAD(d);
            //this.decouvert = dv;
            this.decouvert = decouvert;
        }
        public override void afficher()
        {
            Console.WriteLine("Compte Courant");
            base.afficher();
            decouvert.print();
        }
        public override bool Debiter(MAD somme)
        {
            if(this.comparerDecouvert(somme,this.decouvert))
            {
               return base.Debiter(somme);
            }
            else
            {
                Console.WriteLine("solde-somme<decouvert");
                return false;
            }
        }
    }
}
