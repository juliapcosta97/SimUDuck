using SimUDuck.Fabrica;
using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;
using System.Collections.Generic;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaPatos fabrica = new FabricaPatos();
            Simulador simulador = new Simulador();

            var patos = fabrica.ObterPatos();
            foreach (var item in patos)
            {
                simulador.Executar(item);
            }
    
            

            //simulador.Executar(new PatoCabecaVermelha());
            //simulador.Executar(new PatoReal());

            //Console.WriteLine("Pato Selvagem");
            //Pato patoSelvagem = new PatoSelvagem();
            //patoSelvagem.Grasnar();
            //patoSelvagem.Voar();
            //patoSelvagem.Nadar();

            //Console.WriteLine("Pato Cabeça Vermelha");
            //IPato patoCabecaVermelha = new PatoCabecaVermelha();
            //patoCabecaVermelha.Grasnar();
            //patoCabecaVermelha.Voar();
            //patoCabecaVermelha.Nadar(" Pato Cabeça Vermelha");

            Console.ReadLine();
        }
    }
}
