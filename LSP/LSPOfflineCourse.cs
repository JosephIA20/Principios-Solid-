using Ejmplos1.LSP.Ejemplos1.OCP;


namespace Ejmplos1.LSP;

        public class LSPOfflineCourse : LSPCourse
        {
            public override void Subscribe(lspStudents std)
            {
                // Código para suscribirse a un curso offline
                Console.WriteLine($"Student {std.Names} has subscribed to offline course: {Title}");
            }

            public override string GetCourseDetails()
            {
                return $"{Title} (Offline): Traditional classroom setting.";
            }
        }
