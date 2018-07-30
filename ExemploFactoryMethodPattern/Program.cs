using ExemploFactoryMethodPattern.Factory;
using System;
using System.Diagnostics;

namespace ExemploFactoryMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFlor flor;
            FlorFactory florFactory = new FlorFactory();

            flor = florFactory.GerarFlor("Margarida");
            flor.CriarFlor();

            flor = florFactory.GerarFlor("Orquidea");
            flor.CriarFlor();

            flor = florFactory.GerarFlor("Rosa");
            flor.CriarFlor();
        }
    }
}
