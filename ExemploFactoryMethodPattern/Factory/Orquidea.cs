using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExemploFactoryMethodPattern.Factory
{
    public class Orquidea : IFlor
    {
        public void CriarFlor()
        {
            Debug.WriteLine("Orquidea criada com sucesso!");
        }
    }
}
