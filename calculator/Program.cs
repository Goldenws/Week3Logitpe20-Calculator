using System;
using System.Runtime.InteropServices.ComTypes;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What is the maximum score");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;

            Console.WriteLine($"You scored {Result}%.");
            /*>90% - 5
             *>80% - 4
             *>61% - 3
             * - 2
             
             */
            if(Result >= 90)
            {
                Console.WriteLine("Congrats your grade is 5");
                
            }else if (Result >= 80)
            {
                Console.WriteLine("Good work your grade is 4");

            }else if (Result >= 61)
            {
                Console.WriteLine("Your grade is 3, its fine but you can try better next time");

            }
            else
            {
                Console.WriteLine("Oh no your grade is 2 try again");
            }
        }
    }
}
