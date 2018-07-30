using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExemploFactoryMethodPattern.Factory
{
    public class Margarida : IFlor
    {
        public void CriarFlor()
        {
            Debug.WriteLine("Margarida criada com sucesso!");
        }
    }
}
