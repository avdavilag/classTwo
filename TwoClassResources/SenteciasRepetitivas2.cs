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

lisOfPerson.Add(2);
lisOfPerson.Add("Anderson eres el numero 1");
lisOfPerson.Add(new DateTime(2018,9,18));
lisOfPerson.Add(false);



   
foreach(var item in lisOfPerson){

    Console.WriteLine("Item de var "+item);
}

    Console.ForegroundColor=Program.ColorPrograma();
}

}
