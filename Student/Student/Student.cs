using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string _studentName;
        private static int id;
        private int _studentId;
        private List<StudentSubjectAndMarks> _studentSubjectAndMarks;

        static Student()
        {
            Console.WriteLine("\nStudent Details\n");
        }
        public Student(string studentName, List<StudentSubjectAndMarks> studentSubjectAndMarks)
        {
            _studentId = ++id;
            StudentName = studentName;
            StudentSubjectandMarks = studentSubjectAndMarks;
        }
        public string StudentName
        {
            get
            {
                return _studentName;
            }

            set
            {
                _studentName = value;
            }

        }

        public int StudentId
        {
            get
            {
                return _studentId;
            }
        }

        internal List<StudentSubjectAndMarks> StudentSubjectandMarks
        {
            get
            {
                return _studentSubjectAndMarks;
            }

            set
            {
                _studentSubjectAndMarks = value;
            }
        }
        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            foreach (StudentSubjectAndMarks sm in StudentSubjectandMarks)
            {
                studentInfo.Append(sm);
            }

            return ("Student Id:" + StudentId + "\nStudent Name:" + StudentName + "\n" + studentInfo.ToString());

        }
    }
}
