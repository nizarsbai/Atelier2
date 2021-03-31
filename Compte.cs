using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Compte
    {
        private static int cmp = 0;
        private readonly int numCompte;
        private Client titulaire;
        private MAD solde;
        private static MAD plafond = new MAD(4000);
        private List<Operation> L;

        //Constructeur
        public Compte()
        {
            this.numCompte = 0;
            //this.titulaire = new Client();
            this.solde = new MAD(0);
           // this.L = new List<Operation>();
            
        }

        public Compte(MAD solde,Client C )
        {
            cmp++;
            numCompte = cmp;
            C.ajouterCompte(this);
            this.titulaire = C;
            this.solde = solde;
            this.L = new List<Operation>();
        }


        public int NumCompte() { return this.numCompte; }
       // public Client Titulaire() { return this.titulaire; }
        // public double Solde() {  return this.solde;  }


        //Methodes
        public bool Crediter(MAD somme)
        {
            MAD Nul_val = new MAD(0);
            if (somme > Nul_val)
            {
                this.solde += somme;

                this.L.Add(new Operation(somme, "+" ));
                return true;
            }
            else
            {
                return false;
               // Console.WriteLine("Vous devez crediter un montant positif au compte souhaite");
            }
        }
        public virtual bool Debiter(MAD somme)
        {
            MAD Nul_val = new MAD(0);
            if (this.solde > somme)
            {
                if (somme > Nul_val)
                {
                    if (plafond > somme)
                    {
                        this.solde -= somme;
                        this.L.Add(new Operation(somme,"-"));
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Vous devez debiter un montant positif au compte souhaite");
                        return false;
                    }

                }
                Console.WriteLine("Vous devez debiter un montant positif au compte souhaite");
                return false;

            }
            Console.WriteLine("solde < somme");
            return false;

        }
        public void retirer(MAD montant)
        {
            if (montant.Sup(plafond) != true && montant.Sup(new MAD(0)))
                solde -= montant;
            else
                Console.WriteLine("Vous devez debiter un montant positif au compte souhaite");
        }
        public bool verser(MAD somme, Compte C)
        {
            if (this.Debiter(somme) == true)
            {
                C.Crediter(somme);
                return true;
            }
            return false;
            // this.solde -= montant;
            // C.solde += montant;

        }
        public void ajouterInteret(MAD T)
        {
            this.Crediter(this.solde * T);
        }
        public bool comparerDecouvert(MAD somme, MAD decouvert)
        {
            
            if(this.solde-somme>decouvert)
            {
                return true;
            }
            return false;
        }
        public virtual void afficher()
        {
            Console.WriteLine("Numero de compte :" + numCompte + "\nTitulaire : ");
           // this.titulaire.afficher();
            this.solde.print();
            foreach(Operation o in L)
            {
                o.afficher();
            }
        }
        
    }
}
