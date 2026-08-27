Random random = new Random();
string jugar;

do
{
    int secreto = random.Next(1, 101);
    int intentos = 0;
    int numero;

    Console.WriteLine("\nAdivina el número entre 1 y 100.");

    do
    {
        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());
        intentos++;

        if (numero < secreto)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else if (numero > secreto)
        {
            Console.WriteLine("El número secreto es menor.");
        }
        else
        {
            Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");
        }

    } while (numero != secreto);

    Console.Write("¿Quieres volver a jugar? (s/n): ");
    jugar = Console.ReadLine().ToLower();

} while (jugar == "s");
