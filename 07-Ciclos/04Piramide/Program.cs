Console.Write("Ingrese la altura de la pirámide: ");
int altura = int.Parse(Console.ReadLine());

for (int i = 1; i <= altura; i++)
{
    for (int espacios = 1; espacios <= altura - i; espacios++)
    {
        Console.Write(" ");
    }

    for (int asteriscos = 1; asteriscos <= (2 * i - 1); asteriscos++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}