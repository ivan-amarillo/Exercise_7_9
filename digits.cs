//Iván Amarillo Rico
/*Software: Calculate how many numbers of 1, 2, 3 o more digits are entered by 
the user until he/she types "end"*/

using System;

class digits
{
    static void Main()
    {
    //counters of number of digits a is for one digit, b is for 2 digits, c is 
    //for 3 digits and d is for more than 3 digits
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, fourOrMoreDigits = 0;
        
        Console.Write("Insert a number: ");
        string dato = Console.ReadLine();
        
        while(dato != "end")
        {
            //convert string to int
            int number = Convert.ToInt32(dato);
            if(number != 0)
            {
                if(number/10 == 0)
                {
                    oneDigit++;
                }else if (number/100 == 0)
                {
                    twoDigits++;
                }else if (number/1000 == 0)
                {
                    threeDigits++;
                }else
                {
                    fourOrMoreDigits++;
                }
            }
            dato = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit,
        twoDigits, threeDigits, fourOrMoreDigits); 
    }
}

