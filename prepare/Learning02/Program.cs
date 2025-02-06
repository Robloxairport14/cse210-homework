using System;

class Program
{

    static void DisplayMenu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add new Job");
        Console.WriteLine("2. Display Resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Resume theResume = new Resume();

        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("enter choice");
            string choice = Console.ReadLine();



            if (choice == "1")
            {
                //display job
                Console.Write("name of company");
                string company = Console.ReadLine();

                Console.Write("what is your position");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume._jobs.Add(newJob);

            }
            
            else if (choice == "2")
            {
                //display resume
                theResume.Display();
            }
            
            else if (choice == "3")
            {
                //Quit
                keepRunning = false;
            }

            else
            {
                Console.WriteLine("try again");
            }
        }
        
        
        
        
        
        
        // Job job1 = new Job();
        // job1._company = "Microsoft";
        // job1._jobTitle = "Software Engineer";
        // job1._startYear = 2018;
        // job1._endYear = 2019;

        // Job job2 = new Job();
        // job2._company = "Apple";
        // job2._jobTitle = "Manager";
        // job2._startYear = 2020;
        // job2._endYear = 2022;

        // Resume eman = new Resume();
        // eman._name = "Dylan Durtschi";

        // Displayman(eman);

        // static void Displayman(Resume cMe)
        // {
        //     Console.WriteLine($"Name: {cMe._name}");
        //     Console.WriteLine("Jobs:");
        // }

        // DisplayJob1(job1);
        
        // static void DisplayJob1(Job aJob)
        // {
        //     Console.WriteLine($"{aJob._jobTitle} ({aJob._company}) {aJob._startYear}-{aJob._endYear}");
        // }

        // DisplayJob2(job2);

        // static void DisplayJob2(Job bJob)
        // {
        //     Console.WriteLine($"{bJob._jobTitle} ({bJob._company}) {bJob._startYear}-{bJob._endYear}");
        // }

    }
}

//sample solution \/

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Job job1 = new Job();
//         job1._jobTitle = "Software Engineer";
//         job1._company = "Microsoft";
//         job1._startYear = 2019;
//         job1._endYear = 2022;

//         Job job2 = new Job();
//         job2._jobTitle = "Manager";
//         job2._company = "Apple";
//         job2._startYear = 2022;
//         job2._endYear = 2023;

//         Resume myResume = new Resume();
//         myResume._name = "Allison Rose";

//         myResume._jobs.Add(job1);
//         myResume._jobs.Add(job2);

//         myResume.Display();
//     }
// }