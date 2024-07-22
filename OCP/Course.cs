
namespace Ejmplos1.OCP
{
    public  abstract class Courses // Esta clase sirve para implementar un método de suscripción  
    {
        /// <summary>
        /// el principio abierto/cerrado (OCP). 
        /// Este principio establece que las entidades de software (clases, módulos, funciones, etc.) deben estar abiertas para la extensión,
        /// pero cerradas para la modificación.
        /// </summary>
        public int CourseId { get; set; }
        public string? Title { get; set; }

        public abstract void Subscribe(Student Std);
    }
}
 