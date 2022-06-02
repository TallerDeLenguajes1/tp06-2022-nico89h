//inicio de el punto 2
using System;
double MontoTresEmpleados=0;

Empleado []jose= new Empleado[3]; // creacion de el espacio de memoria para el arreglo
for (int i = 0; i < 3; i++)
{
    jose[i]=new Empleado();//le asigno a cada elemento de el arreglo una memoria
    System.Console.WriteLine("dame el nombre:");
    jose[i].Nombre=Console.ReadLine();
    System.Console.WriteLine("dame el apellido:");
    jose[i].Apellido=Console.ReadLine();
    System.Console.WriteLine("Cuanto cobras? :");
    jose[i].SueldoBasico=Double.Parse(Console.ReadLine());
    System.Console.WriteLine("Dame la fecha de ingreso: ");
    System.Console.WriteLine("Año: ");
    int año = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Mes: ");
    int Mes = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Dia: ");
    int Dia = Int32.Parse(Console.ReadLine());
    jose[i].FechaIngreso = new DateTime(año, Mes, Dia);
    System.Console.WriteLine("Dame la fecha de nacimiento: ");
    System.Console.WriteLine("Año: ");
    int año1 = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Mes: ");
    int Mes1 = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Dia: ");
    int Dia1 = Int32.Parse(Console.ReadLine());
    jose[i].FechaNacimiento = new DateTime(año1, Mes1, Dia1);
    Console.WriteLine("Cual es tu cargo en la empresa? 1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista,5-Investigador");
    int cargoxd=Int32.Parse(Console.ReadLine());
    switch (cargoxd)
    {
        case 1:
            jose[i].cargos=cargo.Auxiliar;
            break;
        case 2:
            jose[i].cargos=cargo.Administrativo;
            break;
        case 3:
            jose[i].cargos=cargo.Ingeniero;
            break;
        case 4:
            jose[i].cargos=cargo.Especialista;
            break;
        default:
            jose[i].cargos=cargo.Investigador;
            break;
    }
    Console.WriteLine("Cual es tu genero?1-masculino, 2-femenino,3-otros");
    int generos=Int32.Parse(Console.ReadLine());
    switch (generos)
    {
        case 1:
            jose[i].Genero=genero.M;
            break;
        case 2:
            jose[i].Genero=genero.F;
            break;
        default:
            jose[i].Genero=genero.X;
            break;
    }
    Console.WriteLine("Cual es tu estadoCivil? 1-soltero, 2-casado");
    int estado=Int32.Parse(Console.ReadLine());
    switch (estado)
    {
        case 2:
            jose[i].EstadoCivil=estadoCivil.C;
            break;
        default:
            jose[i].EstadoCivil=estadoCivil.S;
            break;
    }
    //ya esta todo cargrado en la clase

    int antiguedad = DateTime.Today.AddTicks(-jose[i].FechaIngreso.Ticks).Year - 1; // manera de obtener el año
    int edad = DateTime.Today.AddTicks(-jose[i].FechaNacimiento.Ticks).Year - 1; // edad del pibe
    Console.WriteLine("La antiguedad es: " + antiguedad);
    Console.WriteLine("La edad es: " + edad);

    if (jose[i].Genero==genero.F)
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
    //inicio de el calculo de adicional o salario
    double salario;
    if (jose[i].cargos==cargo.Ingeniero || jose[i].cargos==cargo.Especialista)
    {
        if (antiguedad<20)
        {
            salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100+15000;
            }
        }else
        {
            salario=jose[i].SueldoBasico+(jose[i].SueldoBasico*25)/100+jose[i].SueldoBasico*50/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100+15000;
            }
        }    
    }else
    {
        if (antiguedad<20)
        {
            salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+15000;
            }
        }else
        {
            salario=jose[i].SueldoBasico+(jose[i].SueldoBasico*25)/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+15000;
            }
        }
    }
    System.Console.WriteLine("El salario total es de : "+salario);
    MontoTresEmpleados=salario+MontoTresEmpleados;
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