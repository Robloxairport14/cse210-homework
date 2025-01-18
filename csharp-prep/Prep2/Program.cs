using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your percentage in your grade?");
        
        string number = Console.ReadLine();
        int grade = int.Parse(number);   
  
        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("You got an 'A'");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("You got a 'B'");
        }
        else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("You got a 'C'");
        }
        else if (grade >= 60 && grade <= 69)
        {
            Console.WriteLine("You got a 'D'");
        }
        else
        {
            Console.WriteLine("You got an 'F'");
        }
    }
}