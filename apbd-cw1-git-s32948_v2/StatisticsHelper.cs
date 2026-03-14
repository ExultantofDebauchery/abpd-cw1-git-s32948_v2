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
        return  (double) sum / numbers.Length;
    }

    public static double CalculateAverage(int[] numbers)
    {
        if(numbers==null) return 0;
        double sum = 0;
        foreach (var VARIABLE in numbers)
        {
            sum += VARIABLE;
        }
        return sum / numbers.Length;
    }

    public static int CalculateMax(int[] numbers)
    {
        if(numbers==null) return 0;
        int max = numbers[0];
        foreach (var VARIABLE in numbers)
        {
            if(VARIABLE > max) max = VARIABLE;
        }
        return max;
    }
}