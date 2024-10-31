using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerEjercicioPoo
{
    internal class Personas
    {
     //propiedades de mi clase Personas
     
     public string Nombre { get; set; } //forma definir propiedades 

        public int Edad { get; set; }

        //metodo de mi clase Personas
        // presentarse

        public void Presentar()
                {
                Console.WriteLine($"Hola! mi nombre es {Nombre} y tengo {Edad} años");
                }
        public void EsmayorDeEdad()
        {            
            if (Edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            else
            {
                Console.WriteLine("eres menor de edad");
            }
        }
    }
}

