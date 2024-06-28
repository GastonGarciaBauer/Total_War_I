using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercito
{
    interface IVehiculoMilitar
    {
        public void reparar();
        public void avanzar(int casillas);
        public void esperar(int turnos);
        public void defender(int defensa);
        public void batalla(Tanque enemigo);
        public void batalla(Avion enemigo);
        public void batalla(Barco enemigo);
        
    }
}
