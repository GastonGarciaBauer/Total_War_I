using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercito
{
    class VehiculoMilitar
    {
        protected string patente;
        protected string nombre;
        protected string pais;
        protected int anioFabricacion;
        protected int peso;
        protected int capacidadTripulacion;
        protected int velocidad;
        protected double combustible;
        protected int blindaje;
        protected int potenciaDeFuego;
        protected List<string> aliados;

        public VehiculoMilitar(string patente, string nombre, string pais, int anioFabricacion, int peso, int capacidadTripulacion, int velocidad, double combustible, int blindaje, int potenciaDeFuego) 
        {
            this.patente = patente;
            this.nombre = nombre;
            this.pais = pais;
            this.anioFabricacion = anioFabricacion;
            this.peso = peso;
            this.capacidadTripulacion = capacidadTripulacion;
            this.velocidad = velocidad;
            this.combustible = combustible;
            this.blindaje = blindaje;
            this.potenciaDeFuego = potenciaDeFuego;
        }

        public string getPais()
        {
            return this.pais;
        }
    }
}
