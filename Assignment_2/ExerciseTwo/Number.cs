namespace Assignment_2.ExerciseTwo
{
    public class Number
    {
        public static (uint start, uint end) InputRange()
        {
            uint start,
                end;

            while (true)
            {
                Console.Write("Enter the minimum of the range: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input can't be empty");
                    continue;
                }

                if (!uint.TryParse(input, out start))
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

                if (!uint.TryParse(input, out end))
                {
                    Console.WriteLine("Input must not be a negative integer!");
                    continue;
                }
                if (end <= start)
                {
                    Console.WriteLine("Max must greater than min");
                    continue;
                }
                break;
            }

            return (start, end);
        }

        public static async Task<List<uint>> GetPrimesAsync(uint start, uint end)
        {
            var primeTasks = new List<Task<uint?>>();

            for (uint i = start; i <= end; i++)
            {
                primeTasks.Add(IsPrimeAsync(i));
            }

            var results = await Task.WhenAll(primeTasks);
            var primes = results.Where(r => r.HasValue).Select(r => r.Value).ToList();

            return primes;
        }

        static async Task<uint?> IsPrimeAsync(uint number)
        {
            if (number <= 1)
                return null;

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime ? number : null;
        }

        public static List<uint> GetPrimesSync(uint start, uint end)
        {
            List<uint> primes = new List<uint>();

            for (uint i = start; i <= end; i++)
            {
                IsPrimeSync(i, primes);
            }

            return primes;
        }

        static void IsPrimeSync(uint number, List<uint> primes)
        {
            if (number <= 1)
                return;

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                lock (primes)
                {
                    primes.Add(number);
                }
            }
        }

    }
}
