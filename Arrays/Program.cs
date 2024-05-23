namespace Arrays
{
    internal class Program
    {
       // Has to becdeclared in the class scope so all methods have access to it.
        public static void Main(string[] args)
        {
            // Get user input for the array size
            Console.Write("Enter the size of the array: ");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer for the array size: ");
            }

            // Declare and randomize the array
            int[] numbers = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(1, 101); // Random numbers between 1 and 100
            }

            // Perform calculations
            int sum = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arraySize; i++)
            {
                int number = numbers[i];
                sum += number;

                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest)
                {
                    smallest = number;
                }

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            double average = (double)sum / arraySize;

            // Display the results
            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Largest Element: " + largest);
            Console.WriteLine("Smallest Element: " + smallest);
            Console.WriteLine("Even Count: " + evenCount);
            Console.WriteLine("Odd Count: " + oddCount);
        }
    }
}