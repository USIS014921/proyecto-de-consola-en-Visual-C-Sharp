using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables y luego iniciaciar a cero.
            float num1 = 0; float num2 = 0;

            // Mostrar titulo como la aplicacion de calculadora de consola de Csharp.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // pidale al usuario que escriba el primer numero.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // pidale al usuario que escriba el segundo numero.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // pidale al usuario que elija una opcion.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use una declaracion de cambios para hacer los calculos.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espera a que el usuario responda antes de cerrar.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}