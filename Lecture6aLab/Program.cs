using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6aLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRecord record;
            StudentRecord record1 = new StudentRecord();

            int quiz1;
            int quiz2;
            int quiz3;
            int midterm;
            int final;

            int newquiz1;
            int newquiz2;
            int newquiz3;
            int midterm1;
            int final1;

            Console.WriteLine("input all 5 scores for record one, pressing enter after each.");
            quiz1 = Int32.Parse(Console.ReadLine());
            quiz2 = Int32.Parse(Console.ReadLine());
            quiz3 = Int32.Parse(Console.ReadLine());
            midterm = Int32.Parse(Console.ReadLine());
            final = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input all 5 scores for record two, pressing enter after each.");
            newquiz1 = Int32.Parse(Console.ReadLine());
            newquiz2 = Int32.Parse(Console.ReadLine());
            newquiz3 = Int32.Parse(Console.ReadLine());
            midterm1 = Int32.Parse(Console.ReadLine());
            final1 = Int32.Parse(Console.ReadLine());

            record = new StudentRecord(quiz1, quiz2, quiz3, midterm, final);

            record1.SetQuiz(1, newquiz1);
            record1.SetQuiz(2, newquiz2);
            record1.SetQuiz(3, newquiz3);
            record1.SetMidterm(midterm1);
            record1.SetFinal(final1);

            Console.WriteLine("First record: {0}", record.ToString());
            Console.WriteLine("Second record: {0}", record1.ToString());
            Console.WriteLine(record.Equals(record1));
            Console.ReadLine();
        }
    }
}
