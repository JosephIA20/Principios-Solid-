namespace Ejmplos1.SRP
{
    public class Persona
    { /// <summary>
      /// Representa una persona con nombre, edad, dirección y correo electrónico.
      /// </summary>
        private string nombre;
        private int Edad;               //Joseph Almanzar 2023-0696
        private string direccion;
        private string correoElectronico;


        /*
      * SRP o Principio de responsabilidad única se refiere a que una clase, método o
      * modulo debería de tener solamente una responsabilidad, es decir, solamente una
      * razón para cambiar
      */


        /// <summary>
        /// Este método tiene como objetivo enviar correos electronicos, pero esto no tiene sentido 
        /// ya que este se encuentra en la clase Persona
        /// Segun el principio de responsabilidad unica, este método no debería de pertenecer a esta clase
        /// ya que la clase Persona tendría 2 funciones que proveer
        /// 1-Representar la entidad Persona
        /// 2-Enviar correcto electronicos
        /// Por lo tanto este principio se esta violentando en esta clase
        /// </summary>
        /// <param name="Mensaje"></param>
        public void EnviarCorreosElectronicos(string Mensaje)
        {
            //Logia para enviar correos
        }

        /// <summary>
        /// Este método entra en las reglas dep principio de responsabilidad unica
        /// ya que el método utiliza las propiedades de tipo Persona
        /// y los muestra en pantalla
        /// </summary>
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre{nombre}");
            Console.WriteLine($"Edad{Edad}");
            Console.WriteLine($"Dirección{direccion}");
            Console.WriteLine($"CorreoElectrónico{correoElectronico}");
        }

    }


}
