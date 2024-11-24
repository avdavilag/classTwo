using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using TWOCLASS;

namespace TwoClassResources;

public class SenteciasRepetitivas2
{

    public static void Ejecutar()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        var lisOfPerson = new ArrayList();

        for (int i = 0; i < 10; i++)
        {

            lisOfPerson.Add(new Persona
            {
                Nombre = $"Persona {i}"
            });
        }

        var personaPreferida = new Persona { Nombre = "Persona 1" };

        lisOfPerson.Add(2);
        lisOfPerson.Add("Anderson eres el numero 1");
        lisOfPerson.Add(new DateTime(2018, 9, 18));
        lisOfPerson.Add(false);
        lisOfPerson.Add(5.4f);
        lisOfPerson.Add(new Persona { Nombre = "Persona" });
        Console.WriteLine("Coleccion de foreach");

        foreach (var item in lisOfPerson)
        {

            Console.WriteLine($"{item} GetHasCode: {item.GetHashCode()}");
        }
        Program.Separador();

        lisOfPerson.Remove(5);
        lisOfPerson.RemoveAt(0);
        lisOfPerson.Remove(new Persona { Nombre = "Persona 1" });


        Console.WriteLine("Coleccion con For");
        for (int i = 0; i < lisOfPerson.Count; i++)
        {
            Console.WriteLine($"{lisOfPerson[i]}: GetHashCode {lisOfPerson[i].GetHashCode()}");
        }
        Console.ForegroundColor = Program.ColorPrograma();

        var lista = new List<Persona>();
        lista.AddRange(new [] {
        new Persona(){Id=1,Nombre="Anderson Davila"},
        new Persona(){Id=2,Nombre="Diana Caicedo"},
        new Persona(){Id=3,Nombre="Marlene Guerrero"},
        new Persona(){Id=4,Nombre="Maria Diaz"},
        new Persona(){Id=5,Nombre="Vinicio Guerrero"},
        new Persona(){Id=6,Nombre="Elizabeh Cobacango"},
        new Persona(){Id=7,Nombre="Vinicio Guerrero"},
     });

        foreach (var heroe in lista)
        {
            Console.WriteLine(heroe);
        }

        Program.Separador();

        lista.Remove(new Persona { Nombre = "Vinicio Guerrero" });

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        Console.ForegroundColor = Program.ColorPrograma();
    }

public static void EjecutarBucleWhile(){
    Console.ForegroundColor=ConsoleColor.Yellow;

var personsArray=new string[]{"Anderson Davila","Anderson Davila2","Anderson Davila3"};

var superheroes=new List<Persona>();
var arrayPersona =new string[]{"Diana","Elizabeth","Marlene","Maria"};
superheroes.AddRange(arrayPersona.Select(x=>new Persona(){Nombre= x}));

//  WHILE
while(superheroes.Count < 6 ){
   Console.WriteLine("Ingrese nombre: ");
   var personaje= new Persona();
    personaje.Nombre=Console.ReadLine();
    personaje.Id=superheroes.Count+1;
    superheroes.Add(personaje);
Console.WriteLine("Ingresa el salario: ");
if(float.TryParse(Console.ReadLine(),out var salario)){
    personaje.Salario=salario;
}else{
    Console.WriteLine("El Valor del salario es Incorrecto");
    System.Diagnostics.Debugger.Break();
}



if(superheroes.Count==4){
    System.Diagnostics.Debugger.Break();
}
    
}

Console.WriteLine("Ingreso de lista ya terminado - WHILE");
Program.Separador();
Console.WriteLine("Esta linea debe aparecer solo cuando estoy en el modo desarrollo");


//BUCLE DO WHILE
do{
    Console.WriteLine("Ingrese nombre: ");
   var personaje= new Persona();
    personaje.Nombre=Console.ReadLine();
    personaje.Id=superheroes.Count+1;
    superheroes.Add(personaje);
    Program.Separador();   
}while (superheroes.Count <6);

Console.WriteLine("Ingreso de Lista ya terminado - DO WHILE");
foreach(var personaje in superheroes){
    Console.WriteLine(personaje);
}
Console.ForegroundColor=Program.ColorPrograma();

}
}
