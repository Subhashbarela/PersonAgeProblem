using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionAgeProgram
{
    public class Person
    {
        public void ValidAge(int age)
        {
            if (age >= 1 && age <= 14)
            {
                Console.WriteLine("Children ");
            }
            else if (age >= 15 && age <= 24)
            {
                Console.WriteLine("Youth person");
            }
            else if (age > 24 && age <= 64)
            {
                Console.WriteLine("Adults person");
            }
            else if (age > 64 && age < 130)
            {
                Console.WriteLine("Seniors person");
            }
            else
            {
                Console.WriteLine("Please insert valid age");
            }
        }
    }
}
