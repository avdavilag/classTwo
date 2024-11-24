using System.ComponentModel;

namespace TWOCLASS;

    public class Persona : IEquatable<Persona>
    {

        public int Id{get;set;}
        // Properties
        public string Nombre { get; set; }=null!;
        public string Apellido { get; set; }=default!;
        public String Direccion { get; set; }=string.Empty;

        public DateTime FechaNacimiento{ get;set;}
        public float Salario{get;set;}      // Constructor

    //public List<String> Telefono{get;set;}

    public bool Equals(Persona? other)
    {
        return Nombre.Equals(other?.Nombre);
    }
    public override string ToString()
    {
        return $"Id={Id} | Nombre={Nombre}";
    }
    public String MyName(){

        return "Anderson Vinicio Davila Guerrero";
    }

public override int GetHashCode(){
    return Nombre.GetHashCode();
}


}

