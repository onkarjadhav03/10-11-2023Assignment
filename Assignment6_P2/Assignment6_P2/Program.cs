using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment6_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrade = new ArrayList()
            {
                85,92,78,95,88
            };

            int sum = 0;

            Console.WriteLine("Student Grades");
            foreach (int i in studentGrade)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("sum of grades:" + sum);

            studentGrade.Add(90);

            Console.WriteLine("StudentGrades after adding new grade");
            foreach (int i in studentGrade)
            {
                Console.WriteLine(i);
            }

            studentGrade.Remove(78);
            Console.WriteLine("StudentGrades after deleting");
            foreach (int i in studentGrade)
            {
                Console.WriteLine(i);
            }

            if (studentGrade.Contains(95))
            {
                int update=studentGrade.IndexOf(95);
                studentGrade[update] = 96;
                Console.WriteLine("StudentGrades after updation");
                foreach (int i in studentGrade)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("grade 95 not found");
            }
        }
    }
}
