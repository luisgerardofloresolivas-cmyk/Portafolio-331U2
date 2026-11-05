using System;

namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 15: Funciones
            /*
            Funcion: bloque de instrucciones para realizar una tarea especifica, que se ejecuta, unicamente, cuando es invocado.
            Sintaxis: Definicion de funcion
            tipo_dato_devuelto identificador_funcion(parametros)
            {
                bloque de instrucciones
            }
            Nota1: los parametros se definen incluyendo tipo de dato.
            Nota2: los parametros van separados por comas.
            Sintaxis: invocacion funcion
            identificador_funcion(argumentos);
            Argumento: el valor del parametro
            */
            // jemplo 1: funcion vacia sin parametros
            void Saludar()
            {
                string salon = "Exactas 331";
                Console.WriteLine($"Hola, {salon}");
            }
            // invocacion
            Saludar();
            // Ejercitasion
            // Definir e invocar una funcion sin parametros para imprimir: nombre clave y salon
            void Datos()
            {
                Console.WriteLine("Luis, 331-9, 331");
            }
            Datos();
            // ejercisio 2: definir e invocar una funcion oara desplegar el horario de hoy.
            void Horario()
            {
                Console.WriteLine("7:00. Calculo, 7:50. Formacion Humana, 8:40. Programacion, 9:50. Psicologia, 10:40. idiomas, 11:50. Dibujo Tecnico, 12:40. Dibujo Tecnico.");
            }
            Horario();
        }
    }
}
