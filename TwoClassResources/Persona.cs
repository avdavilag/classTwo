using System.ComponentModel;

namespace TWOCLASS;

    public class Persona
    {
        // Properties
        public string Nombre { get; set; }=null!;
        public string Apellido { get; set; }=default!;
        public String Direccion { get; set; }=string.Empty;

        public DateTime FechaNacimiento{ get;set;}
        public float Salario{get;set;}      // Constructor

    //public List<String> Telefono{get;set;}

    public override string ToString()
    {
        return Nombre;
    }


}

