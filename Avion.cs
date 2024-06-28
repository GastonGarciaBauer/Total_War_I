using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercito
{
    class Avion : VehiculoMilitar
    {
        private string armamentoPrincipal;
        private string armamentoSecundario;
        private string penetracionBlindaje;
        public Avion(string patente, string nombre, string pais, int anioFabricacion, int peso, int capacidadTripulacion, int velocidad, double combustible, int blindaje, int potenciaDeFuego)
            : base(patente, nombre, pais, anioFabricacion, peso, capacidadTripulacion, velocidad, combustible, blindaje, potenciaDeFuego)
        {
            this.armamentoPrincipal = armamentoPrincipal;
            this.armamentoSecundario = armamentoSecundario;
            this.penetracionBlindaje = penetracionBlindaje;
    }
    }
}
