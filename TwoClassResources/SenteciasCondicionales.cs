using System;
using TWOCLASS;

namespace TwoClassResources;

public class SenteciasCondicionales
{
 public static void EjectarIf(){

Console.ForegroundColor=ConsoleColor.DarkGreen;

Console.WriteLine("Sentencias Condicionales");


   var random=new Random();
    var persona=new Persona
      {
         Nombre="Juan",
         Apellido="Perez",
         Direccion="Calle 123",
         FechaNacimiento=new DateTime(1980,1,1),
         Salario=random.Next(500,4000)
         //Salario=975
      };
      if(persona.Salario<1000){
         ImprimirMensaje($"Tu Salario esta por debajo del minimo  {persona.Salario:C2}");

      }else if(persona.Salario>2000){
         ImprimirMensaje($"Poco mas del promedio {persona.Salario:C2}"); 
      }else if(persona.Salario<=2500 && persona.Salario<=3000){
         ImprimirMensaje($"Salario Muy Aceptable  {persona.Salario:C2}");
      }else if(persona.Salario>3500){
         ImprimirMensaje($"Salario Bien Remunerado {persona.Salario:C2}");
      }
      else{
         ImprimirMensaje($"Vaya! me sorprende tu Salario {persona.Salario:C2}");
      }
   
   Console.ForegroundColor=Program.ColorPrograma();
 }


public static void EjecutarSwitch(){
  Console.ForegroundColor=ConsoleColor.DarkCyan;
   String mensaje;

      var random=new Random();

       var persona=new Persona
      {
         Nombre="Juan",
         Apellido="Perez",
         Direccion="Calle 123",
         FechaNacimiento=new DateTime(1980,1,1),
         Salario=random.Next(500,4000)
         //Salario=975
      };
    mensaje = persona.Salario switch
      {
         < 1000 => $"Tu Salario esta por debajo del minimo  {persona.Salario:C2}",
         <= 2000 => $"Poco mas del promedio {persona.Salario:C2}",
         >=2500 and <= 3000 => $"Salario Muy Aceptable  {persona.Salario:C2}",
         > 3000 => $"Salario bien Remunerado  {persona.Salario:C2}",
         _ => $"Vaya! me sorprende tu Salario {persona.Salario:C2}"
      };
      
      ImprimirMensaje(mensaje);
         Console.ReadLine();
            Console.ForegroundColor=Program.ColorPrograma();

}

   private static void ImprimirMensaje(string mensaje,bool error=false){
      Console.ForegroundColor=error ? ConsoleColor.Red : ConsoleColor.Cyan;
      Console.WriteLine(mensaje);
   }
}
