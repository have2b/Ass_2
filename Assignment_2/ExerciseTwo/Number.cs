namespace Assignment_2.ExerciseTwo
{
    public class Number
    {
        public static (uint min, uint max) InputRange()
        {
            uint min,
                max;

            while (true)
            {
                Console.Write("Enter the minimum of the range: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input can't be empty");
                    continue;
                }

                if (!uint.TryParse(input, out min))
                {
                    Console.WriteLine("Invalid input! Input must not be a negative integer!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter the maximum of the range: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input can't be empty");
                    continue;
                }

                if (!uint.TryParse(input, out max))
                {
                    Console.WriteLine("Input must not be a negative integer!");
                    continue;
                }
                if (max <= min)
                {
                    Console.WriteLine("Max must greater than min");
                    continue;
                }
                break;
            }

            return (min, max);
        }

        public static async Task<List<uint>> GetPrimesAsync(uint min, uint max)
        {
            List<uint> primes = new List<uint>();
            for (uint i = min; i <= max; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }

            return primes;
        }

        private static bool IsPrime(uint number)
        {
            if (number <= 1)
                return false;

            for (uint i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
