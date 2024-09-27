using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumbers = -1;

        while (userNumbers != 0)
        {
            Console.WriteLine("Enter a number, type 0 when finished: ");
            string userResponse = Console.ReadLine();
            userNumbers = int.Parse(userResponse);
            numbers.Add(userNumbers);
            
        }
        int sum = 0;
        int max = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum of the numbers is {sum}.");
        Console.WriteLine($"The average is {((float)sum) / numbers.Count}.");
        Console.WriteLine($"The largest number is {max}.");
    }
}