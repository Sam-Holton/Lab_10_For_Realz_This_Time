using System;

namespace Lab_10_For_Realz_This_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int userChoice;
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
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    default: break;
                }

            } while (true);
        }
    }

    public class Movie
    {
        private string _title;
        private string _category;

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
