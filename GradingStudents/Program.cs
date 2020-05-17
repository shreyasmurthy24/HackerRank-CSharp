using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradecount = Convert.ToInt32(Console.ReadLine());
            List<int> grades = new List<int>();
            for (int i = 0; i < gradecount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> gradingStudents(List<int> grades)
        {
            int addNum, addNum1, num = 0;
            List<int> lst = new List<int>();
            foreach (var items in grades)
            {
                num = items;
                addNum = num + 2;
                addNum1 = num + 1;
                if (addNum % 5 == 0 && num >= 38)
                {
                    num += 2;
                    lst.Add(num);
                }
                else if (addNum1 % 5 == 0 && num >= 38)
                {
                    num += 1;
                    lst.Add(num);
                }
                else if (num < 38)
                {
                    lst.Add(num);
                }
                else if (num % 5 != 0 && num >= 38)
                {
                    lst.Add(num);
                }
                else
                {
                    lst.Add(num);
                }
            }
            return lst;
        }

    }
}
