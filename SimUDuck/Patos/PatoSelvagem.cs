using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    public class PatoSelvagem : Pato
    {
        public override void Voar()
        {
            Console.WriteLine("Pato Selvagem está voando agora");
        }
    }
}
