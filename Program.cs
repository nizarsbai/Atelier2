using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("sbaI", "nizar", "casa");
            MAD d = new MAD(20000);

            CompteEpargne ce = new CompteEpargne(c1,d);
            MAD D1 = new MAD(1000);

            CompteCourant cc = new CompteCourant(c1, d, D1);

            ce.Crediter(D1);
            cc.verser(new MAD(1500), ce);
            ce.afficher();
            cc.afficher();

            Console.ReadKey();
        }
    }
}
