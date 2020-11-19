using System;

class NumbersPerDigit // Calculates the amount of digits of the introduced number. Shows the ammount of numbers in categories of one, two, three or more than three digits. 
{
    static void Main()
    {
        int counterOneDigit = 0, counterTwoDigit = 0, 
            counterThreeDigit = 0, counterThreePlusDigit = 0;
        
        Console.WriteLine("Insert a number: ");
        string input = Console.ReadLine();

        while (input != "end")
        {
            int digits = Convert.ToInt32(input);
            {
                if (digits / 10 == 0)
                {
                    counterOneDigit++;
                }

                else
                    if (digits / 100 == 0)
                    {
                        counterTwoDigit++;
                    }

                    else
                        if (digits / 1000 == 0)
                        {
                            counterThreeDigit++;
                        }

                        else
                            counterThreePlusDigit++;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
            counterOneDigit, counterTwoDigit, counterThreeDigit, counterThreePlusDigit);
    }
}