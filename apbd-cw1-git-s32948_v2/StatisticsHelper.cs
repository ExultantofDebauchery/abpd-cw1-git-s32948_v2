using System;

public class StatisticsHelper
{
    public static double Average(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum / numbers.Length;
    }
}