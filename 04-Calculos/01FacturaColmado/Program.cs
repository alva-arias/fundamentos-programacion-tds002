Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine()!;

Console.WriteLine("\nProducto 1");
Console.Write("Nombre: ");
string producto1 = Console.ReadLine()!;
Console.Write("Precio: ");
double precio1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Cantidad: ");
int cantidad1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nProducto 2");
Console.Write("Nombre: ");
string producto2 = Console.ReadLine()!;
Console.Write("Precio: ");
double precio2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Cantidad: ");
int cantidad2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nProducto 3");
Console.Write("Nombre: ");
string producto3 = Console.ReadLine()!;
Console.Write("Precio: ");
double precio3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Cantidad: ");
int cantidad3 = Convert.ToInt32(Console.ReadLine());

double subtotal1 = precio1 * cantidad1;
double subtotal2 = precio2 * cantidad2;
double subtotal3 = precio3 * cantidad3;

double subtotal = subtotal1 + subtotal2 + subtotal3;
double itbis = subtotal * 0.18;
double total = subtotal + itbis;

Console.WriteLine("\n==========================================");
Console.WriteLine("              FACTURA");
Console.WriteLine("==========================================");
Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine("------------------------------------------");
Console.WriteLine($"{"Producto",-15} {"Cant.",5} {"Precio",10} {"Importe",10}");
Console.WriteLine("------------------------------------------");

Console.WriteLine($"{producto1,-15} {cantidad1,5} {precio1,10:C} {subtotal1,10:C}");
Console.WriteLine($"{producto2,-15} {cantidad2,5} {precio2,10:C} {subtotal2,10:C}");
Console.WriteLine($"{producto3,-15} {cantidad3,5} {precio3,10:C} {subtotal3,10:C}");

Console.WriteLine("------------------------------------------");
Console.WriteLine($"{"Subtotal:",-30} {subtotal,10:C}");
Console.WriteLine($"{"ITBIS (18%):",-30} {itbis,10:C}");
Console.WriteLine($"{"TOTAL:",-30} {total,10:C}");
Console.WriteLine("==========================================");