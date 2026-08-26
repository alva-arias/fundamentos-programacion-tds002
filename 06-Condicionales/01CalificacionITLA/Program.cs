
Console.Write("Ingresa tu calificacion: ");
int calificacion = int.Parse(Console.ReadLine());

if (calificacion >= 90)
{
    Console.WriteLine("Sacaste: A");
}
 

else if (calificacion >= 80)
{
    Console.WriteLine("Sacaste: B");
}

else if (calificacion >= 70)
{
    Console.WriteLine("Sacaste: C");
}

else
{
    Console.WriteLine("Sacaste: F");
}

