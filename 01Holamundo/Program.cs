/*
Nombre: Alba Rosa Arias
Fecha: 24/08/2026
Descripción: Programa que muestra una tarjeta de presentación
con mis datos personales dentro de un marco de caracteres.
*/

//datos que apareceran en el mensaje
string Nombre = "alva rosa arias";
string matricula = "2026-0977";
string carrera = "Desarrollo de software";

// Imprime el marco superior de la tarjeta.

Console.WriteLine("========================================");
Console.WriteLine("|          TARJETA DE PRESENTACIÓN     |");
Console.WriteLine("========================================");

//imprime los datos
Console.WriteLine ($"nombre : {Nombre} ");
Console.WriteLine ($"Matricula : {matricula} ");
Console.WriteLine ($"Carrera : {carrera} ");
;