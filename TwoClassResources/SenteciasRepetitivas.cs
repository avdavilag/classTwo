using System;
using System.Runtime.Serialization.Formatters;

namespace TwoClassResources;

public class SenteciasRepetitivas
{
  public static void Ejecutar()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    // for(int j=0;j<=10;j++){
    //   //  Console.WriteLine($"Valor de Anderson Vinicio Davila: {j}");
    //   SenteciasCondicionales.EjecutarSwitch();
    // }
    Console.ForegroundColor = Program.ColorPrograma();
    var arrayNumeros = new int[10];
    arrayNumeros[0] = 50;
    arrayNumeros[1] = 100;
    arrayNumeros[5] = 500;

    for (int i = 0; i < arrayNumeros.Length; i++)
    {

      Console.WriteLine($"El valor  es de i {arrayNumeros[i]}");
    }

    var arrayString = new String[3];
    arrayString[0] = "Anderson";
    arrayString[1] = "Davila";
    arrayString[2] = "Guerrero";
  //  arrayString[3] = "Diana Te Amo";

    for (int k = 0; k < arrayString.Length; k++)
    {
      Console.WriteLine($"El valor para la K es: {arrayString[k]}");
     

    }

var arrayString2=new string[]{
  "Anderson", "Vinicio","Davila","Guerrero","Diana","Caicedo"
};

for(int i=0;i<arrayString2.Length;i++){
  Console.WriteLine($"Mis Nombres Completos son: {arrayString2[i]} en el indice {i}");
}

  }

}
