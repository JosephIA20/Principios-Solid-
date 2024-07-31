

namespace Ejmplos1.OCP
{
    public class OnlineCourse : Courses
    {
        public override void Subscribe(Student Std)
        {
            //Subcribo a persona en curso online
            Console.WriteLine($"El estudiante {std.Name} ha sido suscrito al curso online {Title}");
        }
    }
}
