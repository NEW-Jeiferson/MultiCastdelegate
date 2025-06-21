using System;
//1.1


namespace MultiCastdelegate 
{
    class Program
    {
        public static void MostrarPantalla(string Mensaje)
        {
            Console.WriteLine("Pantalla: " + Mensaje);
        }

        public static void MostrarEnMayuscula(string Mensaje) 
        {
            //ToUpper convierte el texto a mayúsculas
            Console.WriteLine("En Mayuscula: " + Mensaje.ToUpper());
        }

        public static void MostrarEnMinuscula(string Mensaje) 
        {
            //ToLower convierte el texto a minúsculas
            Console.WriteLine("En Minuscula: " + Mensaje.ToLower());
        }

        public delegate void Operacion(string Mensaje); 

        static void Main(string[] args)
        {
            //+= Operador para agregar un método al delegado
            Operacion delegado = MostrarPantalla;
            delegado += MostrarEnMayuscula;
            delegado += MostrarEnMinuscula;

            Console.WriteLine("\n Invocando el delegado multicast: ");
            delegado("Hice un disparate en Operacion");

            // -= Operador para remover un método del delegado
            delegado -= MostrarEnMayuscula; 
            Console.WriteLine("\n Invocando el delegado multicast después de remover MostrarEnMayuscula: ");
            delegado("Vamos a Resolver el disparate");

            Console.ReadKey();
        }
    }
}

