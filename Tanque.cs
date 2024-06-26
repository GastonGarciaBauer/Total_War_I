﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercito
{
    class Tanque : VehiculoMilitar, IVehiculoMilitar
    {
        // Atributos:
        private string capacidadTodoTerreno;
        private bool defensaAntiAerea;
        private string armamentoPrincipal;
        private string armamentoSecundario;

        //Métodos: 
        public Tanque(string patente, string nombre, string pais, int anioFabricacion, int peso, int capacidadTripulacion, int velocidad, double combustible, int blindaje, int potenciaDeFuego, string capacidadTodoTerreno, bool defensaAntiAerea, string armamentoPrincipal, string armamentoSecundario) 
            : base(patente, nombre, pais, anioFabricacion, peso, capacidadTripulacion, velocidad, combustible, blindaje, potenciaDeFuego)
        {
            this.capacidadTodoTerreno = capacidadTodoTerreno;
            this.defensaAntiAerea = defensaAntiAerea;
            this.armamentoPrincipal = armamentoPrincipal;
            this.armamentoSecundario = armamentoSecundario;
        }
       
        //Métodos de muestreo:
        public void informacion()
        {
            Console.WriteLine($"\n Nombre: {this.nombre} \n País: {this.pais} \n Año: {this.anioFabricacion} \n Peso: {this.peso} toneladas \n Blindaje: {this.blindaje} \n Potencia de fuego: {this.potenciaDeFuego} \n Velocidad: {this.velocidad} km/h \n Combustible: {this.combustible} galones \n");
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //Métodos funcionales:
        public void agregarAliados()
        {
            this.aliados = new List<string>();

            if (this.pais == "Estados Unidos")
            {
                this.aliados.Add("Gran Bretaña");
                this.aliados.Add("Francia");
            }
            else if (this.pais == "Gran Bretaña")
            {
                this.aliados.Add("Estados Unidos");
                this.aliados.Add("Francia");
            }
            else if (this.pais == "Francia")
            {
                this.aliados.Add("Estados Unidos");
                this.aliados.Add("Gran Bretaña");
            }
            else if (this.pais == "Alemania")
            {
                this.aliados.Add("Italia");
                this.aliados.Add("Japón");
            }
            else if (this.pais == "Italia")
            {
                this.aliados.Add("Japón");
                this.aliados.Add("Alemania");
            }
            else if (this.pais == "Japón")
            {
                this.aliados.Add("Alemania");
                this.aliados.Add("Italia");
            }
        }
        public bool sonAliados(Tanque aliado) 
        {
            foreach( string al in aliados)
            {
                if (al == aliado.pais) 
                {
                    return true;
                }
            }
            return false;
        }
        public void aumentarCombustible(int cantidad) 
        {
            this.combustible += cantidad;
            Console.WriteLine($"\n El combustible de {this.nombre} aumentó en {cantidad} galones. \n El combustible actual es: {this.combustible} galones. \n");
        }
        public void disminuirCombustible(int cantidad)
        {
            this.combustible -= cantidad;
        }

        //Métodos de ataque:
        
        public void batalla(Tanque enemigo)
        {
            if (this.sonAliados(enemigo))
            {
                Console.WriteLine($"{this.pais} y {enemigo.pais} son aliados, motivo por el cual los tanques no se atacarán. \n");
            }
            else
            {
                if (this.anioFabricacion > enemigo.anioFabricacion)
                {
                    Console.WriteLine($"Ha ganado el tanque {this.nombre} por ser más nuevo !!! \n");
                }
                else if (this.anioFabricacion < enemigo.anioFabricacion)
                {
                    Console.WriteLine($"Ha ganado el tanque {enemigo.nombre} por ser más nuevo !!! \n");
                }
                else
                {
                    Console.WriteLine("Ha habido un empate... Se define por peso.");

                    if (this.peso < enemigo.peso)
                    {
                        Console.WriteLine($"Ha ganado el tanque {this.nombre} por ser más liviano !!! \n");
                    }
                    else if (this.peso > enemigo.peso)
                    {
                        Console.WriteLine($"Ha ganado el tanque {enemigo.nombre} por ser más liviano !!! \n");
                    }
                    else
                    {
                        Console.WriteLine("Ha habido un empate nuevamente... \n");
                    }
                }
            }
        }

        public void batalla(Avion enemigo) 
        {

        }
        public void batalla(Barco enemigo)
        {

        }
        public void avanzar(int casillas) 
        {
            disminuirCombustible(casillas);
            Console.WriteLine($"El tanque {this.nombre} avanzó {casillas} casillas. Ha consumido {casillas} galones de combustible. \n");
            Console.WriteLine($"El combustible actual de {this.nombre} es: {this.combustible}. \n");
        }
        public void esperar(int turnos) { }
        public void defender(int defensa) { }
    }
}
