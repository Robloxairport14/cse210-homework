// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //My tried code.

//         // Assignment student1 = new Assignment();
//         // student1.SetStudentName("Samuel Bennet");
//         // student1.SetTopic("Multiplication");
//         // Console.WriteLine(student1.GetSummary());

//         // MathAssignment student2 = new MathAssignment();

//         // WritingAssignment student3 = new WritingAssignment();
//         // student3.SetStudentName("Mary Waters");
//         // student3.SetTopic("European History");
//         // student3.setTitle("The Causes of World War II by Mary Waters");

//         // Console.WriteLine(student3.GetWrightingInformation());

//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}