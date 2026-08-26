Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

string paridad = numero % 2 == 0 ? "par" : "impar";
string signo = numero > 0 ? "positivo" : numero < 0 ? "negativo" : "cero";

Console.WriteLine($"El número es {paridad}.");
Console.WriteLine($"El número es {signo}.");