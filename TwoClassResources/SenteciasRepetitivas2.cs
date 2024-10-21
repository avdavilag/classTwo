using System;
using System.Collections;
using TWOCLASS;

namespace TwoClassResources;

public class SenteciasRepetitivas2
{

public static void Ejecutar(){
Console.ForegroundColor=ConsoleColor.DarkMagenta;

var lisOfPerson=new ArrayList();

for(int i=0;i<10;i++){

 lisOfPerson.Add(new Persona{
        Nombre=$"Persona {i}"
    });
}
   
foreach(var item in lisOfPerson){
    
}

    Console.ForegroundColor=Program.ColorPrograma();
}

}
