using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactoryMethodPattern.Factory
{
    public class FlorFactory
    {
        public IFlor GerarFlor(string tipoFlor)
        {
            if (string.IsNullOrEmpty(tipoFlor))
            {
                return null;
            }
            else if (tipoFlor.Equals("Margarida"))
            {
                return new Margarida();
            }
            else if (tipoFlor.Equals("Orquidea"))
            {
                return new Orquidea();
            }
            else if (tipoFlor.Equals("Rosa"))
            {
                return new Rosa();
            }

            return null;
        }
    }
}
