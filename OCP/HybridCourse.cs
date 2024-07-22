
namespace Ejmplos1.OCP
{

    public class HybridCourse : Courses    
    {
        /// <summary>
        /// Esta clase ayuda a seguir el principio abierto cerrado ya que no se modifica la clase course 
        /// y tampoco se modica las clases offlineCourse y OnlineCouse, esta clase solo las utiliza como sus propiedades 
        /// para agregar un curso de algun tipo de las 2 
        /// </summary>
        private OnlineCourse onlineCourse;
        private OfflineCourse offlineCourse;

        public HybridCourse(int courseId, string title)
        {
            CourseId = courseId;
            Title = title;
            onlineCourse = new OnlineCourse { CourseId = courseId, Title = title };
            offlineCourse = new OfflineCourse { CourseId = courseId, Title = title };
        }

        public override void Subscribe(Student std)
        {
            // Código para suscribirse a ambos cursos
            onlineCourse.Subscribe(std);
            offlineCourse.Subscribe(std);
        }
    }

}
