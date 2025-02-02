using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator p1 = new PromptGenerator();
        p1._1 = "What's the highlight of your week so far?";
        p1._2 = "Did anything exciting happen to you today?";
        p1._3 = "What have you been up to recently?";
        p1._4 = "Have you discovered any new hobbies lately?";
        p1._5 = "What's been the best part of your day?";
        p1._6 = "How are you feeling today?";
        p1._7 = "Any interesting plans for the weekend?";
        p1._8 = "What did you have for lunch/dinner?";
        p1._9 = "Did you watch any good movies or shows recently?";
        p1._10 = "Have you read any good books lately?";
        p1._11 = "What's your favorite way to unwind after a long day?";
        p1._12 = "Any fun projects you're working on?";
        p1._13 = "What's something new you learned today?";
        p1._14 = "Have you visited any cool places recently?";
        p1._15 = "What music have you been listening to?";
        p1._16 = "Did you have any interesting conversations today?";
        p1._17 = "What's the most memorable part of your day?";
        p1._18 = "Any exciting news to share?";
        p1._19 = "How's the weather treating you?";
        p1._20 = "Have you tried any new recipes or restaurants recently?";
        p1._21 = "What's your go-to way to relax?";
        p1._22 = "Any fun adventures planned?";
        p1._23 = "How's work/school going for you?";
        p1._24 = "What's been keeping you busy lately?";
        p1._25 = "Any new goals or resolutions?";
        p1._26 = "Have you picked up any new skills or talents recently?";
        p1._27 = "What is something you are looking forward to?";
        p1._28 = "How do you like to spend your free time?";
        p1._29 = "What's the funniest thing that happened to you today?";
        p1._30 = "Have you attended any events or gatherings recently?";
        p1._31 = "What's your favorite way to spend a lazy Sunday?";
        p1._32 = "Did you encounter any challenges today?";
        p1._33 = "How do you stay motivated during the week?";
        p1._34 = "Have you met anyone interesting recently?";
        p1._35 = "What's your favorite way to start the day?";
        p1._36 = "Any favorite podcasts or radio shows?";
        p1._37 = "What's your current favorite snack?";
        p1._38 = "Did you see any interesting news stories today?";
        p1._39 = "How do you stay organized with your tasks?";
        p1._40 = "Any interesting observations from today?";
        p1._41 = "Have you been working on any creative projects?";
        p1._42 = "What's your favorite way to get some fresh air?";
        p1._43 = "Did you have any unexpected surprises today?";
        p1._44 = "What's your favorite way to spend a rainy day?";
        p1._45 = "Any exciting travel plans coming up?";
        p1._46 = "How do you stay positive and motivated?";
        p1._47 = "What's the best compliment you've received recently?";
        p1._48 = "Have you caught up with any old friends lately?";
        p1._49 = "What's your go-to way to de-stress?";
        p1._50 = "Did you have any 'aha' moments today?";
        p1._51 = "What's your favorite way to stay active?";
        p1._52 = "How do you stay connected with loved ones?";
        p1._53 = "What's your favorite way to end the day?";
        p1._54 = "Did you encounter any funny or unusual situations today?";
        p1._55 = "How do you manage your time effectively?";
        p1._56 = "Any cool apps or tools you've discovered recently?";
        p1._57 = "What's your favorite way to celebrate small victories?";
        p1._58 = "Did you try anything new today?";
        p1._59 = "How do you handle busy days?";
        p1._60 = "Any exciting updates on your life?";
        p1._61 = "What's your favorite way to boost your mood?";
        p1._62 = "Did you have any meaningful conversations today?";
        p1._63 = "How do you like to treat yourself?";
        p1._64 = "Any interesting articles or videos you came across recently?";
        p1._65 = "What's your favorite way to unwind before bed?";
        p1._66 = "Did you accomplish any goals today?";
        p1._67 = "How do you stay focused throughout the day?";
        p1._68 = "Any inspiring quotes or thoughts on your mind?";
        p1._69 = "What's the most interesting thing you learned today?";
        p1._70 = "How do you handle unexpected changes in your plans?";
        p1._71 = "Any fun weekend plans?";
        p1._72 = "What's your favorite way to recharge?";
        p1._73 = "Did you notice anything beautiful or interesting today?";
        p1._74 = "How do you stay productive during the day?";
        p1._75 = "Any hobbies you're passionate about?";
        p1._76 = "What's your favorite way to spend quality time with others?";
        p1._77 = "Did you experience any acts of kindness today?";
        p1._78 = "How do you keep a positive mindset?";
        p1._79 = "Any exciting discoveries or realizations?";
        p1._80 = "What's your favorite way to explore new places?";
        p1._81 = "Did you have any memorable interactions today?";
        p1._82 = "How do you stay organized and on top of things?";
        p1._83 = "Any new trends or topics you're curious about?";
        p1._84 = "What's your favorite way to stay entertained?";
        p1._85 = "Did you have any moments of reflection today?";
        p1._86 = "How do you like to pamper yourself?";
        p1._87 = "Any new routines or habits you've started?";
        p1._88 = "What's your favorite way to relax after a busy day?";
        p1._89 = "Did you encounter any challenges or obstacles today?";
        p1._90 = "How do you stay motivated and inspired?";
        p1._91 = "Any recent accomplishments you're proud of?";
        p1._92 = "What's your favorite way to spend a sunny day?";
        p1._93 = "Did you try anything different today?";
        p1._94 = "How do you handle stressful situations?";
        p1._95 = "Any new adventures on the horizon?";
        p1._96 = "What's your favorite way to show appreciation to others?";
        p1._97 = "Did you have any unexpected laughs today?";
        p1._98 = "How do you like to stay creative?";
        p1._99 = "Any fun memories from today?";
        p1._100 = "What's your favorite way to stay connected with your community?";
        
        //myJournal.Display();
    }
}