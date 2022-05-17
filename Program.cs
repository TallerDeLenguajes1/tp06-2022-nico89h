// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora jose = new Calculadora();
bool xd=true;
while (xd)
{
    Console.WriteLine("Introduci el primer valor a dar");
    double x=(double)Console.ReadLine():
    Console.WriteLine("Introduci el 2do valor a dar");
    double x=Console.ReadLine():
}
Console.WriteLine("La suma es 10+20: " + jose.suma(10,20));
Console.WriteLine("La multiplicacion de 10 y 20: " + jose.multiplicacion(10,20));
Console.WriteLine("La division  de 20 y 10: " + jose.multiplicacion(10,20));
Console.WriteLine("La resta  de 20 y 10: " + jose.resta(10,20));



public class Calculadora
{
    double x;
    double y;

    public double suma(double x, double y){
        return x+y;
    }
    public double multiplicacion(double x, double y){
        return x*y;
    }
    public double division(double x, double y){
        return x/y;
    }
    public double resta(double x, double y){
        return x-y;
    }

}