using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System.Collections.Generic;

namespace SimUDuck.Fabrica
{
    public class FabricaPatos
    {
        public List<IPato> ObterPatos()
        {
            List<IPato> patos = new List<IPato>();
          
            patos.Add(new PatoCabecaVermelha());
            patos.Add(new PatoReal());

            return patos;
        }
    }
}
