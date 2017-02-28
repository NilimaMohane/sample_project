using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentSubjectAndMarks
    {
        private string _subject;
        private int _totalMarks;
        private int _obtainedMarks;

        public StudentSubjectAndMarks(string subject, int totalMarks, int obtainedMarks)
        {
            Subject = subject;
            TotalMarks = totalMarks;
            ObtainedMarks = obtainedMarks;

        }
        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        public int TotalMarks
        {
            get
            {
                return _totalMarks;
            }

            set
            {
                _totalMarks = value;
            }
        }

        public int ObtainedMarks
        {
            get
            {
                return _obtainedMarks;
            }

            set
            {
                _obtainedMarks = value;
            }
        }
        public override string ToString()
        {
            return ("Subject:" + Subject + "\nTotal Marks:" + TotalMarks + "\nObtained Marks:" + ObtainedMarks + "\n");
        }
    }
}
