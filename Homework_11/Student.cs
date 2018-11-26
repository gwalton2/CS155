using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        public Student(string first, string last, int score)
        {
            FirstName = first;
            LastName = last;
            Score = score;
        }

        public int CompareTo(object obj)
        {
            Student other = (Student)obj;
            return Score - other.Score;
        }
    }
}
