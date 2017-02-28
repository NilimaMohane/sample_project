using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentRegistration
    {
        public List<StudentSubjectAndMarks> GetStudentSubjectAndMarks()
        {

            List<StudentSubjectAndMarks> studentSubjectAndMaksList = new List<StudentSubjectAndMarks>();
            bool check = true;
            string subjectName;
            string totalMarks;
            string obtainedMark;
            string moreSubject;
            do
            {
                do
                {
                    Console.Write("Enter Subject Name:");
                    subjectName = Console.ReadLine().Trim();
                    Console.Write("Enter Total marks:");
                    totalMarks = Console.ReadLine().Trim();
                    Console.Write("Enter Obtained marks:");
                    obtainedMark = Console.ReadLine().Trim();
                    check = Validation.InputValidation(subjectName, totalMarks, obtainedMark);
                } while (check == false);

                studentSubjectAndMaksList.Add(new StudentSubjectAndMarks(subjectName, int.Parse(totalMarks), int.Parse(obtainedMark)));
                Console.Write("Press y to add more subject:");
                moreSubject = Console.ReadLine();

            } while (moreSubject == "y" || moreSubject == "Y");
            return studentSubjectAndMaksList;


        }
        public Student GetStudentDetails()
        {
            string studentName;
            bool check;
            do
            {
                Console.Write("Enter student name:");
                studentName = Console.ReadLine().Trim();
                check = Validation.StringValidation(studentName);
            } while (check == false);
            List<StudentSubjectAndMarks> studentSubjectAndMaksList = GetStudentSubjectAndMarks();
            return new Student(studentName, studentSubjectAndMaksList);
        }
    }
}
