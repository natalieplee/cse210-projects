using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"Your grade: {letter}. ");

        if (grade >= 70)
        {
            Console.Write("Congratulations, you have passed the class!");
        }
        else
        {
            Console.Write("You did not pass the class. Try a little harder next time.");
        }

    }
}