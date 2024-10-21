using TwoClassResources;

public class Program{
public static void Main(){

Console.WriteLine("Tu eres el numero uno Anderson");
Console.WriteLine("Escoga una Opcion");
Console.WriteLine("1: Sentecias Condicionales");
Console.WriteLine("2: Sentencias Repetitivas");

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
    return ConsoleColor.DarkGreen;  
    }
}

