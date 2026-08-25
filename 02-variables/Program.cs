Console.WriteLine("cual es tu nombre?: ");
string nombre = Console.ReadLine();

Console.WriteLine("cual es tu edad?: ");
int edad = int.Parse (Console.ReadLine());

Console.WriteLine("cual es tu altura?: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Ingrese la inicial de su apellido: ");
char inicialApellido = char.Parse(Console.ReadLine()!);

Console.Write("¿Es estudiante activo? (true/false): ");
bool estudianteActivo = bool.Parse(Console.ReadLine()!);

Console.WriteLine(
    $"Nombre: {nombre} | Edad: {edad} | Estatura: {altura} | " +
    $"Inicial: {inicialApellido} | Estudiante activo: {estudianteActivo} | "
);


// Operadores en acción: pide dos números enteros al usuario.
Console.Write("\nIngrese el primer número entero: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número entero: ");
int numero2 = int.Parse(Console.ReadLine()!);

// Operadores aritméticos.
Console.WriteLine($"\nSuma: {numero1 + numero2}");
Console.WriteLine($"Resta: {numero1 - numero2}");
Console.WriteLine($"Multiplicación: {numero1 * numero2}");
Console.WriteLine($"División entera: {numero1 / numero2}");
Console.WriteLine($"División real: {(double)numero1 / numero2}");
Console.WriteLine($"Módulo: {numero1 % numero2}");

// Comparaciones relacionales.
Console.WriteLine($"\n{numero1} > {numero2}: {numero1 > numero2}");
Console.WriteLine($"{numero1} == {numero2}: {numero1 == numero2}");
Console.WriteLine($"{numero1} != {numero2}: {numero1 != numero2}");

// Operadores lógicos.
Console.WriteLine($"Ambos son mayores que 0: {numero1 > 0 && numero2 > 0}");
Console.WriteLine($"Al menos uno es mayor que 0: {numero1 > 0 || numero2 > 0}");

// Precedencia de operadores.

// 5 + 3 * 2 = 11 porque la multiplicación se realiza antes que la suma.
// (5 + 3) * 2 = 16 porque los paréntesis tienen prioridad.
// 10 / 4 = 2 porque ambos son enteros y se realiza división entera.
// 10 / 4.0 = 2.5 porque 4.0 es double y la división es real.
// 10 % 4 = 2 porque % devuelve el residuo de la división.

Console.WriteLine("\n--- Precedencia ---");
Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}");
Console.WriteLine($"(5 + 3) * 2 = {(5 + 3) * 2}");
Console.WriteLine($"10 / 4 = {10 / 4}");
Console.WriteLine($"10 / 4.0 = {10 / 4.0}");
Console.WriteLine($"10 % 4 = {10 % 4}");