
Console.WriteLine("Bienvenido al menú de la cafetería");

Console.WriteLine("====== MENÚ DE CAFETERÍA ======");

Console.WriteLine("1. Café - RD$75");
Console.WriteLine("2. Sándwich - RD$150");
Console.WriteLine("3. Jugo natural - RD$100");
Console.WriteLine("4. Empanada - RD$80");
Console.WriteLine("5. Batida - RD$175");

Console.Write("Seleccione una opción: ");
int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad: ");
int cantidad = int.Parse(Console.ReadLine());

double precio = 0;

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado café.");
        precio = 75;
        break;

    case 2:
        Console.WriteLine("Ha seleccionado sándwich.");
        precio = 150;
        break;

    case 3:
        Console.WriteLine("Ha seleccionado jugo natural.");
        precio = 100;
        break;

    case 4:
        Console.WriteLine("Ha seleccionado empanada.");
        precio = 80;
        break;

    case 5:
        Console.WriteLine("Ha seleccionado batida.");
        precio = 175;
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}

if (opcion >= 1 && opcion <= 5)
{
    double total = precio * cantidad;
    Console.WriteLine($"Total a pagar: RD${total:F2}");
}