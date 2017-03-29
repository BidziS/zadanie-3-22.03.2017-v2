using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_22._03._2017_v2
{
    public class Apple:IProducentFabryka
    {
        public IObudowa GetObudowa()
        {
            return new ObudowaApple();
        }

        public IEkran GetEkran()
        {
            return new EkranApple();
        }
    }
}
