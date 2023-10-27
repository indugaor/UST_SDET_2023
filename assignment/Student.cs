using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    public class Student
    {
        public double mark1, mark2, mark3;
        public double average;

        public Student(double mark1, double mark2, double mark3)
        {
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;

        }

        public double CalculateAverage()
        {
            average = ((mark1 + mark2 + mark3) / 3);

            if (average == 0)
            {
                Console.WriteLine("Fail");
            }
            else if (average >= 90)
            {
                Console.WriteLine("A");
            }

            else if (average >= 80 && average < 90)
            {
                Console.WriteLine("B");
            }
            else if (average >= 70 && average < 80)
            {
                Console.WriteLine("C");
            }


            return average;
        }
    }
}
