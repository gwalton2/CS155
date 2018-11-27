using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    class StudentStats
    {
        private List<Student> students;

        public StudentStats()
        {
            students = new List<Student>();
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Sort()
        {
            students.Sort();
        }

        public double Average()
        {
            int total = 0;
            foreach (Student student in students)
            {
                total += student.Score;
            }
            return total / (double)students.Count;
        }

        public double Median()
        {
            int length = students.Count;

            if (students.Count % 2 == 0)
            {
                return (students[(length / 2) - 1].Score + students[length / 2].Score) / (double)2;
            }
            else
            {
                return students[length / 2].Score;
            }
        }
    }
}
