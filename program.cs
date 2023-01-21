using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
This is a madlip app where you can fill in the dots and add in your part of the story by entering the given cues. 
Start program by first running dotnet run.
      */


      // Let the user know that the program is starting:
Console.WriteLine("Welcome to Mad Libs!");

      // Give the Mad Lib a title:
      string title = "The Story That Happened One Day";

      Console.WriteLine(title);
      // Define user input and variables:
Console.Write("Enter a Name: ");
string name = Console.ReadLine();

Console.Write("Enter your first adjective: ");
string adj1 = Console.ReadLine();
Console.Write("Enter your second adjective: ");
string adj2 = Console.ReadLine();
Console.Write("Enter your third adjective: ");
string adj3 = Console.ReadLine();
Console.Write("Enter your verb: ");
string verb1 = Console.ReadLine();
Console.Write("Enter your first noun: ");
string noun1 = Console.ReadLine();
Console.Write("Enter your first noun: ");
string noun2 = Console.ReadLine();
Console.Write("Enter in an animal: ");
string animal = Console.ReadLine();
Console.Write("Enter in a food: ");
string food = Console.ReadLine();
Console.Write("Enter in a fruit: ");
string fruit = Console.ReadLine();
Console.Write("Enter a superhero: ");
string superhero = Console.ReadLine();
Console.Write("Enter in a Country: ");
string country = Console.ReadLine();
Console.Write("Enter in a dessert: ");
string dessert = Console.ReadLine();
Console.Write("Enter in a year: ");
string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
Console.WriteLine(story);
    }
  }
}
