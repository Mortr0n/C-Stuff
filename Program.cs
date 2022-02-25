using System;
using static System.Console;
namespace FirstCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // string place = "Chris Morton";
            Random rand = new Random();
            int randNumber = rand.Next(1,101);
            // DownThenUp(5, 10);
            Console.WriteLine($"The return is {WhileReturn(randNumber)}");
        }

        private static void NewMethod(string place)
        {
            WriteLine($"Hello {place}");
        }

        private static void CountDown(int number)
        {
            for(int i = number; i >= 0; i-- ) 
            {
                Console.WriteLine($"The number is {i}");
            }
        }

        private static void DownThenUp(int firstNumber, int secondNumber) 
        {
            for(int i = firstNumber; i >= 0; i--)
            {
                Console.WriteLine($"Counting down: {i}");
            }
            for(int i = 0; i <= secondNumber; i++) 
            {
                Console.WriteLine($"Counting back up: {i}");
            }
        }

        

        private static int WhileReturn(int myNumber)
        {
            int i = 1;
            while(i <= myNumber)
            {
                Console.WriteLine($"While Loop: {i}");
                i++;
            }
            return myNumber;
        }
        
    }
}