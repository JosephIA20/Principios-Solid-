using Ejmplos1.LSP.Ejemplos1.OCP;

namespace Ejmplos1.LSP
{

    public class LSPOnlineCourse : LSPCourse
    {

        public override void Subscribe(lspStudents std)
        {
            // Código para suscribirse a un curso Online
            Console.WriteLine($"Student {std.Names} has subscribed to Online course: {Title}");
        }


        public override string GetCourseDetails()
        {
            // Código para suscribirse a un curso offline
            return $"{Title} (Offline): Traditional classroom setting.";
        }
    }

}

