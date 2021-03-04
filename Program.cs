using System;

namespace personas
{
    class Program
    {
        static void Main(string[] args)
        {
           Persona persona = new Persona("Alberto", "Dombledore");

           persona.Presentarse();
           Console.WriteLine(persona.nombre);
           Console.WriteLine(persona.apellido);

           Persona persona2 = new Persona("Mario", null);
            persona2.Presentarse();
           Console.WriteLine(persona2.nombre);
           Console.WriteLine(persona2.apellido);
        }
    }
}
