using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your final mark");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your mark is B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("your mark is B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Your mark is C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Your mark is D");
            else if (mark >= 30 && mark <= 39)
                Console.WriteLine("Your grade is F");
            else
                Console.WriteLine("There was a problem with the mark you entered");

            
            Console.ReadLine(); 
        

        }
    }
}
