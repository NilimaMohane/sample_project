using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Validation
    {
        public static bool InputValidation(string name, string totalMarks, string obtainedMarks)
        {
            bool check;
            check = StringValidation(name);
            if (check == false)
            {
                return false;
            }
            check = IntergerValidation(totalMarks);
            if (check == false)
            {
                return false;
            }
            check = IntergerValidation(obtainedMarks);
            if (check == false || (int.Parse(totalMarks) < int.Parse(obtainedMarks)))
            {
                Console.WriteLine("Obtained marks cannot be more than total marks");
                return false;
            }
            return true;
        }
        public static bool StringValidation(string name)
        {
            if (name.Length == 0)
            {
                Console.WriteLine("String is empty enter first");
                return false;
            }
            foreach (char character in name)
            {
                if (!((character >= 65 && character <= 90) || (character >= 97 && character <= 122)))
                {
                    Console.WriteLine("Enter  valid Name");
                    return false;
                }
            }
            return true;
        }
        public static bool IntergerValidation(string value)
        {
            if (value.Length == 0)
            {
                Console.WriteLine("String is empty enter first");
                return false;
            }
            foreach (char character in value)
            {
                if (!(character >= 48 && character <= 57))
                {
                    Console.WriteLine("Enter valid Marks");
                    return false;
                }
            }
            return true;
        }
        /* private static bool IsEmpty(string studentName,string subjectName,string totalMarks,string obtainedMarks)
         {
             if(studentName.Length==0)
             {

             }
         }*/
    }
}
