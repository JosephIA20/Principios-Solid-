using Ejmplos1.OCP;

namespace Ejmplos1.LSP
{
    namespace Ejemplos1.OCP
    {
        /// <summary>
        /// El Principio de Sustitución de Liskov establece
        /// 
        /// Si S es una subclase de T, entonces los objetos de tipo T en un programa pueden ser
        /// reemplazados por objetos de tipo S sin alterar ninguna de las propiedades deseables del
        /// programa (corrección, tarea realizada, etc.)
        /// </summary>
        public abstract class LSPCourse
        {
            public int CourseId { get; set; }
            public string? Title { get; set; }

            public abstract void Subscribe(lspStudents std);
            public abstract string GetCourseDetails();
        }
    }

}
