using Microsoft.VisualBasic;
using System;
namespace Assignment2BySobiaBashir
{
	internal class TempCelciusFromF
	{
        public static double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public void CalculateCelcius()
        {

            Console.WriteLine("Fahrenheit\tCelsius");
            Console.WriteLine("-------------------------");
            int iter=1;
            for (int fahrenheit = 0; fahrenheit <= 100; fahrenheit++)
            {
                double celsius = ConvertToCelsius(fahrenheit);
                Console.WriteLine("{0}\t\t{1}", fahrenheit, celsius);
                if (iter % 20 == 0)
                {
                    Console.WriteLine("Firt 20 inputs data has been printed.Do you want to print more data ?");
                    Console.WriteLine("Press y/Y(yes) or n/N(no)");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    // Get the character from the key pressed
                    char inputChar = keyInfo.KeyChar;

                    if (inputChar == 'y' || inputChar == 'Y')
                    {
                        iter = 1;
                        continue;
                    }
                    if (inputChar == 'n' || inputChar == 'N')
                    {
                        break;
                    }
                }
                iter++;
            }
        }
        public void Start()
        {
            CalculateCelcius();
        }


    }
}
