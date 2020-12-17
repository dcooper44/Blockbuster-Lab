using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Blockbuster
    {

        public static List<Movie> CreateList()
        {
            List<Movie> Movies = new List<Movie>();

            DVD TheOtherGuys = new DVD();
            TheOtherGuys.Title = "The Other Guys";
            TheOtherGuys.Category = Genre.Comedy;
            TheOtherGuys.RunTime = 116;
            TheOtherGuys.Scenes = new List<string>
            {
                {"Desk Pop" },
                {"B.S. Explosion" },
                {"Dirty Mike and The Boys" }
            };

            DVD Moneyball = new DVD();
            Moneyball.Title = "Moneyball";
            Moneyball.Category = Genre.Drama;
            Moneyball.RunTime = 123;
            Moneyball.Scenes = new List<string>
            {
                {"The A's Lose" },
                {"The A's Win" },
                {"The A's Lose Again" }
            };

            DVD HarryPotterandthePrisonerofAzkaban = new DVD();
            HarryPotterandthePrisonerofAzkaban.Title = "Harry Potter and the Prisoner of Azkaban";
            HarryPotterandthePrisonerofAzkaban.Category = Genre.Action;
            HarryPotterandthePrisonerofAzkaban.RunTime = 122;
            HarryPotterandthePrisonerofAzkaban.Scenes = new List<string>
            {
                {"Sirius is Back" },
                {"Shreiking Shack" },
                {"Time Turner" }
            };


            VHS StickIt = new VHS();
            StickIt.Title = "Stick It";
            StickIt.Category = Genre.Drama;
            StickIt.RunTime = 103;
            StickIt.Scenes = new List<string>
            {
                {"she chokes at worlds" },
                {"biking with friends" },
                {"joins VGA" },
            };


            VHS RememberTheTitans = new VHS();
            RememberTheTitans.Title = "Remember The Titans";
            RememberTheTitans.Category = Genre.Drama;
            RememberTheTitans.RunTime = 120;
            RememberTheTitans.Scenes = new List<string>
            {
                {"Coach Boone Shows Up"},
                {"Aint No Mountain High" },
                {"Ryan Reynolds being an absolute liability at cornerback" }
            };

            VHS FridayThe13th = new VHS();
            FridayThe13th.Title = "Friday The 13th";
            FridayThe13th.Category = Genre.Horror;
            FridayThe13th.RunTime = 95;
            FridayThe13th.Scenes = new List<string>
            {
                {"They all show up to Summer Camp" },
                {"Jason murders some people" },
                {"Jason walks away for the next movie" }
            };

            Movies.Add(TheOtherGuys);
            Movies.Add(Moneyball);
            Movies.Add(HarryPotterandthePrisonerofAzkaban);
            Movies.Add(StickIt);
            Movies.Add(RememberTheTitans);
            Movies.Add(FridayThe13th);

            return Movies;
        }

        public static void PrintMovies(List<Movie> movies)
        {
            int index = 0;

            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{index}: {movie.Title}");
                index += 1;
            }
        }

        public static Movie CheckOut()
        {
            bool keepLooping;
            do
            {
                List<Movie> movieList = CreateList();
                Movie userMovieSelection;


                Console.WriteLine("Please Select A Movie To Check Out");
                PrintMovies(movieList);
                string userInput = Console.ReadLine();


                if (int.TryParse(userInput, out int intMovie) && intMovie >= 0 && intMovie <= movieList.Count)
                {
                    movieList[intMovie].PrintInfo();
                    userMovieSelection = movieList[intMovie];
                    Console.WriteLine($"{userMovieSelection.Title} is now checked out");
                    keepLooping = false;
                    return userMovieSelection;
                }
                else
                {
                    Console.WriteLine("Please Try Again");
                    keepLooping = true;
                }
            } while (keepLooping);
            return default;





        }
    }
}





