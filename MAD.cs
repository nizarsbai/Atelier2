using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class MAD
    {
        private double valeur;
        public MAD(double valeur)
        {
            this.valeur = valeur;
        }
        public void print()
        {
            Console.WriteLine("Solde :" + this.valeur);
        }
        public MAD Plus(MAD d)
        {
            MAD c = new MAD(0);
            c.valeur = this.valeur + d.valeur;
            return c;
        }
        public static bool operator >(MAD m1, MAD m2)
        {
            if (m1.valeur > m2.valeur)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(MAD m1, MAD m2)
        {
            if (m1.valeur < m2.valeur)
            {
                return true;
            }
            return false;
        }
        public static MAD operator *(MAD d, MAD somme)
        {

            return new MAD(d.valeur * somme.valeur);
        }
       

        public static MAD operator +(MAD d, MAD somme)
        {

            return new MAD(d.valeur + somme.valeur);
        }
        public static MAD operator -(MAD d, MAD somme)
        {

            return new MAD(d.valeur - somme.valeur);
        }
        public MAD Egal(MAD d)
        {
            // MAD m = new MAD();
            this.valeur = d.valeur;
            return this;
        }
        public bool Sup(MAD d)
        {
            return valeur > d.valeur;
        }
        public bool Inf(MAD d)
        {
            return valeur < d.valeur;
        }
    }
}
