namespace Challenge_Lab_Week_4___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100]; // Array to store elements
            int n; // Number of elements
            Dictionary<int, int> frequency = new Dictionary<int, int>(); // Dictionary to store frequencies

            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                // Update the frequency map
                if (frequency.ContainsKey(arr[i]))
                {
                    frequency[arr[i]]++; // Increment frequency
                }
                else
                {
                    frequency[arr[i]] = 1; // Initialize frequency
                }
            }

            Console.WriteLine("\nFrequency of all elements of the array:");
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times");
            }
        }
    }
}
