Console.Write("Ingrese la distancia del viaje en km: ");
double distancia = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el consumo del vehículo (km por galón): ");
double consumo = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el precio del galón: ");
double precioGalon = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el número de pasajeros: ");
int pasajeros = Convert.ToInt32(Console.ReadLine());

double galonesNecesarios = distancia / consumo;
double costoTotal = galonesNecesarios * precioGalon;
double costoPorPasajero = costoTotal / pasajeros;

Console.WriteLine("\n========== CALCULADORA DE VIAJE ==========");
Console.WriteLine($"Distancia: {distancia:F2} km");
Console.WriteLine($"Galones necesarios: {galonesNecesarios:F2}");
Console.WriteLine($"Costo total del combustible: {costoTotal:C}");
Console.WriteLine($"Cantidad de pasajeros: {pasajeros}");
Console.WriteLine($"Pago por pasajero: {costoPorPasajero:C}");
Console.WriteLine("===========================================");
