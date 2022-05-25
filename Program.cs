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
    Console.WriteLine("La suma es 10+20: " + jose.suma());
    Console.WriteLine("La multiplicacion de 10 y 20: " + jose.multiplicacion());
    Console.WriteLine("La division  de 20 y 10: " + jose.division());
    Console.WriteLine("La resta  de 20 y 10: " + jose.resta());
    Console.WriteLine("Queres seguir con la calculadora pibe");
    nico=Int32.Parse(Console.ReadLine());
    if (nico!=0)
    {
        xd=false;
    }
}

public class Calculadora
{
    private double x;
    private double y;
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