using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
     class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> comptes;

        public Client(string n, string p, string a)
        {
            nom = n;
            prenom = p;
            adresse = a;
            comptes = new List<Compte>();
        }
        public void afficher()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Prenom : " + prenom);
            Console.WriteLine("Adresse : " + adresse);
            foreach(Compte cp in comptes)
            {
                cp.afficher();
            }
        }
        public void ajouterCompte(Compte c)
        {
            comptes.Add(c);
        }
      }
}
