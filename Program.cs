//inicio de el punto 2
using System;
double MontoTresEmpleados=0;
int []edad= new int[3];
int []antiguedad=new int[3];
double []salario=new double[3];
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

    antiguedad[i] = DateTime.Today.AddTicks(-jose[i].FechaIngreso.Ticks).Year - 1; // manera de obtener el año
    
    edad[i] = DateTime.Today.AddTicks(-jose[i].FechaNacimiento.Ticks).Year - 1; // edad del pibe
    Console.WriteLine("La antiguedad es: " + antiguedad[i]);
    Console.WriteLine("La edad es: " + edad[i]);

    if (jose[i].Genero==genero.F)
    {
        if (edad[i]>=60)
        {
            System.Console.WriteLine("Ya se puede jubilar");
        }else
        {
            System.Console.WriteLine("Le quedan :"+(60-edad[i])+"Para poder jubilarse");
        }
    }else
    {
        if (edad[i]>=65)
        {
            System.Console.WriteLine("Ya se puede jubilar");
        }else
        {
            System.Console.WriteLine("Le quedan :"+(65-edad[i])+"Para poder jubilarse");
        }
    }
    //inicio de el calculo de adicional o salario
    
    if (jose[i].cargos==cargo.Ingeniero || jose[i].cargos==cargo.Especialista)
    {
        if (antiguedad[i]<20)
        {
            salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100+15000;
            }
        }else
        {
            salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico*25)/100+jose[i].SueldoBasico*50/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+jose[i].SueldoBasico*50/100+15000;
            }
        }    
    }else
    {
        if (antiguedad[i]<20)
        {
            salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+15000;
            }
        }else
        {
            salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico*25)/100;
            if (jose[i].EstadoCivil==estadoCivil.C)
            {
                salario[i]=jose[i].SueldoBasico+(jose[i].SueldoBasico)/100+15000;
            }
        }
    }
    System.Console.WriteLine("El salario total es de : "+salario[i]);
    MontoTresEmpleados=salario[i]+MontoTresEmpleados;
}
int mayor=0;
int r=0;
for (int i = 0; i < 3; i++)
{
    if (i==0)
    {
        mayor=edad[i];
        r=i;
    }else
    {
        if (mayor<edad[i])
        {
           mayor=edad[i];
           r=i; 
        }
    }
}
//mostrando el mas proximo a jubilarse
System.Console.WriteLine("El nombre de la persona mas proxima a jubilarese es: "+ jose[r].Nombre);
System.Console.WriteLine("El salario de el es : "+ salario[r]);
System.Console.WriteLine("La antiguedad es de: "+ antiguedad[r]);
System.Console.WriteLine("La edad de la persona es: "+ edad[r]);
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