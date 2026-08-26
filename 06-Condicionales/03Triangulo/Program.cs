Console.Write("Ingrese el lado 1: ");
double lado1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el lado 2: ");
double lado2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 &&
    lado1 + lado3 > lado2 &&
    lado2 + lado3 > lado1)
{
    Console.WriteLine("Los lados forman un triángulo.");

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("El triángulo es equilátero.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("El triángulo es isósceles.");
    }
    else
    {
        Console.WriteLine("El triángulo es escaleno.");
    }
}
else
{
    Console.WriteLine("Los lados no forman un triángulo.");
}