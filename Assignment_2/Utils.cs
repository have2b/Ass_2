using Assignment_2.ExerciseTwo;

namespace Assignment_2
{
    public class Utils
    {
        public static void DisplayExerciseOne()
        {
            Console.WriteLine("\n======= Member Program =======");
            Console.WriteLine("1. List all member");
            Console.WriteLine("2. Add new member");
            Console.WriteLine("3. Find all males in list");
            Console.WriteLine("4. Find the oldest member in list");
            Console.WriteLine("5. List all member but contain only Fullname");
            Console.WriteLine(
                "6. Return 3 lists of members who born before 2000, in 2000, and after 2000"
            );
            Console.WriteLine("7. Find the first member who was born in Ha Noi");
            Console.WriteLine("8. Clear console");
            Console.WriteLine("9. Exit program");
        }

        public static sbyte ChooseOption(int min, int max)
        {
            while (true)
            {
                Console.Write("Choose option: ");
                string input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input can't be empty");
                    continue;
                }

                if (!(sbyte.TryParse(input, out sbyte choice) && choice >= min && choice <= max))
                {
                    Console.WriteLine($"Invalid input! Choice must between {min} and {max}");
                    continue;
                }
                else
                {
                    return choice;
                }
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n======= Assignment 2 Program =======");
            Console.WriteLine("1. Member Program");
            Console.WriteLine("2. Prime numbers");
            Console.WriteLine("3. Clear console");
            Console.WriteLine("4. Exit program");
        }

        public static void DisplayExerciseTwo()
        {
            Console.WriteLine("\n======= Prime number Program =======");
        }
    }
}
