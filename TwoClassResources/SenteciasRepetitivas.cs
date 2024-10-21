using System;

namespace TwoClassResources;

public class SenteciasRepetitivas
{
    public static void Ejecutar(){
        Console.ForegroundColor=ConsoleColor.DarkYellow;

    for(int j=0;j<=10;j++){
      //  Console.WriteLine($"Valor de Anderson Vinicio Davila: {j}");
      SenteciasCondicionales.EjecutarSwitch();
    }

    Console.ForegroundColor=Program.ColorPrograma();

    }

}
