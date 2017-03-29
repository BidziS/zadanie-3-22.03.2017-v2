using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_22._03._2017_v2
{
    public class MagazynTelefonow
    {
        IProducentFabryka producentFabryka;

        public MagazynTelefonow(IProducentFabryka producentFabryka)
        {
            this.producentFabryka = producentFabryka;
        }

        public void ZlozTelefon()
        {
            IObudowa obudowa = producentFabryka.GetObudowa();
            IEkran ekran = producentFabryka.GetEkran();

            obudowa.WyprodukujObudowe();
            ekran.WyprodukujEkran();
        }
    }
}
