//inicio de el punto 2
using System;
Empleado jose= new Empleado();
System.Console.WriteLine("dame el nombre:");
jose.Nombre=Console.ReadLine();
System.Console.WriteLine("dame el apellido:");
jose.Apellido=Console.ReadLine();
System.Console.WriteLine("Cuanto cobras? :");
jose.SueldoBasico=Double.Parse(Console.ReadLine());
System.Console.WriteLine("Dame la fecha de ingreso: ");
System.Console.WriteLine("Año: ");
int año = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Mes: ");
int Mes = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Dia: ");
int Dia = Int32.Parse(Console.ReadLine());
jose.FechaIngreso = new DateTime(año, Mes, Dia);
System.Console.WriteLine("Dame la fecha de nacimiento: ");
System.Console.WriteLine("Año: ");
int año1 = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Mes: ");
int Mes1 = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Dia: ");
int Dia1 = Int32.Parse(Console.ReadLine());
jose.FechaNacimiento = new DateTime(año1, Mes1, Dia1);
Console.WriteLine("Cual es tu cargo en la empresa? 1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista,5-Investigador");
int cargoxd=Int32.Parse(Console.ReadLine());
switch (cargoxd)
{
    case 1:
        jose.cargos=cargo.Auxiliar;
        break;
    case 2:
        jose.cargos=cargo.Administrativo;
        break;
    case 3:
        jose.cargos=cargo.Ingeniero;
        break;
    case 4:
        jose.cargos=cargo.Especialista;
        break;
    default:
        jose.cargos=cargo.Investigador;
        break;
}
Console.WriteLine("Cual es tu genero?1-masculino, 2-femenino,3-otros");
int generos=Int32.Parse(Console.ReadLine());
switch (generos)
{
    case 1:
        jose.Genero=genero.M;
        break;
    case 2:
        jose.Genero=genero.F;
        break;
    default:
        jose.Genero=genero.X;
        break;
}
Console.WriteLine("Cual es tu estadoCivil? 1-soltero, 2-casado");
int estado=Int32.Parse(Console.ReadLine());
switch (estado)
{
    case 2:
        jose.EstadoCivil=estadoCivil.C;
        break;
    default:
        jose.EstadoCivil=estadoCivil.S;
        break;
}
//ya esta todo cargrado en la clase

int antiguedad = DateTime.Today.AddTicks(-jose.FechaIngreso.Ticks).Year - 1; // manera de obtener el año
int edad = DateTime.Today.AddTicks(-jose.FechaNacimiento.Ticks).Year - 1; // edad del pibe
Console.WriteLine("La antiguedad es: " + antiguedad);
Console.WriteLine("La edad es: " + edad);

if (jose.Genero==genero.F)
{
    if (edad>=60)
    {
        System.Console.WriteLine("Ya se puede jubilar");
    }else
    {
        System.Console.WriteLine("Le quedan :"+(60-edad)+"Para poder jubilarse");
    }
}else
{
    if (edad>=65)
    {
        System.Console.WriteLine("Ya se puede jubilar");
    }else
    {
        System.Console.WriteLine("Le quedan :"+(65-edad)+"Para poder jubilarse");
    }
}
enum genero {
    F ,
    M,
    X
}

enum cargo{

    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
enum estadoCivil
{
    S,
    C
}
class Empleado
{
    public string Nombre;
    public string Apellido;
    public genero Genero;
    public estadoCivil EstadoCivil;
    public cargo cargos;
    public DateTime FechaNacimiento;
    public DateTime FechaIngreso;
    public double SueldoBasico;
}