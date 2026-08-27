int opcion;

do
{
    Console.WriteLine("\n===== MENÚ =====");
    Console.WriteLine("1. Sumar dos números");
    Console.WriteLine("2. Ver si un número es primo");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numero1 + numero2}");
            break;

        case 2:
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            bool primo = numero > 1;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            Console.WriteLine(primo ? "Es primo." : "No es primo.");
            break;

        case 3:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 3);
