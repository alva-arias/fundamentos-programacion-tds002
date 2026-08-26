Console.Write("Horas trabajadas: ");
double horas = Convert.ToDouble(Console.ReadLine());

Console.Write("Tarifa por hora: ");
double tarifa = Convert.ToDouble(Console.ReadLine());

double salarioBruto = horas * tarifa;
double afp = salarioBruto * 0.0287;
double sfs = salarioBruto * 0.0304;
double salarioNeto = salarioBruto - afp - sfs;

Console.WriteLine("\n========== NÓMINA ==========");
Console.WriteLine($"Salario bruto: {salarioBruto:C}");
Console.WriteLine($"Descuento AFP (2.87%): {afp:C}");
Console.WriteLine($"Descuento SFS (3.04%): {sfs:C}");
Console.WriteLine($"Salario neto: {salarioNeto:C}");
Console.WriteLine("============================");