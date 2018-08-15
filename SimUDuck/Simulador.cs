using SimUDuck.Interfaces;

namespace SimUDuck
{
    public class Simulador
    {
        public void Executar(IPato pato)
        {
            pato.Grasnar();
            pato.Voar();
            pato.Nadar();
        }
    }
}
