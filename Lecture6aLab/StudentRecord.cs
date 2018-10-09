using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6aLab
{
    class StudentRecord
    {
        private int[] quiz;
        private int midterm;
        private int final;

        public StudentRecord()
        {
            quiz = new int[3];
        }

        public StudentRecord(int quiz1, int quiz2, int quiz3, int midterm, int final) : this()
        {
            SetQuiz(1, quiz1);
            SetQuiz(2, quiz2);
            SetQuiz(3, quiz3);

            SetMidterm(midterm);

            SetFinal(final);
        }

        public void SetQuiz(int quizNumber, int score)
        {
            if (quizNumber <= 3 && quizNumber >= 1)
            {
                quiz[quizNumber - 1] = score;
            }
        }

        public void SetMidterm(int score)
        {
            midterm = score;
        }

        public void SetFinal(int score)
        {
            final = score;
        }

        public string GetLetterGrade()
        {
            double score = GetOverallGrade();

            if (score >= 90)
            {
                return "A";
            }

            if (score >= 80)
            {
                return "B";
            }

            if (score >= 70)
            {
                return "C";
            }

            if (score >= 60)
            {
                return "D";
            }

            return "F";
        }

        public double GetOverallGrade()
        {
            int quiz_total = 0;
            foreach (int score in quiz)
            {
                quiz_total += score;
            }

            double quiz_score = (quiz_total / (double)30) * .25;
            double midterm_score = (midterm / (double)100) * .35;
            double final_score = (final / (double)100) * .40;

            double overall = quiz_score + midterm_score + final_score;
            return Math.Round((overall * 100), 2);
        }

        public override string ToString()
        {
            return GetOverallGrade().ToString() + ", " + GetLetterGrade(); 
        }

        public override bool Equals(object obj)
        {
            StudentRecord newrec = (StudentRecord)obj;
            return GetOverallGrade() == newrec.GetOverallGrade();
        }
    }
}
