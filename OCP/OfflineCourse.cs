
namespace Ejmplos1.OCP
{
    public class OfflineCourse : Courses
    {
        public override void Subscribe(Student Std)
        {
            //Suscribiendo de manera Offline 
            Console.WriteLine($"El estudiante {std.Name} ha sido suscrito al curso offline {Title}");
        }
    }
    }
}
