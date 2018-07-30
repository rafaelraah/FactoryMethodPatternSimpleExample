using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExemploFactoryMethodPattern.Factory
{
    public class Rosa : IFlor
    {
        public void CriarFlor()
        {
            Debug.WriteLine("Rosa criada com sucesso!");
        }

        public void Crescer()
        {
            Debug.WriteLine("A Rosa cresceu!");
        }

    }
}
