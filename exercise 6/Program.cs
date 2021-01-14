using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            
            

            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to contnue (y/n)?");
                answer = Console.ReadLine();

            } while (answer == "y"); 
                
        }
    }
}
