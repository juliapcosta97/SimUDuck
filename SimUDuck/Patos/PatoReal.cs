using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoReal : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Real G");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Real N");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato Real N" + nome);
        }

        public void Voar()
        {
            Console.WriteLine("Pato Real V");
        }
    }
}
