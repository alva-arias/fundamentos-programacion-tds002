Console.Write("Ingrese una cantidad de segundos: ");
int segundosTotales = Convert.ToInt32(Console.ReadLine());

int horas = segundosTotales / 3600;
int minutos = (segundosTotales % 3600) / 60;
int segundos = segundosTotales % 60;

Console.WriteLine($"\nEquivalente: {horas} horas, {minutos} minutos y {segundos} segundos.");