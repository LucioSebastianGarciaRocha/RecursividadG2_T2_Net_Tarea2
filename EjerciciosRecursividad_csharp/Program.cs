using System;

namespace EjerciciosRecursividad
{
    class Program
    {
        // ===================== Ejercicio 1 =====================
        // Método recursivo que calcula el número de vocales de una cadena.
        static int Vocales(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return 0;
            }

            char actual = char.ToLower(cadena[0]);
            int esVocal = (actual == 'a' || actual == 'e' || actual == 'i'
                || actual == 'o' || actual == 'u') ? 1 : 0;

            return esVocal + Vocales(cadena.Substring(1));
        }

        // ===================== Ejercicio 2 =====================
        // Suma de dígitos de un entero (recursivo).
        static int SumaDigitos(int n)
        {
            n = Math.Abs(n);
            if (n < 10)
            {
                return n;
            }
            return (n % 10) + SumaDigitos(n / 10);
        }

        static void EjecutarEjercicio2()
        {
            Console.WriteLine("=== Ejercicio 2: Suma de digitos ===");
            Console.WriteLine("Ingrese numeros enteros positivos uno por uno.");
            Console.WriteLine("Ingrese 0 para terminar la secuencia.");

            int numero;
            int mayorSuma = -1;
            int numeroConMayorSuma = -1;
            bool huboDatos = false;

            do
            {
                Console.Write("Numero (0 para terminar): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    huboDatos = true;
                    int suma = SumaDigitos(numero);
                    Console.WriteLine($"  Suma de digitos de {numero} = {suma}");

                    if (suma > mayorSuma)
                    {
                        mayorSuma = suma;
                        numeroConMayorSuma = numero;
                    }
                }
            } while (numero != 0);

            if (huboDatos)
            {
                Console.WriteLine($"\nEl entero con mayor suma de digitos es: {numeroConMayorSuma} (suma = {mayorSuma})");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros.");
            }
        }

        // ===================== Ejercicio 3 =====================
        // S(n) = S(n - 1) + n
        static int SumaN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return SumaN(n - 1) + n;
        }

        static void EjecutarEjercicio3()
        {
            Console.WriteLine("=== Ejercicio 3: Suma de los primeros n numeros ===");
            Console.Write("Ingrese un valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"S({n}) = {SumaN(n)}");
        }

        // ===================== Menu principal =====================
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n===== EJERCICIOS DE RECURSIVIDAD =====");
                Console.WriteLine("1) Contar vocales de una cadena");
                Console.WriteLine("2) Suma de digitos - mayor de la secuencia");
                Console.WriteLine("3) Suma de los primeros n numeros");
                Console.WriteLine("0) Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese una cadena: ");
                        string? cadena = Console.ReadLine();
                        Console.WriteLine($"Numero de vocales: {Vocales(cadena ?? string.Empty)}");
                        break;
                    case 2:
                        EjecutarEjercicio2();
                        break;
                    case 3:
                        EjecutarEjercicio3();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
