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


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         DisplayWelcomeMessage();

//         string userName = PromptUserName();
//         int userNumber = PromptUserNumber();

//         int squaredNumber = SquareNumber(userNumber);

//         DisplayResult(userName, squaredNumber);
//     }

//     static void DisplayWelcomeMessage()
//     {
//         Console.WriteLine("Welcome to the program!");
//     }

//     static string PromptUserName()
//     {
//         Console.Write("Please enter your name: ");
//         string name = Console.ReadLine();

//         return name;
//     }

//     static int PromptUserNumber()
//     {
//         Console.Write("Please enter your favorite number: ");
//         int number = int.Parse(Console.ReadLine());

//         return number;
//     }

//     static int SquareNumber(int number)
//     {
//         int square = number * number;
//         return square;
//     }

//     static void DisplayResult(string name, int square)
//     {
//         Console.WriteLine($"{name}, the square of your number is {square}");
//     }
// }