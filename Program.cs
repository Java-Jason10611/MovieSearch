using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace MovieSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = ListInitializer();
            bool validSelection = false;
            while (validSelection == false)
            {
                Console.WriteLine("Would you like to:");
                Console.WriteLine("[1]: Search by NAME");
                Console.WriteLine("[2]: Search by CATEGORY");
                uint.TryParse(Console.ReadLine(), out uint userChoice);

                if (userChoice == 1)
                {
                    var keyword = NameSearch();
                    DisplayMoviesThatMAtch(movies, keyword);
                    validSelection = true;
                    break;
                }
                if (userChoice == 2)
                {
                    var keyword = CatagorySearch();
                    DisplayMoviesThatMAtch(movies, keyword);
                    validSelection = true;
                    break;
                }
                else
                {
                    validSelection = false;
                }
            }
        }
        public static string UserInput()
        {
            bool validSelection = false;
            while (validSelection == true)
            {
                Console.WriteLine("Would you like to:");
                Console.WriteLine("[1]: Search by NAME");
                Console.WriteLine("[2]: Search by CATEGORY");
                uint.TryParse(Console.ReadLine(), out uint userChoice);

                if(userChoice==1)
                {
                    var keyword = NameSearch();
                    validSelection = true;
                    return keyword;
                }
                if(userChoice==2)
                {
                    var keyword = CatagorySearch();
                    validSelection = true;
                    return keyword;
                }
                else
                {
                    Console.WriteLine("Invalid Selection, Please try again.");
                    validSelection = false;
                    continue;
                }
            }
            return string.Empty;

        }
        public static List<Movie> ListInitializer()
        {
            var movieList = new List<Movie>();
            var Holes = new Movie("holes", "drama");
            movieList.Add(Holes);

            var Disturbia = new Movie("disturbia", "horror");
            movieList.Add(Disturbia);

            var Deadpool = new Movie("deadpool", "action");
            movieList.Add(Deadpool);

            var SpiderMan = new Movie("spider-man, into the spiderverse", "animated");
            movieList.Add(SpiderMan);

            var StarWars = new Movie("starwars", "scifi");
            movieList.Add(StarWars);

            var OnePunchMan = new Movie("one punch man", "animated");
            movieList.Add(OnePunchMan);

            var HarryPotter = new Movie("harry potter", "scifi");
            movieList.Add(HarryPotter);

            var Bellflower = new Movie("bellflower", "drama");
            movieList.Add(Bellflower);

            var StarTrek = new Movie("star trek", "scifi");
            movieList.Add(StarTrek);

            var Rubber = new Movie("rubber", "horror");
            movieList.Add(Rubber);
            return movieList;

        }
        public static string NameSearch()
        {
            Console.WriteLine("Please enter the NAME to search by");
            string search = Console.ReadLine();
            return search;
        }   
        public static string CatagorySearch()
        {
           
                Console.WriteLine("Please enter the CATEGORY to search by");
                string search = Console.ReadLine();
                return search;
        }
        public static void DisplayMoviesThatMAtch(List<Movie> movieList, string search)
        {
            int matches = 0;
            Console.WriteLine("Here's what we got:");
            foreach (Movie movie in movieList)
            {
                if (movie.Title == search.ToLower() || movie.Category == search.ToLower())
                {
                    Console.WriteLine($"Title: {movie.Title}");
                    Console.WriteLine($"Category: {movie.Category}");
                    matches++;
                }
            }
            if (matches < 1)
            {
                Console.WriteLine("No Movies Matched That Search Criteria");
            }
        }

        public class Movie
        {
            public string Title = title;
            public string Category = category;

            public Movie(string title, string category)
            {
                Category = category;
                Title = title;
            }

            public static string title { get; set; }
            public static string category { get; set; }
        }
    }
}


