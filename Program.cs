using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercito
{
    class Program
    {
        static void Main()
        {
            Tanque yamaha = new Tanque("LV-WNU", "Big-Daddy", "Estados Unidos", 1987, 2400, 5, 45, 10, 10, 150, "Nivel 1: Grava", false, "Bazooka", "----");
            Tanque mitsubishi = new Tanque("LV-WRZ", "Bomberman", "Francia", 1990, 2000, 4, 50, 8.8, 10, 150, "Nivel 1: Grava", false, "Bazooka", "----");

            Console.WriteLine("A continuación se presentará la información de los dos tanques a competir: \n");

            yamaha.informacion();
            mitsubishi.informacion();

            Console.WriteLine($"\n\n {yamaha.getNombre()} ---- VS ---- {mitsubishi.getNombre()} \n\n");

            yamaha.agregarAliados();
            mitsubishi.agregarAliados();
            yamaha.batalla(mitsubishi);
            yamaha.aumentarCombustible(15);
            yamaha.informacion();

            yamaha.avanzar(3);
        }
    }
}

//casos de prueba:
// tanque big-daddy con año de fabricación 2005 vs. tanque papa-roach con año de fabricación 1995 -- resultado esperado: gana big-daddy. CHECK!
// tanque big-daddy con año de fabricación 1995 vs. tanque papa-roach con año de fabricación 2005 -- resultado esperado: gana papa-roach. CHECK!
// tanque big-daddy con año de fabricación 2005 vs. tanque papa-roach con año de fabricación 2005 -- resultado esperado: empate. pasa a la siguiente comprobación. CHECK!
// tanque big-daddy con peso 1200 tnlds. vs. tanque papa-roach con peso 1600 tnlds. -- resultado esperado: gana big-daddy. CHECK!

