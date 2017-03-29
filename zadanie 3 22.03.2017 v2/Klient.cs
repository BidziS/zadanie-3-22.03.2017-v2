using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_22._03._2017_v2
{
    class Klient
    {
        static void Main(string[] args)
        {
            IProducentFabryka fabryka = new Samsung();
            MagazynTelefonow magazyn = new MagazynTelefonow(fabryka);
            magazyn.ZlozTelefon();
            /******************************************************************************/
            fabryka = new Apple();
            magazyn = new MagazynTelefonow(fabryka);
            magazyn.ZlozTelefon();

            Console.ReadLine();
        }
    }
}
