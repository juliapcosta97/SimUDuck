using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    public class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
             Console.WriteLine("Pato CV Grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato CV Nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato CV Nadando" + nome);
        }

        public void Voar()
        {
            Console.WriteLine("Pato CV Voando");
        }
    }
}
