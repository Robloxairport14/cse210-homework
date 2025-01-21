using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type '0' when finished");  

        int Geo = -1;
        int last = -2;

        while (last != Geo || Geo != last)
        {
            Console.Write("Enter a Number: ");
        
            string number = Console.ReadLine();
            int tsil = int.Parse(number);
            if (tsil != 0)
            {
                List<int> members;
                members = new List<int>();

                members.Add(tsil);
            }
            else if (tsil == 0)
            {
                break;
            }

        }

        // for (int i = 0; i < members.Count; i++)
        // {
        //     Console.WriteLine(members[i]);
        // }
        // foreach (int  member in memebers)
        // {
        //     Console.WriteLine(member);
        // }

        //I'm at a complete loss on how to do this properly in C#.

    }
}