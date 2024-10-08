using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Put your personal information here!
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();

        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What's your hair color?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("What's your shoe size");
        string shoeSize = Console.ReadLine();

        Console.WriteLine("What's your favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("What is your favorite television show or movie?");
        string favShow = Console.ReadLine();

        Console.WriteLine("Who's your favorite teacher?");
        string favTeach = Console.ReadLine();

        Console.WriteLine("what's your favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("What's your favorite holiday?");
        string favHoliday = Console.ReadLine();

        Console.WriteLine("What's your favorite season?");
        string favSeason = Console.ReadLine();

        Console.WriteLine("What's your dream job?");
        string dreamJob = Console.ReadLine();

        // Age + 5
        string numberAge = "5";
        int age = int.Parse(numberAge);

        Console.WriteLine("How many siblings do you have?");
        string numbSiblings = Console.ReadLine();


        // The stuff they gave us will now be used to write some sentences in the terminal
        Console.WriteLine("My friend's name is " + name);

        Console.WriteLine(name + " is " + age + " years old");

        Console.WriteLine(name + "'s eye color is " + eyeColor);

        Console.WriteLine(name + "'s hair color is " + hairColor);

        Console.WriteLine(name + "'s shoe size is " + shoeSize);

        Console.WriteLine(name + "'s favorite color is " + favColor);

        Console.WriteLine(name + "'s favorite TV show or movie is " + favShow);

        Console.WriteLine(name + "'s favorite teacher is " + favTeach);

        Console.WriteLine(name + "'s favorite class is " + favClass);

        Console.WriteLine(name + "'s favorite holiday is " + favHoliday);

        Console.WriteLine(name + "'s favorite season is " + favSeason);

        Console.WriteLine(name + "'s dream job is " + dreamJob);

        Console.WriteLine(name + " will be " + age + numberAge + " in 5 years");

        Console.WriteLine(name + " has " + numbSiblings + " siblings");
    }
}