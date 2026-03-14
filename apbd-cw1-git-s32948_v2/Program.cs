// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Daj liczby rozdzielone przecinkami: ");
        try
        {
            string line = Console.ReadLine();
            int[] numbers = line.Split(',').Select(x => int.Parse(x)).ToArray();
            double avg = StatisticsHelper.Average(numbers);
            Console.WriteLine("Srednia: " + avg);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Mialy byc liczby >:(");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}