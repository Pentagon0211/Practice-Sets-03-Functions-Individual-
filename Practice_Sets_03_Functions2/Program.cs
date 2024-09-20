using System.ComponentModel.Design;

namespace Practice_Sets_02_Functions2;

class Program

{
    static int leapyear(int year)
    {
        
        if (year % 4 == 0) // && year % 100 != 0 && year % 400 == 0)
        {

            if (year % 100 != 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");                
            }
            else
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"The year {year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"The year {year} is not a leap year.");
                }
            }
            
        }
        else
        {
            Console.WriteLine($"The year {year} is not a leap year.");
        }
        return year;
    }
    
    
    
    static void Main(string[] args)
    {
        while (true)
        {
            Program program = new Program();
            Console.Write("Enter the year you want to check if its leap year or not: ");
            int year = int.Parse(Console.ReadLine());
            year = leapyear(year);
        }

    }
}