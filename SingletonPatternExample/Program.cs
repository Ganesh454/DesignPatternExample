using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel.Invoke method to invoke multiple methods parallelly, This concept is introduced in .NET Framework 4.0

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            LogManager fromTeacher = LogManager.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            LogManager fromStudent = LogManager.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
