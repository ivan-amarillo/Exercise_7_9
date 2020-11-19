//Iván Amarillo Rico
//Software: Calculate the average of a set of marks, until types "end"

using System;

public class Average
{
    public static void Main()
    {
        double sum = 0, number, counter = 0, average;
        string mark;
        
        // we read the mark as string to check the word "end"
        Console.Write("Insert a mark: ");
        mark = Console.ReadLine(); 
        
        while(mark != "end")
        {
            //convert string to double
            number = Convert.ToDouble(mark);
            counter++;
            sum += number;
            if(counter != 0)
            {
                average = sum / counter;
                Console.WriteLine("The average is {0}.", average);
            }
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }
    }
}
