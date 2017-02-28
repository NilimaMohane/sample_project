using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("Student Information");
        }
        static void Main(string[] args)
        {

            StudentRegistration studentRegistration = new StudentRegistration();
            Student student = studentRegistration.GetStudentDetails();
            Console.WriteLine(student);
        }
    }
}
