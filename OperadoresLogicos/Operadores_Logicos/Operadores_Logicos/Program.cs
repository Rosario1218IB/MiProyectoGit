using System;

class Program
{
static void Main(string[] args)
{

    int edad = 0;
    int cantidad = 0;
    string genero = " ";
    string respuesta = "";

    Console.WriteLine("Escriba la edad de la persona");
    edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escriba el genero de la persona (M/F)");
    genero = Console.ReadLine();
    if(edad>18 && genero == "M" ){
        Console.WriteLine(" Bienvenido ");

    }
    else{
        Console.WriteLine(" Lo sentimos, no puede Ingresar ");
    }
    Console.WriteLine(" Fin del Programa ");
    Console.ReadLine();

    Console.WriteLine("El valor de la venta es 10000");
    Console.WriteLine("Escriba la cantidad de dinero en efectivo");
    cantidad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Tiene Tarjeta (s/n)");
    respuesta = Console.ReadLine();
    if(cantidad>10000 ||respuesta=="s"){ 

        Console.WriteLine("Su compra ha sido exitosa");
        }
    else{

        Console.WriteLine("Lo sentimos no puede realizar la compra");
    }
    Console.WriteLine(" Fin del Programa ");
    Console.ReadLine();
}
}
