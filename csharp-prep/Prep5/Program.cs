using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        Console.Write("Who is this? ");
        
        string userName = Console.ReadLine();

        static void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

        static int AddNumbers(int thurst)
        {
            Console.Write("Please enter your favorite number: ");

            thurst = int.Parse(Console.ReadLine());

            // static int SquareNumber(int thurst, int prucart)
            // {
            //     prucart = thurst * thurst;
            //     return prucart;
            // }
            return thurst;
        }

        static void DisplayResult()
        {
            Console.WriteLine($"{DisplayPersonalMessage}, the square of your number is"); // {SquareNumber}
        }
    
    }
}