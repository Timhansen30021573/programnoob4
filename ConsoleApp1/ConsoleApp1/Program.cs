using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            Console.WriteLine("Please guess a number between 1-10");
            int guess = int.Parse(Console.ReadLine());

             if (guess == number)
                    Console.WriteLine("You got the right number, Awesome");
            
            else if (guess > number)
                Console.WriteLine("The number is to hight, try again");

            else
                Console.WriteLine("Sorry this is to low ");
            Console.ReadKey();
            // this is random number genorator// 
            Random Tim = new Random();

            Tim.Next();
            Tim.Next(100);
       
            
                    
                 

        }
    }
}
