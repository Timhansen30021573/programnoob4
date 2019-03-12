using System;//* Tim Hansen error checking *//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and i will tell you if its odd or even");
            int result;
            if (int.TryParse(Console.ReadLine(), out result))
            {

                if (result % 2 == 0)
                    Console.WriteLine($"{result} is an even number.");
                else
                    Console.WriteLine($"{result}is an odd number");



            }

            else Console.WriteLine("Error, that was not a valid number");
            Console.ReadLine();
        }
    }
}
