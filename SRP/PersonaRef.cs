namespace Ejmplos1.SRP
{
    public class PersonaRef
    {
        //El mismo ejemplo pero con una Refactorización en el cual se cumple con el Principio de responsabilidad unica

        private string nombre;
        private int Edad;               //Joseph Almanzar 2023-0696
        private string direccion;
        private string correoElectronico;

        /// <summary>
        /// Esta clase solo tiene una razon de existir o de cambiar
        /// Por lo tanto aquí se cumple con el principio de Responsabilidad Unica
        /// </summary>
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre{nombre}");
            Console.WriteLine($"Edad{Edad}");
            Console.WriteLine($"Dirección{direccion}");
            Console.WriteLine($"CorreoElectrónico{correoElectronico}");
        }

        ///<summary>
        ///Ahora cada clase tiene solo una unica responsabilidad y una sola razon para cambiar.
        /// </summary>
    }
    public class Correos
    {
        public void EnviarCorreosElectrónico()
        {
            //Logica para enviar correos
        }
    }

    public class Program
    {
        PersonaRef personaRef = new PersonaRef();
        Correos corres = new Correos();

    }
}
