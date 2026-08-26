//consertir temperatura 

using System.Runtime.CompilerServices;

Console.Write("Ingrese la temperatura en Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;

Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
Console.WriteLine($"Kelvin: {kelvin:F2}");

//area y perimetro 

Console.Write("Ingrese el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el largo del rectángulo: ");
double largo = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el ancho del rectángulo: ");
double ancho = Convert.ToDouble(Console.ReadLine());

double areaCirculo = Math.PI * Math.Pow(radio, 2);
double perimetroCirculo = 2 * Math.PI * radio;

double areaRectangulo = largo * ancho;
double perimetroRectangulo = 2 * (largo + ancho);

Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
Console.WriteLine($"Perímetro del círculo: {perimetroCirculo:F2}");

Console.WriteLine($"Área del rectángulo: {areaRectangulo:F2}");
Console.WriteLine($"Perímetro del rectángulo: {perimetroRectangulo:F2}");

//cambio de moneda 
Console.Write("Ingrese el monto en pesos dominicanos: ");
double pesos = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tasa del dólar: ");
double tasaDolar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tasa del euro: ");
double tasaEuro = Convert.ToDouble(Console.ReadLine());

double dolares = pesos / tasaDolar;
double euros = pesos / tasaEuro;

Console.WriteLine($"Equivalente en dólares: ${dolares:F2}");
Console.WriteLine($"Equivalente en euros: €{euros:F2}");

//saludo personalizado 

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine()!;

Console.Write("Ingrese su apellido: ");
string apellido = Console.ReadLine()!;

string nombreCompleto = nombre + " " + apellido;
string nombreMayusculas = nombreCompleto.ToUpper();

int cantidadLetras = nombre.Length + apellido.Length;

string iniciales = nombre.Substring(0, 1).ToUpper() +
                   apellido.Substring(0, 1).ToUpper();

Console.WriteLine($"Nombre completo: {nombreMayusculas}");
Console.WriteLine($"Cantidad de letras: {cantidadLetras}");
Console.WriteLine($"Iniciales: {iniciales}");
