using System;

namespace CS5
{
    class Program
    {
        static void Main(string[]args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30 09 2026
            // Sintaxis: while
            // inicializacion;
            // while(expresion)
            // {
            //      Bloque de instrucciones
            //      iterador;
            // }
            // Iterar = repetir
            // Ejemplo 1: ciclo ascendente (rango: 1-3)
            // m: variable de control
            // a. ciclo ascendente
            int m = 1; // Inicializacion 
            while(m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1;
            }
            // Ejercitacion
            // 1. definir un ciclo para imrimir tu nombre cinco veces
            // para la expresion usar el operador menor que
            int n = 1;
            while(n < 6)
            {
                Console.WriteLine("Luis Flores");
                n += 1;
            }
            // b. ciclo descendente
            int d = 3;
            while(d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incrementos
            // seciencia: 3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            // d. decrementos
            int o = 16;
            while(o >= 2)
            {
                Console.WriteLine("331");
                o -= 2;
            }
            // Actividad 1: ciclo infinito
            // 1. Definir un ciclo infinito ascendiente
            // 2. Definir un ciclo infinito ascendiente
            // Para la solucion: utilizar el operador de diferencia
            int infinito_1 = 1;
            while(infinito_1 != 0)
            {
                Console.WriteLine(infinito_1);
                infinito_1 += 1;
            }
            int infinito_2 = 0;
            while(infinito_2 != 1)
            {
                Console.WriteLine(infinito_2);
                infinito_2 -= 1;
            }
        }
    }
}