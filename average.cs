using System;

public class AverageMark  //Calculates and shows average value from numeric inputs until "end" is typed.
{
    public static void Main()
    {
        double mark, average, sum = 0, counter = 0;
        string input;
    
        Console.Write("Insert a mark: ");
        input = Console.ReadLine(); 
    
        while (input != "end")
        {
        	Console.Write("Insert a mark: ");
            mark = Convert.ToDouble(input);
            input = Console.ReadLine();

            sum+= mark;
            counter ++;
        }
    
        if (counter != 0)
        {
            average = sum / counter;
            Console.WriteLine("The average is {0}." , average);
        }
    }
}