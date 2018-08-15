using System;

namespace SimUDuck.Patos
{
    public abstract class Pato
    {
        private string nome;

        public string Nome { get => nome; set => nome = value; }

        public void Grasnar()
        {
            Console.WriteLine("Grasnar");
        }

        //Método que pode ser sobreposto
        public virtual void Voar()
        {
            Console.WriteLine("Voando");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        //Métodos iguais com assinaturas diferentes 
        public void Nadar(string nome)
        {
            Console.WriteLine("Nadando" + nome);
        }
    }
}
