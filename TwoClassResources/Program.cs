﻿using TwoClassResources;

public class Program{
public static void Main(){

Console.WriteLine("Tu eres el numero uno Anderson");
Console.WriteLine("Escoga una Opcion");
Console.WriteLine("1: Sentecias Condicionales");
Console.WriteLine("2: Sentencias Repetitivas");
Console.WriteLine("3: Sentencias Repetitivas2");
Console.WriteLine("4: Bluce While");
Console.WriteLine("5: Fin del Programa");

    if(int.TryParse(Console.ReadLine(),out var opcion))
{
    switch(opcion)
    {
        case 1: 
        SenteciasCondicionales.EjectarIf();
        Console.ReadLine();
        SenteciasCondicionales.EjecutarSwitch();
        break;
        case 2: 
        SenteciasRepetitivas.Ejecutar();
        break;
         case 3: 
        SenteciasRepetitivas2.Ejecutar();
        break;
        case 4: 
        SenteciasRepetitivas2.EjecutarBucleWhile();
        break;
        case 5: 
        Console.WriteLine("Saliste del Sistema");
        break;
        default:
        Console.WriteLine("Opcion Incorrecta");
        break;
    }
}
    Console.WriteLine("Fin :-)");
    Console.ReadLine();
}

public static ConsoleColor ColorPrograma(){
    return ConsoleColor.Green;  
    }
    public static void Separador()
    {
        Console.WriteLine(new string('=',60));
        Console.WriteLine(Environment.NewLine);
    }



}

