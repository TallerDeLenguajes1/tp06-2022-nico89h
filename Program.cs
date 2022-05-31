// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora jose = new Calculadora();
bool xd=true;
int nico=0;
while (xd)
{
    Console.WriteLine("Introduci el primer valor a dar");
    jose.X=Double.Parse(Console.ReadLine());
    Console.WriteLine("Introduci el 2do valor a dar");
    jose.Y=Double.Parse(Console.ReadLine());
    Console.WriteLine("La suma de los valores ingresados:"+jose.x+"y "+jose.y+"es" + jose.suma());
    Console.WriteLine("La multiplicacion de los anteriores valores es: " + jose.multiplicacion());
    Console.WriteLine("La division  es: " + jose.division());
    Console.WriteLine("La resta  es: " + jose.resta());
    Console.WriteLine("Queres seguir con la calculadora pibe");
    nico=Int32.Parse(Console.ReadLine());
    if (nico!=0)
    {
        Console.WriteLine("Fin de la ejecucion de la calculadora");
        xd=false;
    }
}

public class Calculadora
{
    public double x;
    public double y;
    public double X{
        get=>x;
        set=>x=value;
    } 
    public double Y{
        get=>y;
        set=>y=value;
    }
    public double suma(){
        return x+y;
    }
    public double multiplicacion(){
        return x*y;
    }
    public double division(){
        return x/y;
    }
    public double resta(){
        return x-y;
    }
}