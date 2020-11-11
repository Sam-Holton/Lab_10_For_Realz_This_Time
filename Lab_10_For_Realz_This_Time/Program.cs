using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Lab_10_For_Realz_This_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            var movieList = new List<Movie>();
            string title;
            string category;

            do
            {
                Console.Clear();
                Console.WriteLine($"Welcome to the Movie List Application");
                Console.WriteLine();
                Console.WriteLine($"Please select from the following options");
                Console.WriteLine($"1: Add a movie to the list");
                Console.WriteLine($"2: Explore the list by genre");
                Console.WriteLine($"3: Quit the Applicaton");

                do
                {
                    if (int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0 && userInput < 4)
                    {
                        userChoice = userInput;
                        break;
                    }
                    else
                    {
                        Console.Write($"Invalid Input. Please Try Again: ");
                    }
                } while (true);

                switch (userChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write($"Enter the Title of the Movie: ");
                            do
                            {
                                title = Console.ReadLine();
                            
                                if (string.IsNullOrEmpty(title))
                                {
                                    Console.Write($"Try typing something this time: ");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            Console.Clear();
                            Console.WriteLine($"1: SciFi");
                            Console.WriteLine($"2: Horror");
                            Console.WriteLine($"3: Drama");
                            Console.WriteLine($"4: Animated");
                            Console.WriteLine();
                            Console.Write($"Now which Genre does this movie belong to? (1-4): ");

                            do
                            {
                                if (int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0 && userInput < 5)
                                {
                                    userChoice = userInput;
                                    break;
                                }
                                else
                                {
                                    Console.Write($"Invalid Input. Please Try Again: ");
                                }
                            } while (true);

                            switch (userChoice)
                            {
                                case 1:
                                    {
                                        category = "SciFi";
                                        movieList.Add(new Movie(title, category));
                                        break;
                                    }
                                case 2:
                                    {
                                        category = "Horror";
                                        movieList.Add(new Movie(title, category));
                                        break;
                                    }
                                case 3:
                                    {
                                        category = "Drama";
                                        movieList.Add(new Movie(title, category));
                                        break;
                                    }
                                case 4:
                                    {
                                        category = "Animated";
                                        movieList.Add(new Movie(title, category));
                                        break;
                                    }
                                default: break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine($"1: SciFi");
                            Console.WriteLine($"2: Horror");
                            Console.WriteLine($"3: Drama");
                            Console.WriteLine($"4: Animated");
                            Console.WriteLine();
                            Console.Write($"Which genre are you interested in (1-4): ");

                            do
                            {
                                if (int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0 && userInput < 5)
                                {
                                    userChoice = userInput;
                                    break;
                                }
                                else
                                {
                                    Console.Write($"Invalid Input. Please Try Again: ");
                                }
                            } while (true);

                            switch (userChoice)
                            {
                                case 1:
                                    {
                                        category = "SciFi";
                                        foreach (var Movie in movieList)
                                            if (Movie.Category.Equals(category))
                                            {
                                                Console.WriteLine(Movie.Title);
                                            }
                                        Console.ReadLine();
                                        break;
                                    }
                                case 2:
                                    {
                                        category = "Horror";
                                        foreach (var Movie in movieList)
                                            if (Movie.Category.Equals(category))
                                            {
                                                Console.WriteLine(Movie.Title);
                                            }
                                        Console.ReadLine();
                                        break;
                                    }
                                case 3:
                                    {
                                        category = "Drama";
                                        foreach (var Movie in movieList)
                                            if (Movie.Category.Equals(category))
                                            {
                                                Console.WriteLine(Movie.Title);
                                            }
                                        Console.ReadLine();
                                        break;
                                    }
                                case 4:
                                    {
                                        category = "Animated";
                                        foreach (var Movie in movieList)
                                            if (Movie.Category.Equals(category))
                                            {
                                                Console.WriteLine(Movie.Title);
                                            }
                                        Console.ReadLine();
                                        break;
                                    }

                                default: break;
                            }

                            break;
                        }
                    case 3: break;
                    default: break;
                }
            } while (userChoice != 3);
        }
    }

    public class Movie
    {
        private string _title;
        private string _category;


        public Movie() { }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }

}
