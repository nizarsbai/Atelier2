using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CompteEpargne : Compte
    {
        private double tauxinteret;

       // public CompteEpargne(){ }
        public CompteEpargne(Client C,MAD solde) :base(solde, C)
        {
            /*
            if(T<0 && T<100)
            {
                Console.WriteLine("Veuillez saisir un taux d'interet entre 0 et 100");
            }
            this.tauxinteret = T;
            */
            double T;
            bool res;

            do
            {
                Console.WriteLine("Donnez un taux :");
                res=double.TryParse(Console.ReadLine(), out T);
            }
            while (T <= 0 || T > 100 || !res);
            {
                this.tauxinteret = T;
            }
            
        }
        public void CalculerInteret()
        {
            MAD taux = new MAD(tauxinteret/100);
            //base.solde += base.solde *taux ;
            // this.solde = new MAD(0);
            this.ajouterInteret(taux);
            
           // Crediter((Nul_val * tauxinteret) / 100);
        }
        public override void afficher()
        {
            Console.WriteLine("Compte Epargne : ");
            base.afficher();
            Console.WriteLine("Taux d Interet : " + tauxinteret);
        }

    }
}
