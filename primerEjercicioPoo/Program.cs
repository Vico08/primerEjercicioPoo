using primerEjercicioPoo;

public class Program
{
    private static void Main(string[] args)
                            {
     //solicitar por pantalla cuanteas personas quiero
     //presentar y validar su edad
     
     Console.WriteLine("Cuantas personas quieres presentar?");
     
    int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) 
       {
            Console.WriteLine("Ingrese el nombre de la persona");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese la edad de la persona");
            int edad = Convert.ToInt32(Console.ReadLine());

            //vamos a crear estancia de la calse personas, significa q crearemos un 
            //nuevo objeto de la clase Personas

            Personas personas = new Personas(); // nuevo objeto de la clase Personas 
                                                //vamos a asignar los valores que el usuario ingreso a la propiedades de la clase Personas
            personas.Nombre = nombre;
            personas.Edad = edad;

            //vamos a invocar los metedos de la clase Personas

            personas.Presentar();
            personas.EsmayorDeEdad();

        }
    }
}