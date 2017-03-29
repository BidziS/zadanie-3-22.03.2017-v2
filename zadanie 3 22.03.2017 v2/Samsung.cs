using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_22._03._2017_v2
{
    public class Samsung:IProducentFabryka
    {
        public IObudowa GetObudowa()
        {
            return new ObudowaSamsung();
        }

        public IEkran GetEkran()
        {
            return new EkranSamsung();
        }
    }
}
