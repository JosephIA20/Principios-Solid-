using Ejmplos1.LSP.Ejemplos1.OCP;
using Ejmplos1.OCP;


namespace Ejmplos1.LSP
{
    public class LSPHybridCourse : LSPCourse
    {
        private LSPOnlineCourse onlineCourse;
        private LSPOfflineCourse offlineCourse;

        public LSPHybridCourse(int courseId, string title)
        {
            CourseId = courseId;
            Title = title;
            onlineCourse = new LSPOnlineCourse { CourseId = courseId, Title = title };
            offlineCourse = new LSPOfflineCourse { CourseId = courseId, Title = title };
        }

        public override void Subscribe(lspStudents std)
        {
            // Código para suscribirse a ambos cursos
            onlineCourse.Subscribe(std);
            offlineCourse.Subscribe(std);
        }

        public override string GetCourseDetails()
        {
            return $"{Title} (Hybrid): Combines online and offline elements.";
        }
    }
   
    public class ejemplosEjecucion()
    {
        public class Program
        {
            public static void Main()
            {
                lspStudents student = new lspStudents { StudentIds = 1, Names = "John Doe" };

                List<LSPCourse> courses = new List<LSPCourse>
            {
                new LSPOnlineCourse { CourseId = 101, Title = "C# Basics" },
                new LSPOfflineCourse { CourseId = 102, Title = "C# Advanced" },
                new LSPHybridCourse(103, "C# Complete")
            };

                foreach (var course in courses)
                {
                    course.Subscribe(student);
                    Console.WriteLine(course.GetCourseDetails());
                }
            }

            /// <summary>
            /// Ejemplo de lo que deberia de mostrarse en pantalla
            /// 
            /// Pantalla de consola 
            /// 
            /// 
            /// Student John Doe has subscribed to online course: C# Basics
            /// C# Basics (Online): Access from anywhere.
            /// Student John Doe has subscribed to offline course: C# Advanced
            /// C# Advanced (Offline): Traditional classroom setting.
            /// Student John Doe has subscribed to online course: C# Complete
            /// Student John Doe has subscribed to offline course: C# Complete
            /// C# Complete (Hybrid): Combines online and offline elements.
            /// </summary>

        }
    }

}


