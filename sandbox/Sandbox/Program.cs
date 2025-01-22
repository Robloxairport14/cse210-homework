using System;

class Program
{
    static void Main(string[] args)
    {
        
        // string adjective = GetAdjective();
        // string noun = GetNoun();
        // int number = Multiply(3, 4);
        // Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}");
        // //or {GetAdjective} in {adjective}
    

        // static int Multiply (int number1, int number2)
        // {
        //     int product = number1 * number2;

        //     return product;
        // }
        // static string GetAdjective()
        // {

        //     List<string> words = new List<string>();
        //     words.Add("red");
        //     words.Add("big");
        //     words.Add("small");
        //     words.Add("orange");
        //     words.Add("blue");
        //     words.Add("black");
        //     words.Add("funny");

        //     string adjective = words [2];

        //     return adjective;
        // }

        // static string GetNoun()
        // {
        //     string noun ="boat";

        //     return noun;
        // }


        Movie FavoriteMovie = new Movie();
        FavoriteMovie._title= "Star Wars";
        FavoriteMovie._year = 1977;
        FavoriteMovie._rating = "PG";
        FavoriteMovie._runtime = 150;

        FavoriteMovie.Display();

        DisplayMovie(FavoriteMovie);
        
        static void DisplayMovie(Movie aMovie)
        {
            Console.WriteLine($"{aMovie._title} - {aMovie._year}");
        }

    }
}