using System;

public class Program
{
    public static string name;
    public static string age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string favColor;
    public static string favShow;
    public static string favTeach;
    public static string favClass;
    public static string favHoliday;
    public static string favSeason;
    public static string dreamJob;
    public static int numberAge;
    public static string numbSiblings;

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years();
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
    }

    public static void AskAge()
    {
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What's your hair color?");
        string hairColor = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What's your shoe size");
        string shoeSize = Console.ReadLine();
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("What's your favorite color?");
        string favColor = Console.ReadLine();
    }

    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite television show or movie?");
        string favShow = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who's your favorite teacher?");
        string favTeach = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("what's your favorite class?");
        string favClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What's your favorite holiday?");
        string favHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What's your favorite season?");
        string favSeason = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("What's your dream job?");
        string dreamJob = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years()
    {
        int numberAge = int.Parse(age + 5);
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        string numbSiblings = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {
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
        Console.WriteLine(name + " will be " + numberAge + " in 5 years");
        Console.WriteLine(name + " has " + numbSiblings + " siblings");
    }
}