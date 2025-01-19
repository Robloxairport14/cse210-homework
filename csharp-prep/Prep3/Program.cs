using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's the lucky number?");
        
        string guesstr = Console.ReadLine();
        
        
        int guess = int.Parse(guesstr);   
        
        Random randomGenerator = new Random();
        
        int number = randomGenerator.Next(1, 200); 
        
        foreach (guess = number)
        {
            string response;

            do
            {
                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();
            } while (response == "yes");
        }
        foreach (guess < number)
        {
            Console.Write("Higher");
        }


        foreach (guess > number)
        {
            Console.Write("lower");
        }
        
    }
}