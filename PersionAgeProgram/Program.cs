using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionAgeProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter the Age of Person");
            int age=int.Parse(Console.ReadLine());
            p.ValidAge(age);
        }
    }
}
